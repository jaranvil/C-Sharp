using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatSharp;

namespace tom
{
    class IRC
    {
        private string server = "irc.breakfastcraft.com";
        private string chan = "#bots";

        public IRC()
        {
            Random r = new Random();            
            String name = Environment.MachineName + "_" + r.Next(1000);
            Connect(name);
        }

        public void Connect(string name)
        {
            var client = new IrcClient(server, new IrcUser(name, name));

            client.ConnectionComplete += (s, e) => client.JoinChannel(chan);

            client.ChannelMessageRecieved += (s, e) =>
            {
                var channel = client.Channels[e.PrivateMessage.Source];

                if (e.PrivateMessage.Message == ".list")
                    channel.SendMessage(string.Join(", ", channel.Users.Select(u => u.Nick)));
                else if (e.PrivateMessage.Message.StartsWith(".ban "))
                {

                }
            };

            client.ConnectAsync();
        }
    }

    
}
