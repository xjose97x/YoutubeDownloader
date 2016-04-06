namespace YoutubeDownloader
{
    partial class frmYTDownloader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYTDownloader));
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lblDecorateFolderBox = new System.Windows.Forms.Label();
            this.txtDownloadFolder = new System.Windows.Forms.TextBox();
            this.btnDownloadFolder = new System.Windows.Forms.Button();
            this.chkOpenAfterDownload = new System.Windows.Forms.CheckBox();
            this.lblDecorateURLBox = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.cboFileType = new System.Windows.Forms.ComboBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblDecorateCurrentFile = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblDecorateProgressBar = new System.Windows.Forms.Label();
            this.pgDownload = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(344, 28);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(147, 107);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // lblDecorateFolderBox
            // 
            this.lblDecorateFolderBox.AutoSize = true;
            this.lblDecorateFolderBox.Location = new System.Drawing.Point(17, 165);
            this.lblDecorateFolderBox.Name = "lblDecorateFolderBox";
            this.lblDecorateFolderBox.Size = new System.Drawing.Size(83, 13);
            this.lblDecorateFolderBox.TabIndex = 1;
            this.lblDecorateFolderBox.Text = "Download Path:";
            // 
            // txtDownloadFolder
            // 
            this.txtDownloadFolder.Location = new System.Drawing.Point(148, 165);
            this.txtDownloadFolder.Name = "txtDownloadFolder";
            this.txtDownloadFolder.Size = new System.Drawing.Size(454, 20);
            this.txtDownloadFolder.TabIndex = 2;
            // 
            // btnDownloadFolder
            // 
            this.btnDownloadFolder.Location = new System.Drawing.Point(609, 165);
            this.btnDownloadFolder.Name = "btnDownloadFolder";
            this.btnDownloadFolder.Size = new System.Drawing.Size(75, 23);
            this.btnDownloadFolder.TabIndex = 3;
            this.btnDownloadFolder.Text = "Choose";
            this.btnDownloadFolder.UseVisualStyleBackColor = true;
            this.btnDownloadFolder.Click += new System.EventHandler(this.btnDownloadFolder_Click);
            // 
            // chkOpenAfterDownload
            // 
            this.chkOpenAfterDownload.AutoSize = true;
            this.chkOpenAfterDownload.Location = new System.Drawing.Point(690, 165);
            this.chkOpenAfterDownload.Name = "chkOpenAfterDownload";
            this.chkOpenAfterDownload.Size = new System.Drawing.Size(128, 17);
            this.chkOpenAfterDownload.TabIndex = 4;
            this.chkOpenAfterDownload.Text = "Open After Download";
            this.chkOpenAfterDownload.UseVisualStyleBackColor = true;
            this.chkOpenAfterDownload.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblDecorateURLBox
            // 
            this.lblDecorateURLBox.AutoSize = true;
            this.lblDecorateURLBox.Location = new System.Drawing.Point(17, 197);
            this.lblDecorateURLBox.Name = "lblDecorateURLBox";
            this.lblDecorateURLBox.Size = new System.Drawing.Size(75, 13);
            this.lblDecorateURLBox.TabIndex = 5;
            this.lblDecorateURLBox.Text = "Youtube URL:";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(148, 197);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(454, 20);
            this.txtLink.TabIndex = 6;
            // 
            // cboFileType
            // 
            this.cboFileType.FormattingEnabled = true;
            this.cboFileType.Items.AddRange(new object[] {
            "Video",
            "MP3"});
            this.cboFileType.Location = new System.Drawing.Point(609, 197);
            this.cboFileType.Name = "cboFileType";
            this.cboFileType.Size = new System.Drawing.Size(74, 21);
            this.cboFileType.TabIndex = 7;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(690, 197);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 8;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblDecorateCurrentFile
            // 
            this.lblDecorateCurrentFile.AutoSize = true;
            this.lblDecorateCurrentFile.Location = new System.Drawing.Point(17, 237);
            this.lblDecorateCurrentFile.Name = "lblDecorateCurrentFile";
            this.lblDecorateCurrentFile.Size = new System.Drawing.Size(91, 13);
            this.lblDecorateCurrentFile.TabIndex = 9;
            this.lblDecorateCurrentFile.Text = "File Downloading:";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(148, 237);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(35, 13);
            this.lblFileName.TabIndex = 10;
            this.lblFileName.Text = "label1";
            // 
            // lblDecorateProgressBar
            // 
            this.lblDecorateProgressBar.AutoSize = true;
            this.lblDecorateProgressBar.Location = new System.Drawing.Point(17, 259);
            this.lblDecorateProgressBar.Name = "lblDecorateProgressBar";
            this.lblDecorateProgressBar.Size = new System.Drawing.Size(102, 13);
            this.lblDecorateProgressBar.TabIndex = 11;
            this.lblDecorateProgressBar.Text = "Download Progress:";
            // 
            // pgDownload
            // 
            this.pgDownload.Location = new System.Drawing.Point(148, 259);
            this.pgDownload.Name = "pgDownload";
            this.pgDownload.Size = new System.Drawing.Size(454, 23);
            this.pgDownload.TabIndex = 12;
            // 
            // frmYTDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 311);
            this.Controls.Add(this.pgDownload);
            this.Controls.Add(this.lblDecorateProgressBar);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblDecorateCurrentFile);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.cboFileType);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.lblDecorateURLBox);
            this.Controls.Add(this.chkOpenAfterDownload);
            this.Controls.Add(this.btnDownloadFolder);
            this.Controls.Add(this.txtDownloadFolder);
            this.Controls.Add(this.lblDecorateFolderBox);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmYTDownloader";
            this.Text = "Youtube Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblDecorateFolderBox;
        private System.Windows.Forms.TextBox txtDownloadFolder;
        private System.Windows.Forms.Button btnDownloadFolder;
        private System.Windows.Forms.CheckBox chkOpenAfterDownload;
        private System.Windows.Forms.Label lblDecorateURLBox;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.ComboBox cboFileType;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblDecorateCurrentFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblDecorateProgressBar;
        private System.Windows.Forms.ProgressBar pgDownload;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

