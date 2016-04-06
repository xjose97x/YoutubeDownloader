using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;

namespace YoutubeDownloader
{
    public partial class frmYTDownloader : Form
    {
        public frmYTDownloader()
        {
            InitializeComponent();
            //Set video as default choice.  0 = Video, 1 = MP3.
            cboFileType.SelectedIndex = 0;
            //Gets path to 'my documents' and sets path the path of the browser dialog.
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            folderBrowserDialog1.SelectedPath = folder;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDownloadFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                txtDownloadFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Tuple<bool, string> isLinkGood = ValidateLink();
            if(isLinkGood.Item1)
            {
                RestrictAccessibility();
                System.Threading.Thread.Sleep(2000);
                EnableAccessibility();
                MessageBox.Show("Is it a good link?" + isLinkGood.Item1 + "Link is: " + isLinkGood.Item2);
            }
        }

        private void EnableAccessibility()
        {
            lblFileName.Text = "";
            txtLink.Text = "";
            btnDownload.Enabled = true;
            cboFileType.Enabled = true;
            btnDownloadFolder.Enabled = true;
            txtDownloadFolder.Enabled = true;
            txtLink.Enabled = true;
            pgDownload.Value = 0;
        }

        private void RestrictAccessibility()
        {
            btnDownload.Enabled = false;
            cboFileType.Enabled = false;
            btnDownloadFolder.Enabled = false;
            txtDownloadFolder.Enabled = false;
            txtLink.Enabled = false;
        }

        private Tuple<bool, string> ValidateLink()
        {
            string normalURL;
            if (!Directory.Exists(txtDownloadFolder.Text))  
            {
                MessageBox.Show("Please enter a valid folder.");
                return Tuple.Create(false, "");
            }
            else if (DownloadUrlResolver.TryNormalizeYoutubeUrl(txtLink.Text, out normalURL))
            {
                return Tuple.Create(true, normalURL);
            }
            else
            {
                MessageBox.Show("Please enter a valid link.");
                return Tuple.Create(false, "");
            }
        }
    }
}
