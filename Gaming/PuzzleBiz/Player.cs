using System;
using System.Collections.Generic;
using System.Text;
using PuzzleBiz.DA;
using PuzzleBiz.Loader;

namespace PuzzleBiz.Model
{
	public class Player
	{
		public int Id;
        public String Name;
		public String UserName;
		public string Password;
		public string photo;
        public bool Admin;
        public List<SavedState> states;
        public List<Score> scores;
        public DataAccess da;

        public void SaveGame(SavedState state)
        {
            if (states == null)
            {
                states = new List<SavedState>();
            }
            states.Add(state);
            state.SaveGame(this);

        }

        public SavedState LoadGame(SavedState state, string name)
        {
            if (states == null)
            {
                states = new List<SavedState>();
            }

            SavedState savedstate = state.LoadGame(this, name);
            states.Add(savedstate);
            return savedstate;
        }
		

		public static bool CheckCredential(ref Player potentialPlayer)
		{
            return Configuration.da.CheckCredentials(ref potentialPlayer);
		}
	}
}



