namespace CZBookCrawler
{
    partial class frmBase
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCrawler = new System.Windows.Forms.TabPage();
            this.tbxDelay = new System.Windows.Forms.TextBox();
            this.btnExportAsText = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveToDataBase = new System.Windows.Forms.Button();
            this.lblNovelName = new System.Windows.Forms.Label();
            this.btnURLConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpDataBase = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNovelNameConfirm = new System.Windows.Forms.Button();
            this.tbxNovelName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxLog = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblMaxPage = new System.Windows.Forms.Label();
            this.tbxPage = new System.Windows.Forms.TextBox();
            this.lblChapterName = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpCrawler.SuspendLayout();
            this.tpDataBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCrawler);
            this.tabControl1.Controls.Add(this.tpDataBase);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(319, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tpCrawler
            // 
            this.tpCrawler.Controls.Add(this.tbxDelay);
            this.tpCrawler.Controls.Add(this.btnExportAsText);
            this.tpCrawler.Controls.Add(this.label4);
            this.tpCrawler.Controls.Add(this.btnSaveToDataBase);
            this.tpCrawler.Controls.Add(this.lblNovelName);
            this.tpCrawler.Controls.Add(this.btnURLConfirm);
            this.tpCrawler.Controls.Add(this.label2);
            this.tpCrawler.Controls.Add(this.tbxURL);
            this.tpCrawler.Controls.Add(this.label1);
            this.tpCrawler.Location = new System.Drawing.Point(4, 25);
            this.tpCrawler.Name = "tpCrawler";
            this.tpCrawler.Padding = new System.Windows.Forms.Padding(3);
            this.tpCrawler.Size = new System.Drawing.Size(311, 397);
            this.tpCrawler.TabIndex = 0;
            this.tpCrawler.Text = "Crawler";
            this.tpCrawler.UseVisualStyleBackColor = true;
            // 
            // tbxDelay
            // 
            this.tbxDelay.Location = new System.Drawing.Point(99, 70);
            this.tbxDelay.Name = "tbxDelay";
            this.tbxDelay.Size = new System.Drawing.Size(68, 25);
            this.tbxDelay.TabIndex = 5;
            this.tbxDelay.Text = "10";
            // 
            // btnExportAsText
            // 
            this.btnExportAsText.Enabled = false;
            this.btnExportAsText.Location = new System.Drawing.Point(77, 290);
            this.btnExportAsText.Name = "btnExportAsText";
            this.btnExportAsText.Size = new System.Drawing.Size(164, 23);
            this.btnExportAsText.TabIndex = 2;
            this.btnExportAsText.Text = "Export As Text";
            this.btnExportAsText.UseVisualStyleBackColor = true;
            this.btnExportAsText.Click += new System.EventHandler(this.btnExportAsText_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Delay (ms)";
            // 
            // btnSaveToDataBase
            // 
            this.btnSaveToDataBase.Enabled = false;
            this.btnSaveToDataBase.Location = new System.Drawing.Point(77, 216);
            this.btnSaveToDataBase.Name = "btnSaveToDataBase";
            this.btnSaveToDataBase.Size = new System.Drawing.Size(164, 23);
            this.btnSaveToDataBase.TabIndex = 1;
            this.btnSaveToDataBase.Text = "Save to DataBase";
            this.btnSaveToDataBase.UseVisualStyleBackColor = true;
            this.btnSaveToDataBase.Click += new System.EventHandler(this.btnSaveToDataBase_Click);
            // 
            // lblNovelName
            // 
            this.lblNovelName.AutoSize = true;
            this.lblNovelName.Location = new System.Drawing.Point(6, 142);
            this.lblNovelName.Name = "lblNovelName";
            this.lblNovelName.Size = new System.Drawing.Size(89, 15);
            this.lblNovelName.TabIndex = 1;
            this.lblNovelName.Text = "lblNovelName";
            // 
            // btnURLConfirm
            // 
            this.btnURLConfirm.Location = new System.Drawing.Point(207, 73);
            this.btnURLConfirm.Name = "btnURLConfirm";
            this.btnURLConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnURLConfirm.TabIndex = 1;
            this.btnURLConfirm.Text = "Confirm";
            this.btnURLConfirm.UseVisualStyleBackColor = true;
            this.btnURLConfirm.Click += new System.EventHandler(this.btnURLConfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(56, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "input the URL of the novel index page";
            // 
            // tbxURL
            // 
            this.tbxURL.Location = new System.Drawing.Point(47, 18);
            this.tbxURL.Name = "tbxURL";
            this.tbxURL.Size = new System.Drawing.Size(244, 25);
            this.tbxURL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // tpDataBase
            // 
            this.tpDataBase.Controls.Add(this.btnDelete);
            this.tpDataBase.Controls.Add(this.btnNovelNameConfirm);
            this.tpDataBase.Controls.Add(this.tbxNovelName);
            this.tpDataBase.Controls.Add(this.label3);
            this.tpDataBase.Location = new System.Drawing.Point(4, 25);
            this.tpDataBase.Name = "tpDataBase";
            this.tpDataBase.Padding = new System.Windows.Forms.Padding(3);
            this.tpDataBase.Size = new System.Drawing.Size(311, 397);
            this.tpDataBase.TabIndex = 1;
            this.tpDataBase.Text = "DataBase";
            this.tpDataBase.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(102, 364);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNovelNameConfirm
            // 
            this.btnNovelNameConfirm.Location = new System.Drawing.Point(102, 61);
            this.btnNovelNameConfirm.Name = "btnNovelNameConfirm";
            this.btnNovelNameConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnNovelNameConfirm.TabIndex = 4;
            this.btnNovelNameConfirm.Text = "Confirm";
            this.btnNovelNameConfirm.UseVisualStyleBackColor = true;
            this.btnNovelNameConfirm.Click += new System.EventHandler(this.btnNovelNameConfirm_Click);
            // 
            // tbxNovelName
            // 
            this.tbxNovelName.Location = new System.Drawing.Point(90, 14);
            this.tbxNovelName.Name = "tbxNovelName";
            this.tbxNovelName.Size = new System.Drawing.Size(194, 25);
            this.tbxNovelName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Novel Name";
            // 
            // tbxLog
            // 
            this.tbxLog.Location = new System.Drawing.Point(348, 37);
            this.tbxLog.Multiline = true;
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.ReadOnly = true;
            this.tbxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxLog.Size = new System.Drawing.Size(528, 346);
            this.tbxLog.TabIndex = 1;
            this.tbxLog.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxLog_KeyDown);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(681, 401);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(114, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(405, 401);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(114, 23);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblMaxPage
            // 
            this.lblMaxPage.AutoSize = true;
            this.lblMaxPage.Location = new System.Drawing.Point(609, 408);
            this.lblMaxPage.Name = "lblMaxPage";
            this.lblMaxPage.Size = new System.Drawing.Size(33, 15);
            this.lblMaxPage.TabIndex = 4;
            this.lblMaxPage.Text = "page";
            // 
            // tbxPage
            // 
            this.tbxPage.Location = new System.Drawing.Point(550, 402);
            this.tbxPage.Name = "tbxPage";
            this.tbxPage.Size = new System.Drawing.Size(53, 25);
            this.tbxPage.TabIndex = 5;
            this.tbxPage.TextChanged += new System.EventHandler(this.tbxPage_TextChanged);
            // 
            // lblChapterName
            // 
            this.lblChapterName.AutoSize = true;
            this.lblChapterName.Location = new System.Drawing.Point(345, 12);
            this.lblChapterName.Name = "lblChapterName";
            this.lblChapterName.Size = new System.Drawing.Size(88, 15);
            this.lblChapterName.TabIndex = 6;
            this.lblChapterName.Text = "Chapter Name";
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.lblChapterName);
            this.Controls.Add(this.tbxPage);
            this.Controls.Add(this.lblMaxPage);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tbxLog);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmBase";
            this.Text = "CZBookCrawler By Rockefeller 2020";
            this.Load += new System.EventHandler(this.frmBase_Load);
            this.SizeChanged += new System.EventHandler(this.frmBase_SizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.tpCrawler.ResumeLayout(false);
            this.tpCrawler.PerformLayout();
            this.tpDataBase.ResumeLayout(false);
            this.tpDataBase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCrawler;
        private System.Windows.Forms.Button btnExportAsText;
        private System.Windows.Forms.Button btnSaveToDataBase;
        private System.Windows.Forms.Label lblNovelName;
        private System.Windows.Forms.Button btnURLConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpDataBase;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNovelNameConfirm;
        private System.Windows.Forms.TextBox tbxNovelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxLog;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox tbxDelay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaxPage;
        private System.Windows.Forms.TextBox tbxPage;
        private System.Windows.Forms.Label lblChapterName;
    }
}

