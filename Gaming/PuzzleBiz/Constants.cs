using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleBiz.Util
{
    struct Constants
    {
        public const string FILE = "file";
        private const string HOME_DIRECTORY = "C:\\Users\\s0739107\\Desktop\\files";
        public const string CONFIG_FILE = "puzzle.cfg";
        public const string PLAYERFILE = "playerFile";
        public const string LANG = "lang";
        public const string PERSISTANCE = "persistance";
        public const string STATEFILe = "stateFile";

        public static string getFile(string file = Constants.CONFIG_FILE)
        {
            if (file.Equals(CONFIG_FILE))
            {
                return HOME_DIRECTORY + "\\" + CONFIG_FILE;
            }
            return HOME_DIRECTORY + "\\" + file;
        }


        public static string getLanguage(string lang)
        {
            return HOME_DIRECTORY + "\\" + lang + ".txt";
        }
    }
}