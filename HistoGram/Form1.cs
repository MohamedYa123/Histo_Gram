using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoGram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //    FormBorderStyle = FormBorderStyle.Sizable;
            //    FormBorderStyle = FormBorderStyle.Fixed3D;
        }
        Bitmap fimg;
        private void button1_Click(object sender, EventArgs e)
        {
            //orimg = (Bitmap)pictureBox1.Image;
            fimg = EqualizeHistogram();
            pictureBox2.Image = fimg;
            
        }

        public unsafe Bitmap EqualizeHistogram()
        {
            var finalimg = new Bitmap(orimg.Width, orimg.Height);

            var rHistogram = GetHistogram(Rgb.R);
            var gHistogram = GetHistogram(Rgb.G);
            var bHistogram = GetHistogram(Rgb.B);

            var data = orimg.LockBits(new Rectangle(0, 0, orimg.Width, orimg.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            var finaldata=finalimg.LockBits(new Rectangle(0, 0, finalimg.Width, finalimg.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            var histR = new float[256];
            var histG = new float[256];
            var histB = new float[256];

            histR[0] = (rHistogram[0] * rHistogram.Length) / (finaldata.Width * finaldata.Height);
            histG[0] = (gHistogram[0] * gHistogram.Length) / (finaldata.Width * finaldata.Height);
            histB[0] = (bHistogram[0] * bHistogram.Length) / (finaldata.Width * finaldata.Height);

            long cumulativeR = rHistogram[0];
            long cumulativeG = gHistogram[0];
            long cumulativeb = bHistogram[0];

            for(var i = 1; i < histR.Length; i++)
            {
                cumulativeR += rHistogram[i];
                histR[i] = (cumulativeR * rHistogram.Length) / (finaldata.Width * finaldata.Height);

                cumulativeG += gHistogram[i];
                histG[i] = (cumulativeG * gHistogram.Length) / (finaldata.Width * finaldata.Height);

                cumulativeb += bHistogram[i];
                histB[i] = (cumulativeb * bHistogram.Length) / (finaldata.Width * finaldata.Height);

            }
            var ptr = (byte*)data.Scan0;
            var ptrfinal = (byte*)finaldata.Scan0;
            var remain = data.Stride - data.Width * 3;
            for (var i = 0; i < data.Height; i++, ptr += remain, ptrfinal += remain)
            {
                for (var j = 0; j < data.Width; j++, ptrfinal += 3, ptr += 3)
                {
                    var intensityR = ptr[2];
                    var intensityG = ptr[1];
                    var intensityB = ptr[0];

                    var nvalueR = (byte)histR[intensityR];
                    var nvalueG = (byte)histG[intensityG];
                    var nvalueB = (byte)histB[intensityB];

                    //if (histR[intensityR] < 255)
                    //    nvalueR = 255;
                    //if (histG[intensityG] < 255)
                    //    nvalueG = 255;
                    //if (histB[intensityB] < 255)
                    //    nvalueB = 255;
                    ptrfinal[2] = nvalueR;
                    ptrfinal[1] = nvalueG;
                    ptrfinal[0] = nvalueB;
                }
            }
            orimg.UnlockBits(data);
            finalimg.UnlockBits(finaldata);

            return finalimg;
        }






        Bitmap orimg;

        public enum Rgb {R,G,B}
        public unsafe int[] GetHistogram(Rgb component)
        {
            var histogram = new int[256];
            //lock (imagelo)
            //{

            //}
          
                var data = orimg.LockBits(new Rectangle(0, 0, orimg.Width, orimg.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                var offset = data.Stride - orimg.Width * 3;

                var p = (byte*)data.Scan0.ToPointer();
            for (var i = 0; i < orimg.Height; i++)
            {
                for(var j = 0; j < orimg.Width; j++, p += 3)
                {
                    switch(component)
                    {
                        case Rgb.R:
                            histogram[p[2]]++;
                            break;
                        case Rgb.G:
                            histogram[p[1]]++;
                            break;
                        case Rgb.B:
                            histogram[p[0]]++;
                            break;
                    }
                }
                p += offset;
            }
            orimg.UnlockBits(data);
            return histogram;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                orimg = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = orimg;
                pictureBox2.Image = (new PictureBox()).Image;
                pfButton1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pfButton3_Click(object sender, EventArgs e)
        {
            Bitmap h = (Bitmap)pictureBox2.Image;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                h.Save(saveFileDialog1.FileName+".png");
                MessageBox.Show("Image was Successfuly Saved", "info",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void pfButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by:Mohamed Yasser \n\nWhatsapp:+20129192515 \n\nSpecial Gift to:Noor Salim","About"
                ,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            //e.Effect = DragDropEffects.All;
            //openFileDialog1.FileName = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            //pfButton2.PerformClick();
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            //e.Effect = DragDropEffects.All;
        }
    }
}
