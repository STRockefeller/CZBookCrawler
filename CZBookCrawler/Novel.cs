using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CZBookCrawler
{
    public class Novel
    {
        /// <summary>
        /// 小說名稱
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 章節名稱
        /// </summary>
        public string ChapterTitle { get; set; }

        /// <summary>
        /// 章節內文
        /// </summary>
        public string ChapterContent { get; set; }
        /// <summary>
        /// 存到DataBase
        /// </summary>
        public void SaveToDataBase()
        {
            DataBase.CreateNewNovel(Name);
            DataBase.SaveNovelChapter(this);
        }
        /// <summary>
        /// 另存文件
        /// </summary>
        public void DownloadAsText()
        {
            string folderPath = $".\\DownLoad\\Novels\\{Name}\\";
            folderPath = fileNameCorrect(folderPath);
            string path = folderPath + ChapterTitle + ".txt";
            path = fileNameCorrect(path);
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
            FileStream fileStream = new FileStream(path, FileMode.Create);

            fileStream.Close();
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(ChapterTitle);
                sw.WriteLine(ChapterContent);
                sw.Close();
            }
        }
        /// <summary>
        /// 移除路徑中的非法字元
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string fileNameCorrect(string fileName)
        {
            fileName = fileName.Replace(" ", "");
            fileName = fileName.Replace("〜", "");
            fileName = fileName.Replace("、", "");
            fileName = fileName.Replace("《", "");
            fileName = fileName.Replace("》", "");
            fileName = fileName.Replace("。", "");
            fileName = fileName.Replace("\"", "");
            fileName = fileName.Replace("　", "");
            fileName = fileName.Replace("-", "");
            fileName = fileName.Replace("(", "");
            fileName = fileName.Replace(")", "");

            return fileName;
        }
    }
}