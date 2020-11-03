using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZBookCrawler
{
    class ExceptionCatch
    {
        public static bool TryMethod(Action action, Action<string> exAction)
        {
            try
            {
                action.Invoke();
                return true;
            }
            catch (Exception ex)
            {
                exAction.Invoke(ex.Message);
                return false;
            }
        }
        public static bool TryMethod(Action action) => TryMethod(action, WriteLog);
        public static void WriteLog(string message)
        {
            string folderPath = $".\\ErrorLogs\\";
            string path = folderPath + "Logs.txt";
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
            FileStream fileStream = new FileStream(path, FileMode.Create);

            fileStream.Close();
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine($"{DateTime.Now}\t{message}");
                sw.Close();
            }
        }
    }
}
