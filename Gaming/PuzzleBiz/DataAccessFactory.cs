using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuzzleBiz.Model;
using PuzzleBiz.Util;

namespace PuzzleBiz.DA
{
    class DataAccessFactory
    {
        public static DataAccess createFactory(String persistance){
            if (Constants.FILE.Equals(persistance))
            {
                return new FileDataAccess();
            }
            return new DbDataAccess();
        }
    }
}
