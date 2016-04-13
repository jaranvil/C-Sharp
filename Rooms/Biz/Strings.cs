using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biz
{    
    public class Strings
    {
        public string[] strings;

        // TODO place strings in text file
        private string[] english = {"Score", "Paused", "Rooms", "Game Over", "Start"};
        private string[] french = { "But", "Paused", "Pièces", "Jeu terminé", "Démarrer" };

        public Strings(string lang)
        {
            if (lang.Equals("eng"))
                strings = english;
            else if (lang.Equals("fr"))
                strings = french;
        }
    }
}
