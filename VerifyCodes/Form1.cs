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
            tmb.name = "test";
            
        }

        /// <summary>
        /// 根据参数，对图片进行处理
        /// </summary>
        /// <param name="methodInt"></param>
        /// <param name="param"></param>
        private void methods(int methodInt, string[] param)
        {
            if (methodInt < 0)
            {
                return;
            }

            switch ((enumMethods)methodInt)
            {
                case enumMethods.尺寸缩放:
                    if (param.Length != 2)
                        return;
                    //此处尺寸缩放
                    int w = int .Parse(txtBox_resize_width .Text .Trim ());
                    int h = int.Parse(txtBox_resize_height.Text .Trim ());
                    prebmp = VerifyTools.getBmpResize(prebmp ,w,h,1,1,1);
                    break;
                case enumMethods.比例缩放:
                    if (param.Length != 2)
                        return;
                    //此处比例缩放
                    double dw = double.Parse(comb_resize_width .Text .Trim ());
                    double dh = double.Parse(comb_resize_height .Text .Trim ());
                    prebmp = VerifyTools.getBmpResize(prebmp, 1, 1, dw , dh , 2);
                    break;
                case enumMethods.去除边框:
                    if (param.Length != 4)
                        return;
                    int cb_up = int.Parse(param[0]);
                    int cb_left = int.Parse(param[1]);
                    int cb_right = int.Parse(param[2]);
                    int cb_down = int.Parse(param[3]);
                    prebmp = VerifyTools.ClearBlock(prebmp, cb_left, cb_right, cb_up, cb_down);
                    break;
                case enumMethods.裁剪图像:
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
                case enumMethods.图像滤波:
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
                        case "均值滤波5*5":
                            prebmp = VerifyTools.getLBbmp(prebmp, 5, 2);
                            break;
                        case "均值滤波7*7":
                            prebmp = VerifyTools.getLBbmp(prebmp, 7, 2);
                            break;
                    }
                    break;
                case enumMethods.线性滤镜:
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
                            prebmp = VerifyTools.SharpenImage(prebmp );
                            break;
                        case "柔化":
                            prebmp = VerifyTools.SoftenImage (prebmp);
                            break;

                        case "浮雕":
                            prebmp = VerifyTools.EmbossmentImage (prebmp);
                            break;

                        case "雾化":
                            prebmp = VerifyTools.AtomizationImage(prebmp );
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
                case enumMethods.清除背景:
                    if (param.Length < 3)
                    {
                        return;
                    }
                    int clblack_value = int.Parse(param[2]);
                    // 7、清除背景——颜色>=<某值 亮度><=某值
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
                case enumMethods.按亮度分离:
                    if (param.Length < 1)
                    {
                        return;
                    }
                    //      8、按亮度分离——保留几个亮度
                    int staty_lnum = int.Parse(param[0]);

                    break;
                case enumMethods.按颜色分离:
                    if (param.Length < 1)
                    {
                        return;
                    }
                    // 9、按颜色分离——保留几个颜色
                    int staty_cnum = int.Parse(param[0]);
                    break;
                case enumMethods.颜色处理:
                    if (param.Length < 1)
                    {
                        return;
                    }
                    // 10、颜色处理——灰度、反转、单红、单绿、单蓝
                    switch (param[0])
                    {
                        case "灰度":
                            prebmp = VerifyTools.GrayByPixels(prebmp);
                            break;
                        case "反转":
                            prebmp = VerifyTools.getAutoreversal (prebmp);
                            break;
                        case "单色红":
                            prebmp = VerifyTools.getClrBmp(prebmp, 1);
                            break;
                        case "单色绿":
                            prebmp = VerifyTools.getClrBmp(prebmp, 2);
                            break;
                        case "单色蓝":
                            prebmp = VerifyTools.getClrBmp(prebmp, 3);
                            break;
                    }
                    break;
                case enumMethods.转黑白图:
                    if (param.Length < 1)
                    {
                        return;
                    }
                    prebmp = VerifyTools.getBlackPic(prebmp);
                    break;
                case enumMethods.指定阀值:
                    if (param.Length < 1)
                    {
                        return;
                    }
                    int threshold_value = int.Parse(param[0]);
                    prebmp = VerifyTools.ConvertTo1Bpp(prebmp, threshold_value);
                    break;
                case enumMethods.中值差值:
                    if (param.Length < 1)
                    {
                        return;
                    }
                    int threshold_dvalue = int.Parse(param[0]);
                    threshold_dvalue += VerifyTools.GetDgGrayValue(prebmp);
                    prebmp = VerifyTools.ConvertTo1Bpp(prebmp, threshold_dvalue);
                    break;
                case enumMethods.自动阀值:
                    if (param.Length < 1)
                    {
                        return;
                    }
                    int dgv = VerifyTools.GetDgGrayValue(prebmp );
                    prebmp = VerifyTools.ConvertTo1Bpp(prebmp,dgv );
                    break;
                case enumMethods.黑白图处理:
                    if (param.Length < 1)
                    {
                        return;
                    }
                    //15、黑白图处理——骨架、腐蚀、膨胀、开、闭、缩水、去除毛刺、去除杂点、去除白边、断开水平线条[线条宽]
                    switch (param[0])
                    {
                        case "骨架":
                            prebmp = VerifyTools.Thinbmp(prebmp);
                            break;
                        case "腐蚀":
                            prebmp = VerifyTools.getErosin(prebmp);
                            break;
                        case "膨胀":
                            prebmp = VerifyTools.getSwell(prebmp);
                            break;
                        case "开运算":
                            prebmp = VerifyTools.getOpen(prebmp);
                            break;
                        case "闭运算":
                            prebmp = VerifyTools.getClose(prebmp);
                            break;
                        case "去除白边":
                            prebmp = VerifyTools.ClearEdge(prebmp);
                            break;
                        case "去除杂点":
                            if(param .Length <= 1||param [1]=="0")
                            {
                                prebmp = VerifyTools.ClearNoise(prebmp, VerifyTools .GetDgGrayValue (prebmp ), 2);
                            }
                            else if (param .Length ==2)
                            prebmp = VerifyTools.ClearNoise(prebmp, int.Parse (param [1]), 2);
                            break;
                    }

                    break;
                case enumMethods.修改亮度:
                    if (param.Length < 1)
                    {
                        return;
                    }
                    break;
                case enumMethods.修改对比度:
                    if (param.Length < 1)
                    {
                        return;
                    }
                    break;
                case enumMethods.特殊处理:
                    VerifyTools.getClearLine(prebmp);
                    break;
            }
        }

        string[] files = null;
        int fileIndex = -1;
        Bitmap prebmp = null;
        Bitmap srcbmp = null;
        Bitmap workbmp = null;
        Bitmap showbmp = null;


        /// <summary>
        ///切换图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NexPic_Click(object sender, EventArgs e)
        {

            fileIndex++;
            if (files == null)
            {
                loadfiles();
                fileIndex = 0;
            }
            if (fileIndex >= files.Length)
            {
                fileIndex = 0;
            }
            using (FileStream fs = new FileStream(files[fileIndex], FileMode.Open))
            {
                //byte[] bytes = new byte[fs.Length ];
                //fs.Read(bytes ,0,bytes.Length );
                Bitmap img = (Bitmap)Bitmap.FromStream(fs);
                Bitmap imgd = new Bitmap(img);
                img.Dispose();
                if(prebmp !=null)
                {
                    prebmp.Dispose();
                    prebmp = null;
                }
                if(srcbmp !=null)
                {
                    srcbmp.Dispose();
                    srcbmp = null;
                }


                prebmp = (Bitmap)imgd.Clone();
                srcbmp = (Bitmap)imgd.Clone();
                imgd.Dispose();
                imgd = null;
                this.Text = prebmp.Width + " w * h " + prebmp.Height;
                //vfcode = new VerifyCode(prebmp );
            }


            mul = -1;
            picBox_src.Image = VerifyTools.getBig(srcbmp, ref mul, 233, 80, false);
            mul = -1;
            //showbmp  = VerifyTools.getBig(prebmp, ref mul, 560, 250);

            picBox_src.Image = srcbmp;

            refreshBmpByList();
            this.Refresh();
        }

        /// <summary>
        /// 缩放比例
        /// </summary>
        int mul = -1;

        /// <summary>
        /// 载入文件夹内文件
        /// </summary>
        private void loadfiles()
        {
            if (txtBox_url.Text != "" && Directory.Exists(txtBox_url.Text.Trim()))
            {
                files = null;
                files = Directory.GetFiles(txtBox_url.Text.Trim());
                fileIndex = -1;
                tmb.url = txtBox_url.Text.Trim();
                tmb.dir = txtBox_url.Text.Trim();
            }
        }

        /// <summary>
        /// 载入文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_serchPath_Click(object sender, EventArgs e)
        {
            loadfiles();
        }

        private void picBox_show_Paint(object sender, PaintEventArgs e)
        {
            //if (showbmp != null)
            //{
            //    picBox_show.Image = showbmp;
            //    picBox_pre.Image = prebmp;
            //}
            //if (vfcode != null)
            //  picBox_show.Image = vfcode.UserBmpShow; 
        }


        /// <summary>
        /// 刷新显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            refreshBmpByList();
        }

        Rectangle[] rects = null;
        bool drawhand = false;
        Point drawhandstart = new Point();

        private void picBox_show_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            int x = e.X / mul;
            int y = e.Y / mul;
            if (checkBox_splitHand .Checked)
            {
                drawhand = true;
                drawhandstart = new Point(x, y);
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
                    showbmp = VerifyTools.getBig(prebmp, ref mul, 560, 250);
                    picBox_show.Image = showbmp;
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (drawhand && x != drawhandstart.X && y != drawhandstart.Y)
                {
                    //rects = null;
                    rects = new Rectangle[] { new Rectangle(drawhandstart.X, drawhandstart.Y, x - drawhandstart.X + 1, y - drawhandstart.Y + 1) };
                    showbmp = VerifyTools.getBig(prebmp, ref mul, 560, 250, true, rects);

                    checkBox_splitHand .Checked = false;
                    drawhand = false;
                }
                else
                {
                    Color c = prebmp.GetPixel(x, y);
                    prebmp.SetPixel(x, y, c.B == 255 ? Color.Black : Color.White);
                    showbmp = VerifyTools.getBig(prebmp, ref mul, 560, 250);
                }
                picBox_show.Image = showbmp;
            }
           
        }

        private void picBox_show_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X / mul;
            int y = e.Y / mul;
            if (drawhand && x != drawhandstart.X && y != drawhandstart.Y)
            {
                Rectangle[] rectstmp = new Rectangle[] { new Rectangle(drawhandstart.X, drawhandstart.Y, x - drawhandstart.X + 1, y - drawhandstart.Y + 1) };
                showbmp = VerifyTools.getBig(prebmp, ref mul, 560, 250, true, rectstmp);

            }
        }


        /// <summary>
        /// 右键添加菜单添加指定项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolSMItem = (ToolStripMenuItem)sender;
            string method = toolSMItem.Text.Trim();
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
                    method = "自动阀值";
                    str_params = "自动阀值";
                    break;
                case "黑白图处理":
                    method = "黑白图处理";
                    str_params = "去除杂点";
                    break;
                case "亮度对比度":
                    method = "修改亮度";
                    str_params = "3";
                    break;
                case "特殊处理":
                    method = "特殊处理";
                    str_params = "特殊处理";
                    break;

            }

            lvi.SubItems.Add(method);
            lvi.SubItems.Add(str_params);
            lvi.Checked = false;
            listView1.Items.Add(lvi);
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
        private Panel setPanelLoc(string tag, string method, string str_p, int paneltag)
        {
            panel_Binary.Visible = false;
            panel_Clip.Visible = false;
            panel_clrpro.Visible = false;
            panel_filter.Visible = false;
            panel_ngt.Visible = false;
            panel_smoothing.Visible = false;
            panel_divPixel.Visible = false;
            panel_resize.Visible = false;
            panel_clearback.Visible = false;
            panel_special.Visible = false;
            panel1.Visible = false;


            Panel panelre = null;
            string[] param = str_p.Split(' ').Where((o) => { return !string.IsNullOrEmpty(o); }).ToArray();
            if (param.Length == 0)
                return null;
            switch (tag)
            {
                case "图像缩放":
                    panelre = panel_resize;
                    panelre.Tag = paneltag;
                    if (method == "比例缩放")
                    {
                        rB_resize_scale.Checked = true;
                        comb_resize_width.Text = param[0];
                        comb_resize_height.Text = param[1];
                    }
                    else if (method == "尺寸缩放")
                    {
                        rB_resize_size.Checked = true;
                        txtBox_resize_width.Text = param[0];
                        txtBox_resize_height.Text = param[1];
                    }
                    break;
                case "图像裁剪":
                    panelre = panel_Clip;
                    panelre.Tag = paneltag;

                    if (method == "裁剪图像")
                        rB_Clip_Cut.Checked = true;
                    else if (method == "去除边框")
                        rB_Clip_clrBlock.Checked = true;
                    txtBox_Clip_up.Text = param[0];
                    txtBox_Clip_left.Text = param[1];
                    txtBox_Clip_right.Text = param[2];
                    txtBox_Clip_down.Text = param[3];
                    break;
                case "图像滤波":
                    panelre = panel_smoothing;
                    panelre.Tag = paneltag;

                    switch (param[0])
                    {
                        //5、图像滤波——3*3中值 5*5中值 均值 极值 去除细线条
                        case "中值滤波3*3":
                            rB_sm_mid3.Checked = true;
                            break;
                        case "中值滤波5*5":
                            rB_sm_mid5.Checked = true;
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
                    panelre.Tag = paneltag;

                    switch (param[0])
                    {
                        // 6、线性滤镜——浮雕、柔化、高斯、锐化、边缘、曝光、轮廓、霓虹、扩散、均衡
                        case "霓虹":
                            rB_filter_neno.Checked = true;
                            break;
                        case "锐化":
                            rB_filter_sharpen.Checked = true;
                            break;
                        case "柔化":
                            rB_filter_soften.Checked = true;
                            break;
                        case "浮雕":
                            rB_filter_Embosment.Checked = true;
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
                    panelre = panel_clearback;
                    panelre.Tag = paneltag;

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
                    panelre = panel_divPixel;
                    panelre.Tag = paneltag;

                    if (method == "按亮度分离")
                    {

                    }
                    else if (method == "按颜色分离")
                    {

                    }
                    break;
                case "颜色处理":
                    panelre = panel_clrpro;
                    panelre.Tag = paneltag;

                    switch (param[0])
                    {
                        case "灰度":
                            rB_clrpro_gray.Checked = true;
                            break;
                        case "反转":
                            rB_clrpro_reversal.Checked = true;
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
                    panelre.Tag = paneltag;

                    if (method == "转黑白图")
                    {
                        rB__Binary_allBlack.Checked = true;

                    }
                    else if (method == "指定阀值")
                    {
                        rB__Binary_threshold.Checked = true;
                    }
                    else if (method == "中值差值")
                    {
                        rB__Binary_autoSub.Checked = true;
                    }
                    else if (method == "自动阀值")
                    {
                        rB__Binary_自动阀值.Checked = true;
                    }
                    break;
                case "黑白图处理":
                    panelre = panel_ngt;
                    panelre.Tag = paneltag;

                    switch (param[0])
                    {
                        case "骨架":
                            rB_ngt_thin.Checked = true;
                            break;
                        case "腐蚀":
                            rB_ngt_erosion.Checked = true;
                            break;
                        case "膨胀":
                            rB_ngt_swell.Checked = true;
                            break;
                        case "开运算":
                            rB_ngt_open.Checked = true;
                            break;
                        case "闭运算":
                            rB_ngt_close.Checked = true;
                            break;
                        case "去除白边":
                            rB_ngt_CEdge.Checked = true;
                            break;
                        case "去除杂点":
                            rB_ngt_cNoise.Checked = true;
                            break;
                    }
                    break;
                case "亮度对比度":
                    panelre = panel1;
                    panelre.Tag = paneltag;

                    if (method == "修改亮度")
                    {

                    }
                    else if (method == "修改对比度")
                    {

                    }
                    break;
                case "特殊处理":
                    panelre = panel_special;
                    panelre.Tag = paneltag;

                    break;
            }
            if (panelre != null)
            {
                int x = listView1.Location.X + listView1.Width / 2 - panelre.Width / 2;
                int y = listView1.Location.Y + listView1.Height + 3;

                Point p = new Point(x, y);
                panelre.Visible = true;
                panelre.Location = p;

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
                panel_Binary.Visible = false;
                panel_Clip.Visible = false;
                panel_clrpro.Visible = false;
                panel_filter.Visible = false;
                panel_ngt.Visible = false;
                panel_smoothing.Visible = false;
                panel_divPixel.Visible = false;
                panel_resize.Visible = false;
                panel_clearback.Visible = false;
                panel1.Visible = false;
                return;
            }

            ListViewItem lvi = listView1.SelectedItems[0];
            string method = lvi.SubItems[1].Text;
            string str_params = lvi.SubItems[2].Text;
            string str_tag = lvi.Tag.ToString();
            int index = listView1.SelectedItems[0].Index;
            setPanelLoc(str_tag, method, str_params, index);

        }



        TMBank tmb = new TMBank();
        
        private void refreshBmpByList()
        {
            if (srcbmp == null)
            {
                return;
            }
            mul = -1;
            tmb.list_hd.Clear();
            prebmp = (Bitmap)srcbmp.Clone();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                ListViewItem lvi = listView1.Items[i];
                if (lvi.Checked)
                {
                    string method = lvi.SubItems[1].Text;
                    string str_params = lvi.SubItems[2].Text;
                    string str_tag = lvi.Tag.ToString();
                    string[] pa = str_params.Split(' ').Where((o) => { return !string.IsNullOrEmpty(o); }).ToArray();
                    methods((int)Enum.Parse(typeof(enumMethods), method), pa);
                    tmb.list_hd.Add(new ImgHd (method ,str_params ,str_tag  ));
                }
            }

            showbmp = VerifyTools.getBig(prebmp, ref mul, 560, 250);
            picBox_show.Image = showbmp;
            picBox_pre.Image = prebmp;
        }

        private void config_Changed(object sender, EventArgs e)
        {
            string method = "";
            string param = "";
             Control ctr = null;
            if (sender.GetType().ToString() == typeof(RadioButton).ToString())
            {
                ctr = (RadioButton)sender;
            }
            else if (sender.GetType().ToString() == typeof(TextBox).ToString())
            {
                ctr = (TextBox)sender;
                if (ctr.Text == "") ctr.Text = "0";
                int a;
                if (!int.TryParse(ctr.Text.Trim(), out a))
                {
                    return;
                }
            }
            else if(sender.GetType().ToString() == typeof(NumericUpDown ).ToString())
            {
                ctr =(NumericUpDown)sender;
            }
            else if (sender.GetType().ToString() == typeof(ComboBox ).ToString())
            {
                ctr = (ComboBox)sender;
            }
            else
            {
                return;
            }
            Panel fa = (Panel)ctr.Parent;
            if (fa.Tag == null)
            {
                return;
            }
            int index = (int)fa.Tag;
            getMethodParamFromPanel(fa, ref method, ref param);
            listView1.Items[index].SubItems[1].Text = method;
            listView1.Items[index].SubItems[2].Text = param;
            button2_Click(null, null);
        }

        private void getMethodParamFromPanel(Panel panel, ref string method, ref string param)
        {
            if (panel == null)
            {
                //method = "";
                param = "";
                return;
            }
            string name = panel.Name;
            switch (name)
            {
                //裁剪功能
                case "panel_Clip":
                    //txtBox_Clip_up.Text.Trim(), txtBox_Clip_left.Text.Trim(), txtBox_Clip_right.Text.Trim(), txtBox_Clip_down.Text.Trim()
                    if (txtBox_Clip_up.Text.Trim() == "") txtBox_Clip_up.Text = "0";
                    if (txtBox_Clip_left.Text.Trim() == "") txtBox_Clip_left.Text = "0";
                    if (txtBox_Clip_right.Text.Trim() == "") txtBox_Clip_right.Text = "0";
                    if (txtBox_Clip_down.Text.Trim() == "") txtBox_Clip_down.Text = "0";
                    if (rB_Clip_Cut.Checked)
                    {
                        method = enumMethods.裁剪图像.ToString();
                        param = string.Format("{0} {1} {2} {3}", txtBox_Clip_up.Text.Trim(), txtBox_Clip_left.Text.Trim(), txtBox_Clip_right.Text.Trim(), txtBox_Clip_down.Text.Trim());
                    }
                    else if (rB_Clip_clrBlock.Checked)
                    {
                        method = enumMethods.去除边框.ToString();
                        param = string.Format("{0} {1} {2} {3}", txtBox_Clip_up.Text.Trim(), txtBox_Clip_left.Text.Trim(), txtBox_Clip_right.Text.Trim(), txtBox_Clip_down.Text.Trim());
                    }
                    break;
                //
                case "panel_smoothing":
                    method = enumMethods.图像滤波.ToString();
                    foreach (Control  item in panel.Controls )
                    {
                        if(item.GetType ()==typeof (RadioButton))
                        {
                            RadioButton rb = (RadioButton)item;
                            if (rb.Checked)
                            {
                                param = string.Format("{0}", rb.Text.Trim());
                                break;
                            }
                        }
                    }
                    break;
                case "panel_clrpro":
                    method = enumMethods.颜色处理.ToString();
                    foreach (Control item in panel.Controls)
                    {
                        if (item.GetType() == typeof(RadioButton))
                        {
                            RadioButton rb = (RadioButton)item;
                            if (rb.Checked)
                            {
                                param = string.Format("{0}", rb.Text.Trim());
                                break;
                            }
                        }
                    }
                    break;
                case "panel_filter":
                    method = enumMethods.线性滤镜.ToString();
                    foreach (Control item in panel.Controls)
                    {
                        if (item.GetType() == typeof(RadioButton))
                        {
                            RadioButton rb = (RadioButton)item;
                            if (rb.Checked)
                            {
                                param = string.Format("{0}", rb.Text.Trim());
                                break;
                            }
                        }
                    }
                    break;
                case "panel_ngt":

                    method = enumMethods.黑白图处理.ToString();
                    foreach (Control item in panel.Controls)
                    {
                        if (item.GetType() == typeof(RadioButton))
                        {
                            RadioButton rb = (RadioButton)item;
                            if (rb.Checked)
                            {
                                if(rb.Text.Trim () == "去除杂点")
                                {
                                    param = string.Format("{0} {1}", rb.Text.Trim(),numericUpDown_ClearN.Value .ToString ());
                                }
                                else 
                                param = string.Format("{0}", rb.Text.Trim());

                                break;
                            }
                        }
                    }
                    break;
                    
                case "panel_Binary":


                    if (rB__Binary_自动阀值.Checked)
                    {
                        method = enumMethods.自动阀值.ToString();
                        param = string.Format("{0}", "自动阀值");
                    }
                    else if (rB__Binary_allBlack.Checked)
                    {
                        method = enumMethods.转黑白图.ToString();
                        param = string.Format("{0}", "非白转黑");
                    }
                    else if (rB__Binary_threshold.Checked)
                    {
                        method = enumMethods.指定阀值.ToString();
                        param = string.Format("{0}", txtBox_Bin_threshold.Text.Trim());
                    }
                    else if (rB__Binary_autoSub.Checked)
                    {
                        method = enumMethods.中值差值.ToString();
                        param = string.Format("{0}", numericUpDown1.Value);
                    }

                    break;
                case "panel_resize":
                    if (rB_resize_scale.Checked)
                    {
                        method = enumMethods.比例缩放.ToString();
                        param = string.Format("{0} {1}", comb_resize_width.Text.Trim(), comb_resize_height.Text.Trim());
                    }
                    else if (rB_resize_size.Checked)
                    {
                        method = enumMethods.尺寸缩放.ToString();
                        param = string.Format("{0} {1}", txtBox_resize_width.Text.Trim(), txtBox_resize_height.Text.Trim());
                    }
                    break;
                case "panel_divPixel":
                    if (rB_divPixel_color.Checked)
                    {
                        method = enumMethods.按颜色分离.ToString();
                        param = string.Format("{0} {1}", comb_divPixel_color.Text.Trim(), txtBox_divPixel_color.Text.Trim());
                    }
                    else if (rB_divPixel_light.Checked)
                    {
                        method = enumMethods.按亮度分离.ToString();
                        param = string.Format("{0} {1}", comb_divPixel_light.Text.Trim(), txtBox_divPixel_light.Text.Trim());
                    }
                    break;
                case "panel_clearback":
                    if (rB_clearback_keepcolor.Checked)
                    {
                        method = enumMethods.按颜色分离.ToString();
                        param = string.Format("{0}", txtBox_clearback_keepcolor.Text.Trim());
                    }
                    else if (rB_clearback_keeplight.Checked)
                    {
                        method = enumMethods.按亮度分离.ToString();
                        param = string.Format("{0}", txtBox_clearback_keeplight.Text.Trim());
                    }
                    break;
            }

        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            refreshBmpByList();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedCount = listView1.SelectedItems.Count;
            if (selectedCount != 1)
            {
                return;
            }
            int index = listView1.SelectedItems[0].Index;
            listView1.Items.RemoveAt(index);
        }

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btn_bin_getmid_Click(object sender, EventArgs e)
        {
            int gray = VerifyTools.GetDgGrayValue(prebmp);
            txtBox_Bin_threshold.Text = gray .ToString ();
            numericUpDown_ClearN.Value = gray;
        }

        private void 上移ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedCount = listView1.SelectedItems.Count;
            if (selectedCount != 1)
            {
                return;
            }
            int index = listView1.SelectedItems[0].Index;
            if(index <= 0)
            {
                return;
            }
            ListViewItem lvi = listView1.Items[index ];
            listView1.Items.RemoveAt(index );
            listView1.Items.Insert(index -1,lvi );
        }

        private void 下移ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedCount = listView1.SelectedItems.Count;
            if (selectedCount != 1)
            {
                return;
            }
            int index = listView1.SelectedItems[0].Index;
            if(index >=listView1.Items .Count - 1)
            {
                return;
            }
            ListViewItem lvi = listView1.Items[index];
            listView1.Items.RemoveAt(index);
            listView1.Items.Insert(index + 1, lvi);
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerifyTools.Serialize<TMBank>(tmb,@"D:\testtmb.cfg");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(File.Exists(@"D:\testtmb.cfg"))
            {
                tmb = new TMBank ();
                listView1.Items.Clear();
               TMBank  tmp_tmb = (TMBank)VerifyTools.DeSerialize<TMBank >(@"D:\testtmb.cfg");
                if(tmp_tmb != null)
                {
                    txtBox_url.Text = tmp_tmb.dir;
                    if (!(tmp_tmb.name == ""))
                    {
                        this.Text = tmp_tmb.name;
                    }
                    if(tmp_tmb.list_hd .Count > 0)
                    {
                        for (int i = 0; i < tmp_tmb.list_hd .Count ; i++)
                        {
                            ImgHd item = tmp_tmb.list_hd[i];
                            ListViewItem lvi = new ListViewItem();
                            lvi.Tag = item.tag;
                            lvi.SubItems.Add(item.method);
                            lvi.SubItems.Add(item.param);
                            lvi.Checked = true;
                            listView1.Items.Add(lvi);
                        }
                        //foreach (ImgHd  item in tmb.list_hd )
                        //{
                            
                        //}               
                    }
                    tmb = tmp_tmb;
                }
            }
        }
    }
    public enum enumMethods
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
        修改对比度,
        特殊处理
    }

}
