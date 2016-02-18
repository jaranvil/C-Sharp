using System;
using System.Collections.Generic;
using System.Text;
using PuzzleBiz.Model;


namespace PuzzleBiz.DA
{
	public sealed class DbDataAccess : DataAccess
	{
		public static void ConnectDB()
		{
			throw new NotImplementedException();
		}
               public void SaveGame(SavedState game , Player player){ }

        public SavedState LoadGame(SavedState game, Player playe, string name) { return null; }

        public void SaveScore(int score, Player player) { }

        public bool CheckCredentials( ref Player player)
        {
            return false;
        }
        public void loadPlayers(string connectionParameters)
        {
            
        }
        public void loadMessages(ref Dictionary<int, String> messages, string file)
        {

        }

        public List<Score> GetHighScores()
        {
            return null;
        }
	}
}
