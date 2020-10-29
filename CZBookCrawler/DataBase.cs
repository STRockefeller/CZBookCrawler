using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace CZBookCrawler
{
    public class DataBase
    {
        private static DataBase instance = new DataBase();
        private readonly string dataBasePath = ".\\DataBase\\Novels.db";
        private static SQLiteConnection connection;
        /// <summary>
        /// Singleton Pattern 私有建構式
        /// </summary>
        private DataBase()
        {
            if (!Directory.Exists(".\\DataBase\\"))
                Directory.CreateDirectory(".\\DataBase\\");
            if (!File.Exists(dataBasePath))
                SQLiteConnection.CreateFile(dataBasePath);
            string connectionString = "data source =" + dataBasePath;
            connection = new SQLiteConnection(connectionString);
        }
        /// <summary>
        /// 取得實例
        /// </summary>
        /// <returns></returns>
        public static DataBase GetInstance() => instance;
        public static void CreateNewNovel(string novelName)
        {
            novelName = Novel.fileNameCorrect(novelName);
            connection.Open();
            string commandStr = $"CREATE TABLE IF NOT EXISTS {novelName}( ChapterTitle TEXT NOT NULL, ChapterContent TEXT NOT NULL);";
            SQLiteCommand command = new SQLiteCommand(commandStr, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void DeleteNovel(string novelName)
        {
            connection.Open();
            string commandStr = $"DROP TABLE {novelName} ;";
            SQLiteCommand command = new SQLiteCommand(commandStr, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void SaveNovelChapter(Novel novel)
        {
            novel.Name = Novel.fileNameCorrect(novel.Name);
            connection.Open();
            string commandStr = $"INSERT INTO {novel.Name} (ChapterTitle, ChapterContent) VALUES ('{novel.ChapterTitle}', '{novel.ChapterContent}') ;";
            SQLiteCommand command = new SQLiteCommand(commandStr, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static List<Novel> ReadNovel(string novelName)
        {
            List<Novel> novels = new List<Novel>();
            connection.Open();
            string commandStr = $"SELECT * FROM {novelName} ;";
            SQLiteCommand command = new SQLiteCommand(commandStr, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (!reader[0].Equals(DBNull.Value))
                {
                    Novel novel = new Novel();
                    novel.ChapterTitle = reader["ChapterTitle"].ToString();
                    novel.ChapterContent = reader["ChapterContent"].ToString();
                    novels.Add(novel);
                }
            }
            connection.Close();
            return novels;
        }
    }
}