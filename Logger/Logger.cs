using System;
using System.Collections.Generic;
using System.Text;

namespace xp.solid.Logger
{
    using System.IO;
    using System.Threading.Tasks;

    public static class Logger
    {
        public static void LogMessage(string text)
        {
            string LogginPath = AppDomain.CurrentDomain.BaseDirectory + @"\logger.txt";

            try
            {
                //Open the File
                StreamWriter sw = new StreamWriter(LogginPath);

                sw.WriteLine(text);
                
                //close the file
                sw.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
    }
}
