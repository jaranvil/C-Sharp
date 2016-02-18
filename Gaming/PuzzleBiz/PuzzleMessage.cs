using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuzzleBiz.Loader;
using System.Windows.Forms;

namespace PuzzleBiz.Util
{
   public  class PuzzleMessage 
    {
        public static void showMessage(int messageId)
        {
            
            MessageBox.Show(getFriendlyMessage(messageId));
        }
       public static string getFriendlyMessage(int messageId){
           string msg;
            bool result = Configuration.messages.TryGetValue(messageId, out msg);
           return msg;

       }
    }
}
