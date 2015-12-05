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

namespace VerifyCodes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //public VerifyCode vfcode = null;
        string []files = null;
        int fileIndex = -1;
        Bitmap prebmp = null;
        Bitmap srcbmp = null;
        Bitmap workbmp = null;
        Bitmap showbmp = null;
        //bool isworkbmp = false;

        private void btn_downloadPic_Click(object sender, EventArgs e)
        {

            fileIndex++;
            if (files == null)
            {
                loadfiles();
                fileIndex = 0;
            }
            if (fileIndex>=files .Length)
            {
                fileIndex = 0;
            }
            using (FileStream fs = new FileStream(files [fileIndex],FileMode.Open ))
            {
                //byte[] bytes = new byte[fs.Length ];
                //fs.Read(bytes ,0,bytes.Length );
                Bitmap img = (Bitmap )Bitmap.FromStream(fs );
                Bitmap imgd = new Bitmap(img );
                img.Dispose();
                prebmp = (Bitmap)imgd.Clone();
                srcbmp = (Bitmap)imgd.Clone();
                this.Text = prebmp.Width + " w * h " + prebmp.Height;
                //vfcode = new VerifyCode(prebmp );
            }
            
            
            mul = 2;
            picBox_src.Image = VerifyTools.getBig(srcbmp ,ref mul ,false );
            mul = -1;
            showbmp  = VerifyTools.getBig(prebmp, ref mul);
            picBox_show.Image = showbmp;
        }

        int mul = -1;
        private void loadfiles()
        {
            if (txtBox_url.Text != "" && Directory.Exists(txtBox_url.Text.Trim()))
            {
                files = null;
                files = Directory.GetFiles(txtBox_url.Text.Trim());
                fileIndex = -1;
            }
        }
        private void btn_serchPath_Click(object sender, EventArgs e)
        {
            loadfiles();
        }

        private void picBox_show_Paint(object sender, PaintEventArgs e)
        {
            if(showbmp!=null)
            {
                picBox_show.Image = showbmp;
            }
            //if (vfcode != null)
             //  picBox_show.Image = vfcode.UserBmpShow; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prebmp = VerifyTools.GrayByPixels(prebmp );
            showbmp = VerifyTools.getBig(prebmp,ref mul); 
            //picBox_show.Image = prebmp;

            //vfcode.GrayByPixels();

            return;
            string order = textBox1.Text.Trim();
            if(string.IsNullOrEmpty (order))
            {
                return;
            }
           
        }
         
        private void button2_Click(object sender, EventArgs e)
        {
            prebmp = VerifyTools.ClearBlock(prebmp ,1,1,1,1);
            showbmp = VerifyTools.getBig(prebmp,ref mul); 
            // picBox_show.Image = prebmp;
            //vfcode.ClearBlock(1,1,1,1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prebmp = VerifyTools.ClearEdge(prebmp,VerifyTools .GetDgGrayValue (prebmp ));
            showbmp = VerifyTools.getBig(prebmp,ref mul); 
           // picBox_show.Image = prebmp;
            // vfcode.ClearEdge(vfcode .GetDgGrayValue ());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = -1;
            int b = 1;
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                int.TryParse(textBox2.Text.Trim(), out a);
            }
            else
            {
                a = VerifyTools.GetDgGrayValue(prebmp );
               // a = vfcode.GetDgGrayValue();
            }
            if(!string.IsNullOrEmpty (textBox3.Text .Trim ()))
            { 
                int.TryParse(textBox3 .Text .Trim (),out b );
               
            }
            prebmp = VerifyTools.ClearNoise(prebmp,a,b );
            showbmp = VerifyTools.getBig(prebmp,ref mul);

            
            //vfcode.ClearNoise(a, b);
            textBox2.Text = a.ToString();
            textBox3.Text = b.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            prebmp = VerifyTools.ConvertTo1Bpp(prebmp,VerifyTools .GetDgGrayValue (prebmp ));
            showbmp = VerifyTools.getBig(prebmp,ref mul);

            //vfcode.ConvertTo1Bpp(vfcode .GetDgGrayValue ());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rects = VerifyTools.getRegions(prebmp,8,1,true );
            showbmp = VerifyTools.getBig(prebmp,ref mul,true ,rects );
            // vfcode.drawRect = !vfcode .drawRect ;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            prebmp = VerifyTools.reversal(prebmp );
            showbmp = VerifyTools.getBig(prebmp,ref mul);
            //picBox_show.Image = VerifyTools.getBig(prebmp, -1, VerifyTools.getRegions(prebmp));

            // vfcode.reversal();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            prebmp = (Bitmap)srcbmp.Clone();
            showbmp = VerifyTools.getBig(prebmp,ref mul);
           // vfcode.reSet();
            ///vfcode.drawRect = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //vfcode.UserShowMul = int.Parse(textBox_fangda .Text.Trim());
        }
        Rectangle[] rects = null;


        private void button10_Click(object sender, EventArgs e)
        {
            if (workbmp != null)
            {
                prebmp = (Bitmap)workbmp.Clone();
                mul = -1;
                showbmp = VerifyTools.getBig(prebmp, ref mul);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string featurestr = VerifyTools.getFeatureCode(prebmp );
            MessageBox.Show(featurestr);
        }

        bool drawhand = false;
        Point drawhandstart = new Point ();
        private void picBox_show_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            int x = e.X / mul;
            int y = e.Y / mul;
            if (checkBox1 .Checked)
            {
                drawhand = true;
                drawhandstart = new Point (x,y );

            }
        }

        private void picBox_show_MouseUp(object sender, MouseEventArgs e)
        {
            int x = e.X / mul;
            int y = e.Y / mul;
            if (e.Button == MouseButtons.Right)
            {
                if (rects != null && rects.Length > 0 && rects[0].Width < prebmp.Width)
                {
                    workbmp = (Bitmap)prebmp.Clone();

                    for (int i = 0; i < rects.Length; i++)
                    {
                        if (x >= rects[i].X && y >= rects[i].Y && x <= (rects[i].X + rects[i].Width) && y <= (rects[i].Y + rects[i].Height))
                        {
                            prebmp = VerifyTools.getRectBmp(prebmp, rects[i]);
                            break;
                        }

                    }
                    mul = -1;
                    showbmp = VerifyTools.getBig(prebmp, ref mul);
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (drawhand && x != drawhandstart.X && y != drawhandstart.Y)
                {
                    //rects = null;
                    rects = new Rectangle[] { new Rectangle(drawhandstart.X, drawhandstart.Y, x - drawhandstart.X + 1, y - drawhandstart.Y + 1) };
                    showbmp = VerifyTools.getBig(prebmp, ref mul, true, rects);

                    checkBox1.Checked = false;
                    drawhand = false;
                }

                else
                {
                    Color c = prebmp.GetPixel(x, y);
                    prebmp.SetPixel(x, y, c.B == 255 ? Color.Black : Color.White);
                    showbmp = VerifyTools.getBig(prebmp, ref mul);
                }
            }
 
 
           
        }

        private void picBox_show_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X / mul;
            int y = e.Y / mul;
            if (drawhand && x != drawhandstart.X && y != drawhandstart.Y)
            {
                Rectangle[] rectstmp = new Rectangle[] { new Rectangle(drawhandstart.X, drawhandstart.Y, x - drawhandstart.X + 1, y - drawhandstart.Y + 1) };
                showbmp = VerifyTools.getBig(prebmp, ref mul, true, rectstmp);

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //int a = int.Parse(txtBox_lvbo .Text.Trim ());
           // showbmp = VerifyTools.getLBbmp(prebmp ,a ,1);
            //showbmp = VerifyTools.getBig(prebmp, ref mul, true, rectstmp);
           // showbmp = VerifyTools.getBig(showbmp, ref mul);
        }//

        private void button13_Click(object sender, EventArgs e)
        {
           // int a = int.Parse(txtBox_lvbo.Text.Trim());
            //showbmp = VerifyTools.getLBbmp(prebmp, a, 2);
            //showbmp = VerifyTools.getBig(showbmp, ref mul);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            prebmp = VerifyTools.getBlackPic (prebmp);
            showbmp = VerifyTools.getBig(prebmp, ref mul);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int index = int.Parse(txtBox_fillIndex .Text .Trim ());
             VerifyTools.getFillbmp(prebmp ,8,1,true ,index );
           // prebmp = VerifyTools.getFill (prebmp);
            showbmp = VerifyTools.getBig(prebmp, ref mul);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            VerifyTools.getClearLine(prebmp );
            showbmp = VerifyTools.getBig(prebmp, ref mul);
        }
    }
}
