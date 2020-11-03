using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CZBookCrawler
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }

        private void btnURLConfirm_Click(object sender, EventArgs e)
        {
            //try { Crawler.GetChapterList(tbxURL.Text, Convert.ToInt32(tbxDelay.Text)); }
            //catch (Exception ex)
            //{
            //    newMessage(ex.Message);
            //    return;
            //}
            ExceptionCatch.TryMethod(() => Crawler.GetChapterList(tbxURL.Text, Convert.ToInt32(tbxDelay.Text)),
                newMessage);
            Thread thread = new Thread(threadContentAsync);
            void threadContentAsync()
            {
                getContentAsync();
                setNovelInfo();
                readNovel();
            }
            thread.Start();
            //novels = Crawler.StartCrawler();
        }

        private void btnSaveToDataBase_Click(object sender, EventArgs e)
        {
            ExceptionCatch.TryMethod(save);
            void save()
            {
                novels.ForEach(nov => nov.SaveToDataBase());
                newMessage("Finish");
            }
        }

        private void btnExportAsText_Click(object sender, EventArgs e)
        {
            ExceptionCatch.TryMethod(download);
            void download()
            {
                novels.ForEach(nov => nov.DownloadAsText());
                newMessage("Finish");
            }
        }

        private void btnNovelNameConfirm_Click(object sender, EventArgs e)
        {
            novels = DataBase.ReadNovel(tbxNovelName.Text);
            readNovel();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ExceptionCatch.TryMethod(delete);
            void delete()
            {
                DataBase.DeleteNovel(lblNovelName.Text);
                newMessage("Finish");
            }
        }

        private void tbxPage_TextChanged(object sender, EventArgs e) => readNovel(Convert.ToInt32(tbxPage.Text) - 1);

        private void btnNext_Click(object sender, EventArgs e) => nextPage();

        private void btnPrevious_Click(object sender, EventArgs e) => previousPage();

        private void tbxLog_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    nextPage();
                    break;

                case Keys.Left:
                    previousPage();
                    break;

                default:
                    break;
            }
        }
    }
}