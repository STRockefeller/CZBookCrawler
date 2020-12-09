using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace CZBookCrawler
{
    class BookList
    {
        private static string folderPath = @".\BookList";
        private static string filePath = folderPath + @"\BookList.json";
        public static List<string> List = GetList();

        public static List<string> GetList()
        {
            if (!File.Exists(filePath))
                return new List<string>();
            string json = "";
            using (StreamReader sr = new StreamReader(filePath))
            {
                json = sr.ReadToEnd();
                sr.Close();
            }
            return JsonConvert.DeserializeObject<List<string>>(json);

        }
        public static void SaveList()
        {
            string json = JsonConvert.SerializeObject(List);
            if (!Directory.Exists(folderPath))
                ExceptionCatch.TryMethod(() => Directory.CreateDirectory(folderPath));
            if (!File.Exists(filePath))
            {
                FileStream fs = new FileStream(filePath, FileMode.Create);
                fs.Close();
            }
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(json);
                sw.Close();
            }
        }
    }
}
