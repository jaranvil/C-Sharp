using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuzzleBiz.Model;
using PuzzleBiz.Loader;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using PuzzleBiz.Util;

namespace PuzzleBiz.Exceptions
{
    public class PuzzleException : SystemException 
    {
        public PuzzleException(Exception e , int messageId , Object[] args) {
        string msg = PuzzleMessage.getFriendlyMessage(messageId);
            if (msg==null)
            {
                msg = e.Message;
            }
                msg = String.Format(@msg, args);
                MessageBox.Show(msg);
        }

        public PuzzleException(Exception e, int messageId)
        {
            string msg = PuzzleMessage.getFriendlyMessage(messageId);
            if (msg == null)
            {
                msg = e.Message;
            }
             MessageBox.Show(e.StackTrace);
        }
        public PuzzleException(int messageId)
        {
             PuzzleMessage.showMessage(messageId);
          
        }
    }
}
