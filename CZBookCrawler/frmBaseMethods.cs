using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CZBookCrawler
{
    public partial class frmBase : Form
    {
        private List<Novel> novels = new List<Novel>();
        private void newMessage(string message)
        {
            tbxLog.Clear();
            tbxLog.Text += message;
            tbxLog.Refresh();
            MessageBox.Show(message);
        }
        private async Task getContentAsync() => novels = await Crawler.StartCrawlerAsync();
        private delegate void setNovelInfoCallBack();
        /// <summary>
        /// 讀取完成後的控制項改變，解決跨執行緒無效
        /// </summary>
        private void setNovelInfo()
        {
            try
            {
                if (this.InvokeRequired == true)
                {
                    setNovelInfoCallBack callback = new setNovelInfoCallBack(setNovelInfo);
                    this.Invoke(callback);
                }
                else
                {
                    lblNovelName.Text = novels[0].Name;
                    btnExportAsText.Enabled = true;
                    btnSaveToDataBase.Enabled = true;
                    newMessage("Finish Crawling");
                }
            }
            catch { }
        }
        /// <summary>
        /// 顯示小說內容
        /// </summary>
        private void readNovel()
        {
            try
            {
                if (this.InvokeRequired == true)
                {
                    Action readNovelCallBack = new Action(readNovel);
                    this.Invoke(readNovelCallBack);
                }
                else
                {
                    lblMaxPage.Text = $"/{novels.Count}";
                    btnNext.Enabled = true;
                    btnPrevious.Enabled = true;
                    tbxPage.Text = "1";
                }
            }
            catch { }
        }
        private void readNovel(int chapter)
        {
            lblChapterName.Text = novels[chapter].ChapterTitle;
            tbxLog.Text = novels[chapter].ChapterContent;
            tbxLog.Refresh();
        }
        private void nextPage()
        {
            int page = Convert.ToInt32(tbxPage.Text);
            if (page < novels.Count)
                tbxPage.Text = (page + 1).ToString();
        }
        private void previousPage()
        {
            int page = Convert.ToInt32(tbxPage.Text);
            if (page > 1)
                tbxPage.Text = (page - 1).ToString();
        }
    }
}
