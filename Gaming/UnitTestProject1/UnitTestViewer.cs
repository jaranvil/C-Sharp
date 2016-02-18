using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzlePr.Viewer;
using System.Windows.Forms;


namespace UnitTestPuzzle
{
    [TestClass]
    public class UnitTestViewer
    {
        [TestMethod]
        public void TestCheckWinningPositive()
        {
            PrivateObject pt = new PrivateObject(typeof(MainForm));

            Panel panel = (Panel)pt.GetFieldOrProperty("panel"); 
            Button button = null ;
            int counter = 1;
            foreach (Control controls in panel.Controls)
            {
                foreach (Control control in controls.Controls)
                {
                    button = ((Button)control);
                    button.Text = counter++.ToString();
                }
            }
            //last button should have an empty string
            button.Text = String.Empty;
                
            bool actualresult = (bool)pt.Invoke("CheckWinning");
                bool expectedresult = true;

                Assert.AreEqual(expectedresult, actualresult);
           
        }
        [TestMethod]
        public void TestCheckWinningNegative()
        {
            PrivateObject pt = new PrivateObject(typeof(MainForm));
            int counter = 0;
            Panel panel = (Panel)pt.GetFieldOrProperty("panel");
            Button button;
            foreach (Control controls in panel.Controls)
            {
                foreach (Control control in controls.Controls)
                {
                    button = ((Button)control);
                    button.Text = counter++.ToString();
                }
            }

            bool actualresult = (bool)pt.Invoke("CheckWinning");
            bool expectedresult = false;

            Assert.AreEqual(expectedresult, actualresult);

        }
    }
}
