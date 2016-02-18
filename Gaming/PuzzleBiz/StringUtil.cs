using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleBiz.Util
{
    struct StringUtil
    {
        //split non commented line into key value pair
        public static String[] splitLine(string line)
        {
            char[] separators = { ':' };
            if (line.StartsWith("#"))
            {
                return null;
            }
            return line.Split(separators);
        }
    }
}
