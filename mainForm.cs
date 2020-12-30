using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;





namespace PenguinCardGenerator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }




     
        public static string colorToID(string colorID)
        {

            switch (colorID)
            {
                case "Blue":
                    return "1";
                case "Green":
                    return "2";
                case "Pink":
                    return "3";
                case "Black":
                    return "4";
                case "Yellow":
                    return "7";
                case "Dark Purple":
                    return "8";
                case "Brown":
                    return "9";
                case "Peach":
                    return "10";
                case "Red":
                    return "5";
                case "Orange":
                    return "6";
                case "Dark Green":
                    return "11";
                case "Light Blue":
                    return "12";
                case "Lime Green":
                    return "13";
                case "Aqua":
                    return "15";
                case "Arctic White":
                    return "16";
                default:
                    return "1";
            }

          
        }


        public static string idToPatch(string id)
        {
            string localPatch = Properties.Settings.Default.local600Location;
            return localPatch + @"\" + id + ".png";


        }
        public static System.Drawing.Bitmap CombineBitmap(string[] files)
        {
            //read all images into memory
            List<System.Drawing.Bitmap> images = new List<System.Drawing.Bitmap>();
            System.Drawing.Bitmap finalImage = null;

            try
            {
                int width = 0;
                int height = 0;

                foreach (string image in files)
                {
                    if (!File.Exists(image))
                    {
                        continue;
                    }
                    //create a Bitmap from the  and add it to the list
                    System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(image);

                    //update the size of the final bitmap
                    width = 600;
                    height = 600;

                    images.Add(bitmap);
                }

                //create a bitmap to hold the combined image
                finalImage = new System.Drawing.Bitmap(width, height);

                //get a graphics object from the image so we can draw on it
                using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(finalImage))
                {
       

           
                    int offset = 0;
                    foreach (System.Drawing.Bitmap image in images)
                    {

                        int part = images.IndexOf(image);
                        g.DrawImage(image,
                          new System.Drawing.Rectangle(offset, 0, image.Width, image.Height));

                    
                    }
                }

                return finalImage;
            }
            catch (Exception)
            {
                if (finalImage != null)
                    finalImage.Dispose();
                throw;
            }
            finally
            {
       
                foreach (System.Drawing.Bitmap image in images)
                {
                    image.Dispose();
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            this.Text = "Club Penguin playercard generator";


        }

        private void button1_Click(object sender, EventArgs e)
        {



            string[] files = {
                idToPatch(colorToID(colorSelector.Text)),
                idToPatch(faceSelector.Value.ToString()),
                idToPatch(headSelector.Value.ToString()),
                idToPatch(bodySelector.Value.ToString()),
                idToPatch(neckSelector.Value.ToString()),
                idToPatch(handSelector.Value.ToString()),
                idToPatch(feetSelector.Value.ToString())
            };


       
            /*string[] files = { @"C:\CPPS\CPPS\WWW\media\avatar\paper\600\1.png", //color
                @"C:\CPPS\CPPS\WWW\media\avatar\paper\600\1029.png", //head
                @"C:\CPPS\CPPS\WWW\media\avatar\paper\600\101.png", //face
                @"C:\CPPS\CPPS\WWW\media\avatar\paper\600\204.png", //body
                @"C:\CPPS\CPPS\WWW\media\avatar\paper\600\172.png", //neck
                @"C:\CPPS\CPPS\WWW\media\avatar\paper\600\336.png", //hand
                @"C:\CPPS\CPPS\WWW\media\avatar\paper\600\357.png", //feet
            };
            */
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.BackgroundImage = CombineBitmap(files);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pNGsResourcesFromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PNGConfig pngLocationSettings = new PNGConfig();
            pngLocationSettings.ShowDialog(this);
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by https://github.com/hangardonelli/");
        }
    }
}
