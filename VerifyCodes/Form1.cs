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
        //滤镜名称，参数

        /*
        1、尺寸缩放——宽高
        2、比例缩放——百分，百分
        3、裁剪图像——上下左右
        4、去除边框——上下左右
        5、图像滤波——3*3中值 5*5中值 均值 极值 去除细线条
        6、线性滤镜——浮雕、柔化、高斯、锐化、边缘、曝光、轮廓、霓虹、扩散、均衡
        7、清除背景——颜色>=<某值 亮度><=某值
        8、按亮度分离——保留几个亮度
        9、按颜色分离——保留几个颜色
        10、颜色处理——灰度、反转、单红、单绿、单蓝
        11、转黑白图——所有非白变黑
        12、指定阀值——阀值
        13、中值差值——差值
        14、自动阀值
        15、黑白图处理——骨架、腐蚀、膨胀、开、闭、缩水、去除毛刺、去除杂点、去除白边、断开水平线条[线条宽]
        16、修改亮度
        17、修改对比度
        */


        private void methods(string method,string[] param)
        {
            if (string.IsNullOrEmpty (method))
            {
                return;
            }
            method = method.Trim();
            switch (method)
            {
                case "尺寸缩放":
                    if (param.Length != 2)
                        return;
                    //此处尺寸缩放
                    break;
                case "比例缩放":
                    if (param.Length != 2)
                        return;
                    //此处比例缩放
                    break;
                case "去除边框":
                    if (param.Length != 4)
                        return;
                    int cb_up = int.Parse(param[0]);
                    int cb_left = int.Parse(param[1]);
                    int cb_right = int.Parse(param[2]);
                    int cb_down = int.Parse(param[3]);
                    prebmp = VerifyTools.ClearBlock(prebmp, cb_left, cb_right, cb_up, cb_down);
                    break;
                case "裁剪图像":
                    if (param.Length != 4)
                        return;
                    int cutb_up = int.Parse(param[0]);
                    int cutb_uleft = int.Parse(param[1]);
                    int cutb_uright = int.Parse(param[2]);
                    int cutb_udown = int.Parse(param[3]);
                    int cutb_he = prebmp.Height - cutb_udown - cutb_up;
                    int cutb_wid = prebmp.Width - cutb_uright - cutb_uleft;
                    Rectangle cutb_rect = new Rectangle(cutb_uleft, cutb_up, cutb_wid, cutb_he);
                    prebmp = VerifyTools.getRectBmp(prebmp, cutb_rect);
                    break;
                case "图像滤波":
                    if (param.Length < 1)
                    {
                        return;
                    }
                    switch (param[0])
                    {
                        //5、图像滤波——3*3中值 5*5中值 均值 极值 去除细线条
                        case "中值滤波3*3":
                            prebmp = VerifyTools.getLBbmp(prebmp, 3, 1);
                            break;
                        case "中值滤波5*5":
                            prebmp = VerifyTools.getLBbmp(prebmp, 5, 1);
                            break;
                        case "中值滤波7*7":
                            prebmp = VerifyTools.getLBbmp(prebmp, 7, 1);
                            break;
                        case "均值滤波3*3":
                            prebmp = VerifyTools.getLBbmp(prebmp, 3, 2);
                            break;
                        case "均值滤波3*5":
                            prebmp = VerifyTools.getLBbmp(prebmp, 5, 2);
                            break;
                        case "均值滤波3*7":
                            prebmp = VerifyTools.getLBbmp(prebmp, 7, 2);
                            break;
                    }
                    break;
                case "线性滤镜":
                    if (param.Length < 1)
                    {
                        return;
                    }
                    switch (param[0])
                    {
                        // 6、线性滤镜——浮雕、柔化、高斯、锐化、边缘、曝光、轮廓、霓虹、扩散、均衡
                        case "霓虹":
                            prebmp = VerifyTools.neonPic(prebmp);
                            break;
                        case "锐化":
                            prebmp = VerifyTools.neonPic(prebmp);
                            break;
                        case "柔化":
                            prebmp = VerifyTools.neonPic(prebmp);
                            break;
                        case "浮雕":
                            prebmp = VerifyTools.neonPic(prebmp);
                            break;
                        case "高斯":
                            prebmp = VerifyTools.neonPic(prebmp);
                            break;

                        case "边缘":
                            prebmp = VerifyTools.neonPic(prebmp);
                            break;
                        case "曝光":
                            prebmp = VerifyTools.neonPic(prebmp);
                            break;
                    }
                    break;
                case "清除背景":
                    if (param.Length < 3)
                    {
                        return;
                    }
                    int clblack_value = int.Parse(param [2]);
                    // 7、清除背景——颜色>=<某值 亮度><=某值
                    if ("颜色".Equals (param[0]))
                    {
                        if ("=".Equals (param[1]))
                        {

                        }else if (">".Equals(param[1]))
                        {

                        }
                        else if ("<".Equals(param[1]))
                        {

                        }
                    }
                    else if ("亮度".Equals(param[0]))
                    {
                        if ("=".Equals(param[1]))
                        {

                        }
                        else if (">".Equals(param[1]))
                        {

                        }
                        else if ("<".Equals(param[1]))
                        {

                        }
                    }
                    break;
                case "按亮度分离":
                    if (param.Length < 1)
                    {
                        return;
                    }
                    //      8、按亮度分离——保留几个亮度
                    int staty_lnum = int.Parse(param [0]);
                    
                    break;
                case "按颜色分离":
                    if (param.Length < 1)
                    {
                        return;
                    }
                    // 9、按颜色分离——保留几个颜色
                    int staty_cnum = int.Parse(param[0]);
                    break;
                case "颜色处理":
                    if (param.Length < 1)
                    {
                        return;
                    }
                    // 10、颜色处理——灰度、反转、单红、单绿、单蓝
                    switch (param[0])
                    {
                        case "灰度":
                            prebmp = VerifyTools.GrayByPixels(prebmp );
                            break;
                        case "反转":
                            prebmp = VerifyTools.reversal(prebmp );
                            break;
                        case "单色红":
                            prebmp = VerifyTools.getClrBmp(prebmp,1);
                            break;
                        case "单色绿":
                            prebmp = VerifyTools.getClrBmp(prebmp,2);
                            break;
                        case "单色蓝":
                            prebmp = VerifyTools.getClrBmp(prebmp,3);
                            break;
                    }
                    break;
                case "转黑白图":
                    if (param.Length < 1)
                    {
                        return;
                    }
                    prebmp = VerifyTools.getBlackPic(prebmp );
                    break;
                case "指定阀值":
                    if (param.Length < 1)
                    {
                        return;
                    }
                    int threshold_value = int.Parse(param [0]);
                    prebmp = VerifyTools.ConvertTo1Bpp(prebmp ,threshold_value );
                    break;
                case "中值差值":
                    if (param.Length < 1)
                    {
                        return;
                    }
                    int threshold_dvalue = int.Parse(param [0]);
                    threshold_dvalue += VerifyTools.GetDgGrayValue(prebmp );
                    prebmp = VerifyTools.ConvertTo1Bpp(prebmp, threshold_dvalue);
                    break;
                case "自动阀值":
                    if (param.Length < 1)
                    {
                        return;
                    }
                    prebmp = VerifyTools.ConvertTo1Bpp(prebmp);
                    break;
                case "黑白图处理":
                    if (param.Length < 1)
                    {
                        return;
                    }
                    //15、黑白图处理——骨架、腐蚀、膨胀、开、闭、缩水、去除毛刺、去除杂点、去除白边、断开水平线条[线条宽]
                    switch (param[0])
                    {
                        case "骨架":
                            prebmp = VerifyTools.Thinbmp(prebmp );
                            break;
                        case "腐蚀":
                            prebmp = VerifyTools.getErosin(prebmp );
                            break;
                        case "膨胀":
                            prebmp = VerifyTools.getSwell(prebmp );
                            break;
                        case "开运算":
                            prebmp = VerifyTools.getOpen(prebmp );
                            break;
                        case "闭运算":
                            prebmp = VerifyTools.getClose (prebmp);
                            break;
                        case "去除白边":
                            prebmp = VerifyTools.ClearEdge(prebmp);
                            break;
                        case "去除杂点":
                            prebmp = VerifyTools.ClearNoise(prebmp ,1,1);
                            break;
                    }

                    break;
                case "修改亮度":
                    if (param.Length < 1)
                    {
                        return;
                    }
                    break;
                case "修改对比度":
                    if (param.Length < 1)
                    {
                        return;
                    }
                    break;
            }
        }




        //public VerifyCode vfcode = null;
        string[]files = null;
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
            refreshBmpByList();
            //prebmp = VerifyTools.ClearBlock(prebmp ,1,1,1,1);
            //showbmp = VerifyTools.getBig(prebmp,ref mul); 
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
        double[] m1 = null;
        double[] m2 = null;
        private void button15_Click(object sender, EventArgs e)
        {
             m1 = VerifyTools.HuMoment(prebmp );

            for (int i = 0; i < m1.Length ; i++)
            {
                Console.WriteLine(m1[i]);
            }
            m2 = VerifyTools.HuMoment(prebmp);
            for (int i = 0; i < m2.Length; i++)
            {
                Console.WriteLine(m2[i]);
            }
            double xx = VerifyTools.getDbR(m2,m1);

           // int index = int.Parse(txtBox_fillIndex .Text .Trim ());
           //  VerifyTools.getFillbmp(prebmp ,8,1,true ,index );
           //// prebmp = VerifyTools.getFill (prebmp);
           // showbmp = VerifyTools.getBig(prebmp, ref mul);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            VerifyTools.getClearLine(prebmp );
            showbmp = VerifyTools.getBig(prebmp, ref mul);
        }




        /// <summary>
        /// 右键添加菜单添加指定项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolSMItem = (ToolStripMenuItem)sender;
            string method = toolSMItem.Text.Trim ();
            ListViewItem lvi = new ListViewItem();
            lvi.Tag = method;
            string str_params = "";
            switch (method)
            {
                case "图像缩放":
                    method = "尺寸缩放";
                    str_params = "100 100";
                    break;
                case "图像裁剪":
                    method = "裁剪图像";
                    str_params = "0 0 0 0";
                    break;
                case "图像滤波":
                    method = "图像滤波";
                    str_params = "中值滤波3*3";
                    break;
                case "线性滤镜":
                    method = "线性滤镜";
                    str_params = "霓虹";
                    break;
                case "清除背景":
                    method = "清除背景";
                    str_params = "颜色 = 1";
                    break;
                case "像素分离":
                    method = "按亮度分离";
                    str_params = "5";
                    break;
                case "颜色处理":
                    method = "颜色处理";
                    str_params = "灰度";
                    break;
                case "二值化":
                    method = "转黑白图";
                    str_params = "真";
                    break;
                case "黑白图处理":
                    method = "黑白图处理";
                    str_params = "去除杂点";
                    break;
                case "亮度对比度":
                    method = "修改亮度";
                    str_params = "3";
                    break;

            }
          
            lvi.SubItems.Add(method );
            lvi.SubItems.Add(str_params );
            lvi.Checked = false ;
            listView1.Items.Add(lvi );
            lvi.Selected = true;

        }

        /// <summary>
        /// 显示指定panel
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="method"></param>
        /// <param name="str_p"></param>
        /// <param name="paneltag"></param>
        /// <returns></returns>
        private Panel setPanelLoc(string tag,string method,string str_p,int paneltag)
        {
            panel_Binary.Visible = false;
            panel_Clip.Visible = false;
            panel_clrpro.Visible = false ;
            panel_filter.Visible = false;
            panel_ngt.Visible = false;
            panel_smoothing.Visible = false;

            Panel panelre = null;
            string[] param = str_p.Split(' ').Where((o) => { return !string.IsNullOrEmpty(o); }).ToArray ();
            if (param.Length == 0)
                return null;
            switch (tag )
            {
                case "图像缩放":

                    break;
                case "图像裁剪":
                    panelre  = panel_Clip;
                    if (method == "裁剪图像")
                        rB_Clip_Cut.Checked = true;
                    else if (method == "去除边框")
                        rB_Clip_clrBlock.Checked = true;
                    txtBox_Clip_up.Text = param[0];
                    txtBox_Clip_left .Text = param[1];
                    txtBox_Clip_right .Text = param[2];
                    txtBox_Clip_down .Text = param[3];
                    break;
                case "图像滤波":
                    panelre = panel_smoothing;
                    switch (param[0])
                    {
                        //5、图像滤波——3*3中值 5*5中值 均值 极值 去除细线条
                        case "中值滤波3*3":
                            rB_sm_mid3.Checked = true;
                            break;
                        case "中值滤波5*5":
                            rB_sm_mid5.Checked  = true;
                            break;
                        case "中值滤波7*7":
                            rB_sm_mid7.Checked = true;
                            break;
                        case "均值滤波3*3":
                            rB_sm_ave3.Checked = true;
                            break;
                        case "均值滤波3*5":
                            rB_sm_ave5.Checked = true;
                            break;
                        case "均值滤波3*7":
                            rB_sm_ave7.Checked = true;
                            break;
                    }
                    break;
                case "线性滤镜":
                    panelre = panel_filter;
                    switch (param[0])
                    {
                        // 6、线性滤镜——浮雕、柔化、高斯、锐化、边缘、曝光、轮廓、霓虹、扩散、均衡
                        case "霓虹":
                            rB_filter_neno.Checked = true;
                            break;
                        case "锐化":
                            rB_filter_sharpen .Checked = true;
                            break;
                        case "柔化":
                            rB_filter_soften .Checked = true;
                            break;
                        case "浮雕":
                            rB_filter_Embosment .Checked = true;
                            break;
                        case "高斯":
                            rB_filter_neno.Checked = true;
                            break;

                        case "边缘":
                            rB_filter_neno.Checked = true;
                            break;
                        case "曝光":
                            rB_filter_neno.Checked = true;
                            break;
                    }
                    break;
                case "清除背景":
                    panelre = panel_clrpro;
                    if ("颜色".Equals(param[0]))
                    {
                        if ("=".Equals(param[1]))
                        {

                        }
                        else if (">".Equals(param[1]))
                        {

                        }
                        else if ("<".Equals(param[1]))
                        {

                        }
                    }
                    else if ("亮度".Equals(param[0]))
                    {
                        if ("=".Equals(param[1]))
                        {

                        }
                        else if (">".Equals(param[1]))
                        {

                        }
                        else if ("<".Equals(param[1]))
                        {

                        }
                    }
                    break;
                case "像素分离":
                    panelre = panel_Clip;
                    if (method == "按亮度分离")
                    {

                    }
                    else if (method == "按颜色分离")
                    {

                    }
                    break;
                case "颜色处理":
                    panelre = panel_clrpro;
                    switch (param[0])
                    {
                        case "灰度":
                            rB_clrpro_gray.Checked = true;
                            break;
                        case "反转":
                            rB_clrpro_reversal .Checked = true;
                            break;
                        case "单色红":
                            rB_clrpro_red.Checked = true;
                            break;
                        case "单色绿":
                            rB_clrpro_green.Checked = true;
                            break;
                        case "单色蓝":
                            rB_clrpro_blue.Checked = true;
                            break;
                    }
                    break;
                case "二值化":
                    panelre = panel_Binary;
                    if (method == "转黑白图")
                    {
                        rB__Binary_allBlack.Checked = true;

                    }else if (method == "指定阀值")
                    {
                        rB__Binary_threshold .Checked = true;
                    }
                    else if (method == "中值差值")
                    {
                        rB__Binary_autoSub .Checked = true;
                    }
                    else if (method == "自动阀值")
                    {
                        rB__Binary_自动阀值.Checked = true;
                    }
                    break;
                case "黑白图处理":
                    panelre = panel_ngt;
                    switch (param[0])
                    {
                        case "骨架":
                            rB_ngt_thin.Checked = true;
                            break;
                        case "腐蚀":
                            rB_ngt_erosion .Checked = true;
                            break;
                        case "膨胀":
                            rB_ngt_swell.Checked = true;
                            break;
                        case "开运算":
                            rB_ngt_open .Checked = true;
                            break;
                        case "闭运算":
                            rB_ngt_close .Checked = true;
                            break;
                        case "去除白边":
                            rB_ngt_CEdge .Checked = true;
                            break;
                        case "去除杂点":
                            rB_ngt_cNoise.Checked = true;
                            break;
                    }
                    break;
                case "亮度对比度":
                    panelre = panel_Binary;
                    if (method == "修改亮度")
                    {
                        
                    }
                    else if (method == "修改对比度")
                    {

                    }
                    break;
            }
            if (panelre != null)
            {
                panelre.Visible = true;
                panelre.Location = new Point(400, 400);
                panelre.Tag = paneltag;
            }
            return panelre;
        }

        /// <summary>
        /// 列表选项改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCount = listView1.SelectedItems.Count;
            if (selectedCount != 1)
            {
                return;
            }
             ListViewItem lvi = listView1.SelectedItems[0];
            string method = lvi.SubItems[1].Text;
            string str_params = lvi.SubItems[2].Text;
            string str_tag = lvi.Tag.ToString ();
            int index = listView1.SelectedItems[0].Index;
            setPanelLoc(str_tag ,method ,str_params ,index );
            
        }

        private void refreshBmpByList()
        {
            prebmp = (Bitmap)srcbmp.Clone();
            for (int i = 0; i < listView1 .Items.Count ; i++)
            {
                ListViewItem lvi = listView1.Items[i];
                if (lvi.Checked)
                {
                    string method = lvi.SubItems[1].Text;
                    string str_params = lvi.SubItems[2].Text;
                    string str_tag = lvi.Tag.ToString();
                    string[] pa = str_params.Split(' ').Where((o) => { return !string.IsNullOrEmpty(o); }).ToArray();
                    methods(method, pa);
                    
                }
            }
            showbmp = VerifyTools.getBig(prebmp , ref mul);

        }

    }
    enum methods 
    {
        尺寸缩放,
        比例缩放,
        去除边框,
        裁剪图像,
        图像滤波,
        线性滤镜,
        清除背景,
        按亮度分离,
        按颜色分离,
        颜色处理,
        转黑白图,
        指定阀值,
        中值差值,
        自动阀值,
        黑白图处理,
        修改亮度,
        修改对比度
    }

}
