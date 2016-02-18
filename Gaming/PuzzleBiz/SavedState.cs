using System;
using System.Collections.Generic;
using System.Text;
using PuzzleBiz.DA;
using PuzzleBiz.Loader;

namespace PuzzleBiz.Model
{
	public class SavedState
	{
        public int Id;
        public DateTime Time;
        public string State;
        public DataAccess Da;
        public string Name;
        public int Steps;
        public Player player;

        public void SaveGame(Player player)
		{
            Configuration.da.SaveGame(this, player);
		}

		public SavedState LoadGame(Player player, string name)
		{
            return Configuration.da.LoadGame(this, player, name);
        }
        
	}
}

