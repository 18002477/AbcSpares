using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AbcSpares
{
    public class Logger
    {
        // Private constructor
        private static Logger instance;

        // Factory method, that returns a new Logger object
        public static Logger GetLogger()
        {
            if (instance == null)
            
                return new Logger();
            return instance;            
        }

        // writing the message to a file.
        public void WriteMessage()
        {
            try
            {
                string timeStamp = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ff");
                StreamWriter sw = new StreamWriter("C:\\LoggingFile.txt");
                sw.WriteLine("A spare Item added to the file at : "+ timeStamp);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
