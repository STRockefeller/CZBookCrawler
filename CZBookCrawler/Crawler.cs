using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CZBookCrawler
{
    public class Crawler
    {
        private static int delayTime = 0;
        private static List<Chapter> chapters;
        private static string novelName;
        /// <summary>
        /// 取得章節列表
        /// </summary>
        /// <param name="url"></param>
        public static void GetChapterList(string url, int delay)
        {
            delayTime = delay;
            chapters = new List<Chapter>();
            HtmlWeb webClient = new HtmlWeb();
            HtmlDocument htmlDocument = webClient.Load(url);

            novelName = htmlDocument.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "").Equals("info")).FirstOrDefault()
                .Descendants("span").Where(node => node.GetAttributeValue("class", "").Equals("title")).FirstOrDefault()
                .InnerText;

            List<HtmlNode> ulChapterList = htmlDocument.DocumentNode.Descendants("ul")
                .Where(node => node.GetAttributeValue("class", "") == "nav chapter-list").FirstOrDefault()
                .Descendants("li").ToList();

            foreach (HtmlNode li in ulChapterList)
            {
                if (li.GetAttributeValue("class", "") == "volume")
                    continue;
                Chapter chapter = new Chapter();
                chapter.name = li.Descendants("a").FirstOrDefault().InnerText;
                chapter.url = li.Descendants("a").FirstOrDefault().GetAttributeValue("href", "");
                chapters.Add(chapter);
            }
        }
        public static async Task<List<Novel>> StartCrawlerAsync()
        {
            if (chapters == null || chapters.Count == 0)
                return null;
            List<Novel> novels = new List<Novel>();
            ProgressBar progressBar = new ProgressBar();
            progressBar.Show();
            progressBar.Initialization(chapters.Count);
            foreach (Chapter chapter in chapters)
            {
                Novel novel = new Novel();
                novel.Name = novelName;
                novel.ChapterTitle = chapter.name;
                novel.ChapterContent = GetNovelContent(chapter.url);
                novels.Add(novel);
                await progressBar.progressNext();
            }
            progressBar.Close();
            return novels;
        }

        private static string GetNovelContent(string url)
        {
            Task.Delay(delayTime).Wait();
            HtmlWeb webClient = new HtmlWeb();
            HtmlDocument htmlDocument = webClient.Load("https:" + url);

            string content = htmlDocument.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "") == "content").FirstOrDefault().InnerText;

            return content;
        }
    }

    public struct Chapter
    {
        public string name;
        public string url;
    }
}