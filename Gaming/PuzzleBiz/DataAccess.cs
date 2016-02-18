using System;
using System.Collections.Generic;
using System.Text;
using PuzzleBiz.Model;

namespace PuzzleBiz.DA
{
	public interface DataAccess
	{
		void SaveGame(SavedState game ,Player player);

		SavedState LoadGame(SavedState game, Player playe, string name);

		void SaveScore(int score, Player player);
        List<Score> GetHighScores();

        bool CheckCredentials( ref Player player);

        void loadPlayers(String connectionParameters);
        void loadMessages(ref Dictionary<int, String> messages, string file);

	}
}
