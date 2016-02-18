using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using PuzzleBiz.DA;
using PuzzleBiz.Util;
using PuzzleBiz.Exceptions;


namespace PuzzleBiz.Loader
{
    //sealed as final in java. Can't extend Configuration
	public sealed class Configuration
	{
        public static DataAccess da { get; private set; }
        
        public static Dictionary<string, string> ConfigurationMap = new Dictionary<string,string>();
        public static Dictionary<int, String> messages = new Dictionary<int, string>();
		public static void LoadConfiguration() 
		{
            //reset configuration
            ConfigurationMap = new Dictionary<string,string>();

            try
            {   //using to take care to close stream after reading is done.
                using (StreamReader sr = new StreamReader(Constants.getFile()))
                {
                    String line ;
                    string[] values;
                    // Read the stream to a string
                    while ((line = sr.ReadLine())!=null){
                        values  = StringUtil.splitLine(line);
                        if (values != null)
                        {
                            ConfigurationMap.Add(values[0],values[1]);
                        }
    
                    }
                }
                string persist;
                ConfigurationMap.TryGetValue(Constants.PERSISTANCE, out persist);
                da = DataAccessFactory.createFactory(persist);
                LoadMessages();
                LoadPlayers();
                
            }
            catch (FileNotFoundException e)
            {
                Object[] args = {Constants.getFile()};
                throw new PuzzleException(e , 1, args);
            }
            catch (Exception e)
            {
                //uncovered exceptions with id 9999
                throw new PuzzleException(e, 9999);
            }
		}

 

        //load players
        private static void LoadPlayers()
        {
            string playersInfo;
            ConfigurationMap.TryGetValue(Constants.PLAYERFILE, out playersInfo);
            da.loadPlayers(playersInfo);
        }

        //load messages
        private static void LoadMessages()
        {
            string lang ;
            ConfigurationMap.TryGetValue(Constants.LANG, out lang);
            da.loadMessages(ref messages, lang);
        }

	}
}
    