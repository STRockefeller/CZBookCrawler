using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CZBookCrawler
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }
        public void Initialization(int max) => progressBarCrawler.Maximum = max;
        public async Task progressNext()
        {
            progressBarCrawler.Value++;
            lblProgress.Text = $"{progressBarCrawler.Value}/{progressBarCrawler.Maximum}";
            lblProgress.Refresh();
        }

        private void button1_Click(object sender, EventArgs e) => this.Close();
    }
}
