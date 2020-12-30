using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PenguinCardGenerator
{
    public partial class PNGConfig : Form
    {
        public PNGConfig()
        {
            InitializeComponent();
        }


        public static bool is600x600Image(string patch)
        {
            System.Drawing.Image image = System.Drawing.Image.FromFile(patch);
            return (image.Width == 600) && (image.Height == 600); 
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Settings.Default.downloadMethod);
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.Text = "PNGs resource Configuration";

            localPatchtxt.Text = Properties.Settings.Default.local600Location;

            switch (Properties.Settings.Default.downloadMethod)
            {
                case "local":
                    localRB.Checked = true;
                    break;
                case "http":
                    HTTPRB.Checked = true;
                    break;
                case "ftp":
                    FTPRB.Checked = true;
                    break;
                case "sftp":
                    SFTPRB.Checked = true;
                    break;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void localRB_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.downloadMethod = "local";
            Properties.Settings.Default.Save();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.downloadMethod = "http";
            Properties.Settings.Default.Save();


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.downloadMethod = "ftp";
            Properties.Settings.Default.Save();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.downloadMethod = "sftp";
            Properties.Settings.Default.Save();

        }

        private void localSearchFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog patchSelector = new FolderBrowserDialog();
            patchSelector.Description = "Select the paper/600 folder of png paper items";
            
            string root = Properties.Settings.Default.local600Location;



            DialogResult result = patchSelector.ShowDialog();
            if(result == DialogResult.OK)
            {
                Properties.Settings.Default.local600Location = patchSelector.SelectedPath;
                localPatchtxt.Text = patchSelector.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }
    }
}
