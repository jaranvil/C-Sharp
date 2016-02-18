using System;
using System.Collections.Generic;
using System.Text;
using PuzzleBiz.Model;
using PuzzleBiz.Util;
using System.IO;
using PuzzleBiz.Loader;


namespace PuzzleBiz.DA
{
	public sealed class FileDataAccess : DataAccess
	{
        private List<Player> players = new List<Player>();
        public void loadPlayers(string file)
		{
             using (StreamReader sr = new StreamReader(Constants.getFile(file)))
                {
                    String line ;
                    Player player;
                    // Read the stream to a string
                    while ((line = sr.ReadLine())!=null){
                        player = loadFileToPlayer(line);
                        
                        if (player != null)
                        {
                            players.Add(player);
                        }
                        

                    }
                }
           
		}
        public void loadMessages(ref Dictionary<int,String> messages , string lang)
        {
            //make sure it is empty
            messages = new Dictionary<int, string>();
            
                using (StreamReader sr = new StreamReader(Constants.getLanguage(lang)))
                {
                    String line;
                    string[] values;
                    // Read the stream to a string
                    while ((line = sr.ReadLine()) != null)
                    {
                        values = StringUtil.splitLine(line);

                        if (values != null)
                        {
                            messages.Add(int.Parse(values[0]), values[1]);
                        }


                    }
                }
           
        }



		public bool CheckCredentials(ref Player player)
		{
            foreach (Player player1 in players)
            {
                if (player1.UserName.Equals(player.UserName) && (player1.Password.Equals(player.Password)))
                {
                    player = player1;
                    return true;
                }
            }
            return false;
		}

        public void SaveGame(SavedState game , Player player)
        {
            string file;   
            Configuration.ConfigurationMap.TryGetValue(Constants.STATEFILe, out file);
            using (StreamWriter sw = new StreamWriter(Constants.getFile(file),true))
            {
                //#id:date:steps:state
                sw.Write(Environment.NewLine+player.Id.ToString() +
                    ":" + game.Name+ ":" +game.Time.ToLongDateString() +
                    ":" + game.Steps + ":" + game.State);
            }
        }

        public SavedState LoadGame(SavedState game, Player playe, string name)
        {
            string file;
            string line;
            
            Configuration.ConfigurationMap.TryGetValue(Constants.STATEFILe, out file);
            System.IO.StreamReader file2 = new System.IO.StreamReader(Constants.getFile(file));
            while ((line = file2.ReadLine()) != null)
            {
                if (!line.StartsWith("#"))
                {
                    string[] data = line.Split(':');
                    if (data[1].Equals(name))
                    {
                        game.Id = Int32.Parse(data[0]);
                        game.Time = DateTime.Parse(data[2]);
                        game.Name = data[1];
                        game.Steps = Int32.Parse(data[3]);
                        game.State = data[4];
                        return game;
                    }
                }
                
            
            }

            file2.Close();


            return null;
        }

        public void SaveScore(int score){}


        private static Player loadFileToPlayer(string line)
           
        {
            List<Player> players = new List<Player>();
            char[] separators = { ':' };
            if (line.StartsWith("#"))
            {
                return null;
            }
            String[] values = line.Split(separators);
            Player player = new Player();
            player.Id = int.Parse( values[0]);
             player.Name = values[1];
              player.UserName = values[2];
              player.Password = values[3];
              player.photo =values[4];
              player.Admin = bool.Parse( values[5]);
            return player;
        }
	}
}
