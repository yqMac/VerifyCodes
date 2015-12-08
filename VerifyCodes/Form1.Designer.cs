namespace VerifyCodes
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtBox_url = new System.Windows.Forms.TextBox();
            this.btn_downloadPic = new System.Windows.Forms.Button();
            this.picBox_src = new System.Windows.Forms.PictureBox();
            this.picBox_show = new System.Windows.Forms.PictureBox();
            this.btn_serchPath = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.check = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.param = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缩放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图像裁剪ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图像滤波ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.线性滤镜ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除背景ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.像素分离ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.二值化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黑白图处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.亮度对比度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.特殊处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上移ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下移ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_Clip = new System.Windows.Forms.Panel();
            this.rB_Clip_clrBlock = new System.Windows.Forms.RadioButton();
            this.rB_Clip_Cut = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Clip_right = new System.Windows.Forms.TextBox();
            this.txtBox_Clip_down = new System.Windows.Forms.TextBox();
            this.txtBox_Clip_left = new System.Windows.Forms.TextBox();
            this.txtBox_Clip_up = new System.Windows.Forms.TextBox();
            this.panel_smoothing = new System.Windows.Forms.Panel();
            this.rB_sm_mid7 = new System.Windows.Forms.RadioButton();
            this.rB_sm_ave7 = new System.Windows.Forms.RadioButton();
            this.rB_sm_ave5 = new System.Windows.Forms.RadioButton();
            this.rB_sm_mid5 = new System.Windows.Forms.RadioButton();
            this.rB_sm_ave3 = new System.Windows.Forms.RadioButton();
            this.rB_sm_mid3 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_clrpro = new System.Windows.Forms.Panel();
            this.rB_clrpro_blue = new System.Windows.Forms.RadioButton();
            this.rB_clrpro_green = new System.Windows.Forms.RadioButton();
            this.rB_clrpro_red = new System.Windows.Forms.RadioButton();
            this.rB_clrpro_reversal = new System.Windows.Forms.RadioButton();
            this.rB_clrpro_gray = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_Binary = new System.Windows.Forms.Panel();
            this.btn_bin_getmid = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtBox_Bin_threshold = new System.Windows.Forms.TextBox();
            this.rB__Binary_autoSub = new System.Windows.Forms.RadioButton();
            this.rB__Binary_threshold = new System.Windows.Forms.RadioButton();
            this.rB__Binary_allBlack = new System.Windows.Forms.RadioButton();
            this.rB__Binary_自动阀值 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_ngt = new System.Windows.Forms.Panel();
            this.rB_ngt_cNoise = new System.Windows.Forms.RadioButton();
            this.rB_ngt_close = new System.Windows.Forms.RadioButton();
            this.rB_ngt_open = new System.Windows.Forms.RadioButton();
            this.rB_ngt_swell = new System.Windows.Forms.RadioButton();
            this.rB_ngt_erosion = new System.Windows.Forms.RadioButton();
            this.rB_ngt_thin = new System.Windows.Forms.RadioButton();
            this.rB_ngt_CEdge = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel_filter = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rB_filter_neno = new System.Windows.Forms.RadioButton();
            this.rB_filter_Embosment = new System.Windows.Forms.RadioButton();
            this.rB_filter_soften = new System.Windows.Forms.RadioButton();
            this.rB_filter_atom = new System.Windows.Forms.RadioButton();
            this.rB_filter_sharpen = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.panel_resize = new System.Windows.Forms.Panel();
            this.comb_resize_height = new System.Windows.Forms.ComboBox();
            this.comb_resize_width = new System.Windows.Forms.ComboBox();
            this.txtBox_resize_height = new System.Windows.Forms.TextBox();
            this.txtBox_resize_width = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rB_resize_size = new System.Windows.Forms.RadioButton();
            this.rB_resize_scale = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_divPixel = new System.Windows.Forms.Panel();
            this.comb_divPixel_light = new System.Windows.Forms.ComboBox();
            this.comb_divPixel_color = new System.Windows.Forms.ComboBox();
            this.txtBox_divPixel_color = new System.Windows.Forms.TextBox();
            this.txtBox_divPixel_light = new System.Windows.Forms.TextBox();
            this.rB_divPixel_light = new System.Windows.Forms.RadioButton();
            this.rB_divPixel_color = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.panel_clearback = new System.Windows.Forms.Panel();
            this.txtBox_clearback_keepcolor = new System.Windows.Forms.TextBox();
            this.txtBox_clearback_keeplight = new System.Windows.Forms.TextBox();
            this.rB_clearback_keeplight = new System.Windows.Forms.RadioButton();
            this.rB_clearback_keepcolor = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.picBox_pre = new System.Windows.Forms.PictureBox();
            this.panel_special = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_clearNoise = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.picBox_small = new System.Windows.Forms.PictureBox();
            this.txtBox_MT = new System.Windows.Forms.TextBox();
            this.btn_clearEdge = new System.Windows.Forms.Button();
            this.listView_MT = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_reset = new System.Windows.Forms.Button();
            this.checkBox_splitHand = new System.Windows.Forms.CheckBox();
            this.checkBox_splitAuto = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.numericUpDown_ClearN = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_src)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_show)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel_Clip.SuspendLayout();
            this.panel_smoothing.SuspendLayout();
            this.panel_clrpro.SuspendLayout();
            this.panel_Binary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel_ngt.SuspendLayout();
            this.panel_filter.SuspendLayout();
            this.panel_resize.SuspendLayout();
            this.panel_divPixel.SuspendLayout();
            this.panel_clearback.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_pre)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_small)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ClearN)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_url
            // 
            this.txtBox_url.Location = new System.Drawing.Point(27, 37);
            this.txtBox_url.Name = "txtBox_url";
            this.txtBox_url.Size = new System.Drawing.Size(394, 21);
            this.txtBox_url.TabIndex = 0;
            this.txtBox_url.Text = "F:\\Desktop\\sina\\";
            // 
            // btn_downloadPic
            // 
            this.btn_downloadPic.Location = new System.Drawing.Point(578, 94);
            this.btn_downloadPic.Name = "btn_downloadPic";
            this.btn_downloadPic.Size = new System.Drawing.Size(108, 22);
            this.btn_downloadPic.TabIndex = 1;
            this.btn_downloadPic.Text = "下张图像";
            this.btn_downloadPic.UseVisualStyleBackColor = true;
            this.btn_downloadPic.Click += new System.EventHandler(this.btn_NexPic_Click);
            // 
            // picBox_src
            // 
            this.picBox_src.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_src.Location = new System.Drawing.Point(576, 12);
            this.picBox_src.Name = "picBox_src";
            this.picBox_src.Size = new System.Drawing.Size(233, 80);
            this.picBox_src.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_src.TabIndex = 2;
            this.picBox_src.TabStop = false;
            // 
            // picBox_show
            // 
            this.picBox_show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_show.Location = new System.Drawing.Point(13, 64);
            this.picBox_show.Name = "picBox_show";
            this.picBox_show.Size = new System.Drawing.Size(557, 216);
            this.picBox_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox_show.TabIndex = 3;
            this.picBox_show.TabStop = false;
            this.picBox_show.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_show_Paint);
            this.picBox_show.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_show_MouseDown);
            this.picBox_show.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_show_MouseMove);
            this.picBox_show.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_show_MouseUp);
            // 
            // btn_serchPath
            // 
            this.btn_serchPath.Location = new System.Drawing.Point(427, 35);
            this.btn_serchPath.Name = "btn_serchPath";
            this.btn_serchPath.Size = new System.Drawing.Size(113, 23);
            this.btn_serchPath.TabIndex = 4;
            this.btn_serchPath.Text = "初始化目录/网址";
            this.btn_serchPath.UseVisualStyleBackColor = true;
            this.btn_serchPath.Click += new System.EventHandler(this.btn_serchPath_Click);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.check,
            this.name,
            this.param});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(1, 4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(222, 120);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // check
            // 
            this.check.Text = "";
            this.check.Width = 20;
            // 
            // name
            // 
            this.name.Text = "滤镜名称";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Width = 80;
            // 
            // param
            // 
            this.param.Text = "参数";
            this.param.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.param.Width = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem,
            this.上移ToolStripMenuItem,
            this.下移ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.清空ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 114);
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.缩放ToolStripMenuItem,
            this.图像裁剪ToolStripMenuItem,
            this.图像滤波ToolStripMenuItem,
            this.线性滤镜ToolStripMenuItem,
            this.清除背景ToolStripMenuItem,
            this.像素分离ToolStripMenuItem,
            this.颜色处理ToolStripMenuItem,
            this.二值化ToolStripMenuItem,
            this.黑白图处理ToolStripMenuItem,
            this.亮度对比度ToolStripMenuItem,
            this.特殊处理ToolStripMenuItem});
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.添加ToolStripMenuItem.Text = "添加";
            // 
            // 缩放ToolStripMenuItem
            // 
            this.缩放ToolStripMenuItem.Name = "缩放ToolStripMenuItem";
            this.缩放ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.缩放ToolStripMenuItem.Text = "图像缩放";
            this.缩放ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 图像裁剪ToolStripMenuItem
            // 
            this.图像裁剪ToolStripMenuItem.Name = "图像裁剪ToolStripMenuItem";
            this.图像裁剪ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.图像裁剪ToolStripMenuItem.Text = "图像裁剪";
            this.图像裁剪ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 图像滤波ToolStripMenuItem
            // 
            this.图像滤波ToolStripMenuItem.Name = "图像滤波ToolStripMenuItem";
            this.图像滤波ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.图像滤波ToolStripMenuItem.Text = "图像滤波";
            this.图像滤波ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 线性滤镜ToolStripMenuItem
            // 
            this.线性滤镜ToolStripMenuItem.Name = "线性滤镜ToolStripMenuItem";
            this.线性滤镜ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.线性滤镜ToolStripMenuItem.Text = "线性滤镜";
            this.线性滤镜ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 清除背景ToolStripMenuItem
            // 
            this.清除背景ToolStripMenuItem.Name = "清除背景ToolStripMenuItem";
            this.清除背景ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.清除背景ToolStripMenuItem.Text = "清除背景";
            this.清除背景ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 像素分离ToolStripMenuItem
            // 
            this.像素分离ToolStripMenuItem.Name = "像素分离ToolStripMenuItem";
            this.像素分离ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.像素分离ToolStripMenuItem.Text = "像素分离";
            this.像素分离ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 颜色处理ToolStripMenuItem
            // 
            this.颜色处理ToolStripMenuItem.Name = "颜色处理ToolStripMenuItem";
            this.颜色处理ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.颜色处理ToolStripMenuItem.Text = "颜色处理";
            this.颜色处理ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 二值化ToolStripMenuItem
            // 
            this.二值化ToolStripMenuItem.Name = "二值化ToolStripMenuItem";
            this.二值化ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.二值化ToolStripMenuItem.Text = "二值化";
            this.二值化ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 黑白图处理ToolStripMenuItem
            // 
            this.黑白图处理ToolStripMenuItem.Name = "黑白图处理ToolStripMenuItem";
            this.黑白图处理ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.黑白图处理ToolStripMenuItem.Text = "黑白图处理";
            this.黑白图处理ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 亮度对比度ToolStripMenuItem
            // 
            this.亮度对比度ToolStripMenuItem.Name = "亮度对比度ToolStripMenuItem";
            this.亮度对比度ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.亮度对比度ToolStripMenuItem.Text = "亮度对比度";
            this.亮度对比度ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 特殊处理ToolStripMenuItem
            // 
            this.特殊处理ToolStripMenuItem.Name = "特殊处理ToolStripMenuItem";
            this.特殊处理ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.特殊处理ToolStripMenuItem.Text = "特殊处理";
            this.特殊处理ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 上移ToolStripMenuItem
            // 
            this.上移ToolStripMenuItem.Name = "上移ToolStripMenuItem";
            this.上移ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.上移ToolStripMenuItem.Text = "上移";
            this.上移ToolStripMenuItem.Click += new System.EventHandler(this.上移ToolStripMenuItem_Click);
            // 
            // 下移ToolStripMenuItem
            // 
            this.下移ToolStripMenuItem.Name = "下移ToolStripMenuItem";
            this.下移ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.下移ToolStripMenuItem.Text = "下移";
            this.下移ToolStripMenuItem.Click += new System.EventHandler(this.下移ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.清空ToolStripMenuItem.Text = "清空";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.清空ToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(692, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 22);
            this.button2.TabIndex = 8;
            this.button2.Text = "刷新显示";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel_Clip
            // 
            this.panel_Clip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Clip.Controls.Add(this.rB_Clip_clrBlock);
            this.panel_Clip.Controls.Add(this.rB_Clip_Cut);
            this.panel_Clip.Controls.Add(this.label5);
            this.panel_Clip.Controls.Add(this.label4);
            this.panel_Clip.Controls.Add(this.label3);
            this.panel_Clip.Controls.Add(this.label2);
            this.panel_Clip.Controls.Add(this.txtBox_Clip_right);
            this.panel_Clip.Controls.Add(this.txtBox_Clip_down);
            this.panel_Clip.Controls.Add(this.txtBox_Clip_left);
            this.panel_Clip.Controls.Add(this.txtBox_Clip_up);
            this.panel_Clip.Location = new System.Drawing.Point(257, 146);
            this.panel_Clip.Name = "panel_Clip";
            this.panel_Clip.Size = new System.Drawing.Size(201, 129);
            this.panel_Clip.TabIndex = 29;
            // 
            // rB_Clip_clrBlock
            // 
            this.rB_Clip_clrBlock.AutoSize = true;
            this.rB_Clip_clrBlock.Location = new System.Drawing.Point(112, 18);
            this.rB_Clip_clrBlock.Name = "rB_Clip_clrBlock";
            this.rB_Clip_clrBlock.Size = new System.Drawing.Size(71, 16);
            this.rB_Clip_clrBlock.TabIndex = 10;
            this.rB_Clip_clrBlock.TabStop = true;
            this.rB_Clip_clrBlock.Text = "去除边框";
            this.rB_Clip_clrBlock.UseVisualStyleBackColor = true;
            this.rB_Clip_clrBlock.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_Clip_Cut
            // 
            this.rB_Clip_Cut.AutoSize = true;
            this.rB_Clip_Cut.Location = new System.Drawing.Point(9, 18);
            this.rB_Clip_Cut.Name = "rB_Clip_Cut";
            this.rB_Clip_Cut.Size = new System.Drawing.Size(71, 16);
            this.rB_Clip_Cut.TabIndex = 9;
            this.rB_Clip_Cut.TabStop = true;
            this.rB_Clip_Cut.Text = "裁剪图像";
            this.rB_Clip_Cut.UseVisualStyleBackColor = true;
            this.rB_Clip_Cut.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "左：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "下：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "右：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "上:";
            // 
            // txtBox_Clip_right
            // 
            this.txtBox_Clip_right.Location = new System.Drawing.Point(136, 66);
            this.txtBox_Clip_right.Name = "txtBox_Clip_right";
            this.txtBox_Clip_right.Size = new System.Drawing.Size(32, 21);
            this.txtBox_Clip_right.TabIndex = 4;
            this.txtBox_Clip_right.Text = "0";
            this.txtBox_Clip_right.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Clip_right.TextChanged += new System.EventHandler(this.config_Changed);
            // 
            // txtBox_Clip_down
            // 
            this.txtBox_Clip_down.Location = new System.Drawing.Point(93, 92);
            this.txtBox_Clip_down.Name = "txtBox_Clip_down";
            this.txtBox_Clip_down.Size = new System.Drawing.Size(27, 21);
            this.txtBox_Clip_down.TabIndex = 3;
            this.txtBox_Clip_down.Text = "0";
            this.txtBox_Clip_down.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Clip_down.TextChanged += new System.EventHandler(this.config_Changed);
            // 
            // txtBox_Clip_left
            // 
            this.txtBox_Clip_left.Location = new System.Drawing.Point(52, 66);
            this.txtBox_Clip_left.Name = "txtBox_Clip_left";
            this.txtBox_Clip_left.Size = new System.Drawing.Size(29, 21);
            this.txtBox_Clip_left.TabIndex = 2;
            this.txtBox_Clip_left.Text = "0";
            this.txtBox_Clip_left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Clip_left.TextChanged += new System.EventHandler(this.config_Changed);
            // 
            // txtBox_Clip_up
            // 
            this.txtBox_Clip_up.Location = new System.Drawing.Point(93, 39);
            this.txtBox_Clip_up.Name = "txtBox_Clip_up";
            this.txtBox_Clip_up.Size = new System.Drawing.Size(27, 21);
            this.txtBox_Clip_up.TabIndex = 1;
            this.txtBox_Clip_up.Text = "0";
            this.txtBox_Clip_up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Clip_up.TextChanged += new System.EventHandler(this.config_Changed);
            // 
            // panel_smoothing
            // 
            this.panel_smoothing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_smoothing.Controls.Add(this.rB_sm_mid7);
            this.panel_smoothing.Controls.Add(this.rB_sm_ave7);
            this.panel_smoothing.Controls.Add(this.rB_sm_ave5);
            this.panel_smoothing.Controls.Add(this.rB_sm_mid5);
            this.panel_smoothing.Controls.Add(this.rB_sm_ave3);
            this.panel_smoothing.Controls.Add(this.rB_sm_mid3);
            this.panel_smoothing.Controls.Add(this.label6);
            this.panel_smoothing.Location = new System.Drawing.Point(705, 252);
            this.panel_smoothing.Name = "panel_smoothing";
            this.panel_smoothing.Size = new System.Drawing.Size(201, 106);
            this.panel_smoothing.TabIndex = 30;
            // 
            // rB_sm_mid7
            // 
            this.rB_sm_mid7.AutoSize = true;
            this.rB_sm_mid7.Location = new System.Drawing.Point(7, 80);
            this.rB_sm_mid7.Name = "rB_sm_mid7";
            this.rB_sm_mid7.Size = new System.Drawing.Size(89, 16);
            this.rB_sm_mid7.TabIndex = 7;
            this.rB_sm_mid7.TabStop = true;
            this.rB_sm_mid7.Text = "中值滤波7*7";
            this.rB_sm_mid7.UseVisualStyleBackColor = true;
            this.rB_sm_mid7.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_sm_ave7
            // 
            this.rB_sm_ave7.AutoSize = true;
            this.rB_sm_ave7.Location = new System.Drawing.Point(103, 80);
            this.rB_sm_ave7.Name = "rB_sm_ave7";
            this.rB_sm_ave7.Size = new System.Drawing.Size(89, 16);
            this.rB_sm_ave7.TabIndex = 6;
            this.rB_sm_ave7.TabStop = true;
            this.rB_sm_ave7.Text = "均值滤波7*7";
            this.rB_sm_ave7.UseVisualStyleBackColor = true;
            this.rB_sm_ave7.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_sm_ave5
            // 
            this.rB_sm_ave5.AutoSize = true;
            this.rB_sm_ave5.Location = new System.Drawing.Point(103, 56);
            this.rB_sm_ave5.Name = "rB_sm_ave5";
            this.rB_sm_ave5.Size = new System.Drawing.Size(89, 16);
            this.rB_sm_ave5.TabIndex = 5;
            this.rB_sm_ave5.TabStop = true;
            this.rB_sm_ave5.Text = "均值滤波5*5";
            this.rB_sm_ave5.UseVisualStyleBackColor = true;
            this.rB_sm_ave5.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_sm_mid5
            // 
            this.rB_sm_mid5.AutoSize = true;
            this.rB_sm_mid5.Location = new System.Drawing.Point(7, 56);
            this.rB_sm_mid5.Name = "rB_sm_mid5";
            this.rB_sm_mid5.Size = new System.Drawing.Size(89, 16);
            this.rB_sm_mid5.TabIndex = 4;
            this.rB_sm_mid5.TabStop = true;
            this.rB_sm_mid5.Text = "中值滤波5*5";
            this.rB_sm_mid5.UseVisualStyleBackColor = true;
            this.rB_sm_mid5.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_sm_ave3
            // 
            this.rB_sm_ave3.AutoSize = true;
            this.rB_sm_ave3.Location = new System.Drawing.Point(103, 29);
            this.rB_sm_ave3.Name = "rB_sm_ave3";
            this.rB_sm_ave3.Size = new System.Drawing.Size(89, 16);
            this.rB_sm_ave3.TabIndex = 3;
            this.rB_sm_ave3.TabStop = true;
            this.rB_sm_ave3.Text = "均值滤波3*3";
            this.rB_sm_ave3.UseVisualStyleBackColor = true;
            this.rB_sm_ave3.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_sm_mid3
            // 
            this.rB_sm_mid3.AutoSize = true;
            this.rB_sm_mid3.Location = new System.Drawing.Point(7, 29);
            this.rB_sm_mid3.Name = "rB_sm_mid3";
            this.rB_sm_mid3.Size = new System.Drawing.Size(89, 16);
            this.rB_sm_mid3.TabIndex = 2;
            this.rB_sm_mid3.TabStop = true;
            this.rB_sm_mid3.Text = "中值滤波3*3";
            this.rB_sm_mid3.UseVisualStyleBackColor = true;
            this.rB_sm_mid3.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "滤波";
            // 
            // panel_clrpro
            // 
            this.panel_clrpro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_clrpro.Controls.Add(this.rB_clrpro_blue);
            this.panel_clrpro.Controls.Add(this.rB_clrpro_green);
            this.panel_clrpro.Controls.Add(this.rB_clrpro_red);
            this.panel_clrpro.Controls.Add(this.rB_clrpro_reversal);
            this.panel_clrpro.Controls.Add(this.rB_clrpro_gray);
            this.panel_clrpro.Controls.Add(this.label7);
            this.panel_clrpro.Location = new System.Drawing.Point(498, 7);
            this.panel_clrpro.Name = "panel_clrpro";
            this.panel_clrpro.Size = new System.Drawing.Size(201, 110);
            this.panel_clrpro.TabIndex = 31;
            // 
            // rB_clrpro_blue
            // 
            this.rB_clrpro_blue.AutoSize = true;
            this.rB_clrpro_blue.Location = new System.Drawing.Point(29, 88);
            this.rB_clrpro_blue.Name = "rB_clrpro_blue";
            this.rB_clrpro_blue.Size = new System.Drawing.Size(47, 16);
            this.rB_clrpro_blue.TabIndex = 7;
            this.rB_clrpro_blue.TabStop = true;
            this.rB_clrpro_blue.Text = "单蓝";
            this.rB_clrpro_blue.UseVisualStyleBackColor = true;
            this.rB_clrpro_blue.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_clrpro_green
            // 
            this.rB_clrpro_green.AutoSize = true;
            this.rB_clrpro_green.Location = new System.Drawing.Point(132, 62);
            this.rB_clrpro_green.Name = "rB_clrpro_green";
            this.rB_clrpro_green.Size = new System.Drawing.Size(47, 16);
            this.rB_clrpro_green.TabIndex = 5;
            this.rB_clrpro_green.TabStop = true;
            this.rB_clrpro_green.Text = "单绿";
            this.rB_clrpro_green.UseVisualStyleBackColor = true;
            this.rB_clrpro_green.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_clrpro_red
            // 
            this.rB_clrpro_red.AutoSize = true;
            this.rB_clrpro_red.Location = new System.Drawing.Point(29, 62);
            this.rB_clrpro_red.Name = "rB_clrpro_red";
            this.rB_clrpro_red.Size = new System.Drawing.Size(47, 16);
            this.rB_clrpro_red.TabIndex = 4;
            this.rB_clrpro_red.TabStop = true;
            this.rB_clrpro_red.Text = "单红";
            this.rB_clrpro_red.UseVisualStyleBackColor = true;
            this.rB_clrpro_red.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_clrpro_reversal
            // 
            this.rB_clrpro_reversal.AutoSize = true;
            this.rB_clrpro_reversal.Location = new System.Drawing.Point(132, 36);
            this.rB_clrpro_reversal.Name = "rB_clrpro_reversal";
            this.rB_clrpro_reversal.Size = new System.Drawing.Size(47, 16);
            this.rB_clrpro_reversal.TabIndex = 3;
            this.rB_clrpro_reversal.TabStop = true;
            this.rB_clrpro_reversal.Text = "反转";
            this.rB_clrpro_reversal.UseVisualStyleBackColor = true;
            this.rB_clrpro_reversal.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_clrpro_gray
            // 
            this.rB_clrpro_gray.AutoSize = true;
            this.rB_clrpro_gray.Location = new System.Drawing.Point(29, 36);
            this.rB_clrpro_gray.Name = "rB_clrpro_gray";
            this.rB_clrpro_gray.Size = new System.Drawing.Size(47, 16);
            this.rB_clrpro_gray.TabIndex = 2;
            this.rB_clrpro_gray.TabStop = true;
            this.rB_clrpro_gray.Text = "灰度";
            this.rB_clrpro_gray.UseVisualStyleBackColor = true;
            this.rB_clrpro_gray.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "颜色处理";
            // 
            // panel_Binary
            // 
            this.panel_Binary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Binary.Controls.Add(this.btn_bin_getmid);
            this.panel_Binary.Controls.Add(this.numericUpDown1);
            this.panel_Binary.Controls.Add(this.txtBox_Bin_threshold);
            this.panel_Binary.Controls.Add(this.rB__Binary_autoSub);
            this.panel_Binary.Controls.Add(this.rB__Binary_threshold);
            this.panel_Binary.Controls.Add(this.rB__Binary_allBlack);
            this.panel_Binary.Controls.Add(this.rB__Binary_自动阀值);
            this.panel_Binary.Controls.Add(this.label8);
            this.panel_Binary.Location = new System.Drawing.Point(257, 3);
            this.panel_Binary.Name = "panel_Binary";
            this.panel_Binary.Size = new System.Drawing.Size(201, 121);
            this.panel_Binary.TabIndex = 32;
            // 
            // btn_bin_getmid
            // 
            this.btn_bin_getmid.Location = new System.Drawing.Point(145, 59);
            this.btn_bin_getmid.Name = "btn_bin_getmid";
            this.btn_bin_getmid.Size = new System.Drawing.Size(47, 23);
            this.btn_bin_getmid.TabIndex = 11;
            this.btn_bin_getmid.Text = "取优";
            this.btn_bin_getmid.UseVisualStyleBackColor = true;
            this.btn_bin_getmid.Click += new System.EventHandler(this.btn_bin_getmid_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(94, 92);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 21);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.config_Changed);
            // 
            // txtBox_Bin_threshold
            // 
            this.txtBox_Bin_threshold.Location = new System.Drawing.Point(94, 60);
            this.txtBox_Bin_threshold.Name = "txtBox_Bin_threshold";
            this.txtBox_Bin_threshold.Size = new System.Drawing.Size(45, 21);
            this.txtBox_Bin_threshold.TabIndex = 8;
            this.txtBox_Bin_threshold.Text = "127";
            this.txtBox_Bin_threshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Bin_threshold.TextChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB__Binary_autoSub
            // 
            this.rB__Binary_autoSub.AutoSize = true;
            this.rB__Binary_autoSub.Location = new System.Drawing.Point(9, 92);
            this.rB__Binary_autoSub.Name = "rB__Binary_autoSub";
            this.rB__Binary_autoSub.Size = new System.Drawing.Size(71, 16);
            this.rB__Binary_autoSub.TabIndex = 5;
            this.rB__Binary_autoSub.TabStop = true;
            this.rB__Binary_autoSub.Text = "自动差值";
            this.rB__Binary_autoSub.UseVisualStyleBackColor = true;
            this.rB__Binary_autoSub.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB__Binary_threshold
            // 
            this.rB__Binary_threshold.AutoSize = true;
            this.rB__Binary_threshold.Location = new System.Drawing.Point(10, 62);
            this.rB__Binary_threshold.Name = "rB__Binary_threshold";
            this.rB__Binary_threshold.Size = new System.Drawing.Size(71, 16);
            this.rB__Binary_threshold.TabIndex = 4;
            this.rB__Binary_threshold.TabStop = true;
            this.rB__Binary_threshold.Text = "指定阀值";
            this.rB__Binary_threshold.UseVisualStyleBackColor = true;
            this.rB__Binary_threshold.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB__Binary_allBlack
            // 
            this.rB__Binary_allBlack.AutoSize = true;
            this.rB__Binary_allBlack.Location = new System.Drawing.Point(114, 34);
            this.rB__Binary_allBlack.Name = "rB__Binary_allBlack";
            this.rB__Binary_allBlack.Size = new System.Drawing.Size(71, 16);
            this.rB__Binary_allBlack.TabIndex = 3;
            this.rB__Binary_allBlack.TabStop = true;
            this.rB__Binary_allBlack.Text = "非白转黑";
            this.rB__Binary_allBlack.UseVisualStyleBackColor = true;
            this.rB__Binary_allBlack.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB__Binary_自动阀值
            // 
            this.rB__Binary_自动阀值.AutoSize = true;
            this.rB__Binary_自动阀值.Location = new System.Drawing.Point(10, 34);
            this.rB__Binary_自动阀值.Name = "rB__Binary_自动阀值";
            this.rB__Binary_自动阀值.Size = new System.Drawing.Size(71, 16);
            this.rB__Binary_自动阀值.TabIndex = 2;
            this.rB__Binary_自动阀值.TabStop = true;
            this.rB__Binary_自动阀值.Text = "自动阀值";
            this.rB__Binary_自动阀值.UseVisualStyleBackColor = true;
            this.rB__Binary_自动阀值.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "二值化";
            // 
            // panel_ngt
            // 
            this.panel_ngt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ngt.Controls.Add(this.numericUpDown_ClearN);
            this.panel_ngt.Controls.Add(this.button5);
            this.panel_ngt.Controls.Add(this.rB_ngt_cNoise);
            this.panel_ngt.Controls.Add(this.rB_ngt_close);
            this.panel_ngt.Controls.Add(this.rB_ngt_open);
            this.panel_ngt.Controls.Add(this.rB_ngt_swell);
            this.panel_ngt.Controls.Add(this.rB_ngt_erosion);
            this.panel_ngt.Controls.Add(this.rB_ngt_thin);
            this.panel_ngt.Controls.Add(this.rB_ngt_CEdge);
            this.panel_ngt.Controls.Add(this.label9);
            this.panel_ngt.Location = new System.Drawing.Point(257, 276);
            this.panel_ngt.Name = "panel_ngt";
            this.panel_ngt.Size = new System.Drawing.Size(201, 129);
            this.panel_ngt.TabIndex = 33;
            // 
            // rB_ngt_cNoise
            // 
            this.rB_ngt_cNoise.AutoSize = true;
            this.rB_ngt_cNoise.Location = new System.Drawing.Point(10, 102);
            this.rB_ngt_cNoise.Name = "rB_ngt_cNoise";
            this.rB_ngt_cNoise.Size = new System.Drawing.Size(71, 16);
            this.rB_ngt_cNoise.TabIndex = 15;
            this.rB_ngt_cNoise.TabStop = true;
            this.rB_ngt_cNoise.Text = "去除杂点";
            this.rB_ngt_cNoise.UseVisualStyleBackColor = true;
            this.rB_ngt_cNoise.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_ngt_close
            // 
            this.rB_ngt_close.AutoSize = true;
            this.rB_ngt_close.Location = new System.Drawing.Point(84, 72);
            this.rB_ngt_close.Name = "rB_ngt_close";
            this.rB_ngt_close.Size = new System.Drawing.Size(59, 16);
            this.rB_ngt_close.TabIndex = 14;
            this.rB_ngt_close.TabStop = true;
            this.rB_ngt_close.Text = "闭运算";
            this.rB_ngt_close.UseVisualStyleBackColor = true;
            this.rB_ngt_close.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_ngt_open
            // 
            this.rB_ngt_open.AutoSize = true;
            this.rB_ngt_open.Location = new System.Drawing.Point(84, 42);
            this.rB_ngt_open.Name = "rB_ngt_open";
            this.rB_ngt_open.Size = new System.Drawing.Size(59, 16);
            this.rB_ngt_open.TabIndex = 13;
            this.rB_ngt_open.TabStop = true;
            this.rB_ngt_open.Text = "开运算";
            this.rB_ngt_open.UseVisualStyleBackColor = true;
            this.rB_ngt_open.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_ngt_swell
            // 
            this.rB_ngt_swell.AutoSize = true;
            this.rB_ngt_swell.Location = new System.Drawing.Point(146, 73);
            this.rB_ngt_swell.Name = "rB_ngt_swell";
            this.rB_ngt_swell.Size = new System.Drawing.Size(47, 16);
            this.rB_ngt_swell.TabIndex = 12;
            this.rB_ngt_swell.TabStop = true;
            this.rB_ngt_swell.Text = "膨胀";
            this.rB_ngt_swell.UseVisualStyleBackColor = true;
            this.rB_ngt_swell.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_ngt_erosion
            // 
            this.rB_ngt_erosion.AutoSize = true;
            this.rB_ngt_erosion.Location = new System.Drawing.Point(146, 42);
            this.rB_ngt_erosion.Name = "rB_ngt_erosion";
            this.rB_ngt_erosion.Size = new System.Drawing.Size(47, 16);
            this.rB_ngt_erosion.TabIndex = 11;
            this.rB_ngt_erosion.TabStop = true;
            this.rB_ngt_erosion.Text = "腐蚀";
            this.rB_ngt_erosion.UseVisualStyleBackColor = true;
            this.rB_ngt_erosion.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_ngt_thin
            // 
            this.rB_ngt_thin.AutoSize = true;
            this.rB_ngt_thin.Location = new System.Drawing.Point(10, 73);
            this.rB_ngt_thin.Name = "rB_ngt_thin";
            this.rB_ngt_thin.Size = new System.Drawing.Size(47, 16);
            this.rB_ngt_thin.TabIndex = 3;
            this.rB_ngt_thin.TabStop = true;
            this.rB_ngt_thin.Text = "骨架";
            this.rB_ngt_thin.UseVisualStyleBackColor = true;
            this.rB_ngt_thin.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_ngt_CEdge
            // 
            this.rB_ngt_CEdge.AutoSize = true;
            this.rB_ngt_CEdge.Location = new System.Drawing.Point(10, 41);
            this.rB_ngt_CEdge.Name = "rB_ngt_CEdge";
            this.rB_ngt_CEdge.Size = new System.Drawing.Size(71, 16);
            this.rB_ngt_CEdge.TabIndex = 2;
            this.rB_ngt_CEdge.TabStop = true;
            this.rB_ngt_CEdge.Text = "去除白边";
            this.rB_ngt_CEdge.UseVisualStyleBackColor = true;
            this.rB_ngt_CEdge.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "黑白图处理";
            // 
            // panel_filter
            // 
            this.panel_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_filter.Controls.Add(this.radioButton3);
            this.panel_filter.Controls.Add(this.rB_filter_neno);
            this.panel_filter.Controls.Add(this.rB_filter_Embosment);
            this.panel_filter.Controls.Add(this.rB_filter_soften);
            this.panel_filter.Controls.Add(this.rB_filter_atom);
            this.panel_filter.Controls.Add(this.rB_filter_sharpen);
            this.panel_filter.Controls.Add(this.label10);
            this.panel_filter.Location = new System.Drawing.Point(705, 140);
            this.panel_filter.Name = "panel_filter";
            this.panel_filter.Size = new System.Drawing.Size(201, 106);
            this.panel_filter.TabIndex = 36;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(144, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 16);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "雾化";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rB_filter_neno
            // 
            this.rB_filter_neno.AutoSize = true;
            this.rB_filter_neno.Location = new System.Drawing.Point(76, 36);
            this.rB_filter_neno.Name = "rB_filter_neno";
            this.rB_filter_neno.Size = new System.Drawing.Size(47, 16);
            this.rB_filter_neno.TabIndex = 7;
            this.rB_filter_neno.TabStop = true;
            this.rB_filter_neno.Text = "霓虹";
            this.rB_filter_neno.UseVisualStyleBackColor = true;
            this.rB_filter_neno.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_filter_Embosment
            // 
            this.rB_filter_Embosment.AutoSize = true;
            this.rB_filter_Embosment.Location = new System.Drawing.Point(76, 72);
            this.rB_filter_Embosment.Name = "rB_filter_Embosment";
            this.rB_filter_Embosment.Size = new System.Drawing.Size(47, 16);
            this.rB_filter_Embosment.TabIndex = 5;
            this.rB_filter_Embosment.TabStop = true;
            this.rB_filter_Embosment.Text = "浮雕";
            this.rB_filter_Embosment.UseVisualStyleBackColor = true;
            this.rB_filter_Embosment.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_filter_soften
            // 
            this.rB_filter_soften.AutoSize = true;
            this.rB_filter_soften.Location = new System.Drawing.Point(11, 72);
            this.rB_filter_soften.Name = "rB_filter_soften";
            this.rB_filter_soften.Size = new System.Drawing.Size(47, 16);
            this.rB_filter_soften.TabIndex = 4;
            this.rB_filter_soften.TabStop = true;
            this.rB_filter_soften.Text = "柔化";
            this.rB_filter_soften.UseVisualStyleBackColor = true;
            this.rB_filter_soften.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_filter_atom
            // 
            this.rB_filter_atom.AutoSize = true;
            this.rB_filter_atom.Location = new System.Drawing.Point(144, 36);
            this.rB_filter_atom.Name = "rB_filter_atom";
            this.rB_filter_atom.Size = new System.Drawing.Size(47, 16);
            this.rB_filter_atom.TabIndex = 3;
            this.rB_filter_atom.TabStop = true;
            this.rB_filter_atom.Text = "雾化";
            this.rB_filter_atom.UseVisualStyleBackColor = true;
            this.rB_filter_atom.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_filter_sharpen
            // 
            this.rB_filter_sharpen.AutoSize = true;
            this.rB_filter_sharpen.Location = new System.Drawing.Point(11, 36);
            this.rB_filter_sharpen.Name = "rB_filter_sharpen";
            this.rB_filter_sharpen.Size = new System.Drawing.Size(47, 16);
            this.rB_filter_sharpen.TabIndex = 2;
            this.rB_filter_sharpen.TabStop = true;
            this.rB_filter_sharpen.Text = "锐化";
            this.rB_filter_sharpen.UseVisualStyleBackColor = true;
            this.rB_filter_sharpen.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "滤镜处理";
            // 
            // panel_resize
            // 
            this.panel_resize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_resize.Controls.Add(this.comb_resize_height);
            this.panel_resize.Controls.Add(this.comb_resize_width);
            this.panel_resize.Controls.Add(this.txtBox_resize_height);
            this.panel_resize.Controls.Add(this.txtBox_resize_width);
            this.panel_resize.Controls.Add(this.label14);
            this.panel_resize.Controls.Add(this.label13);
            this.panel_resize.Controls.Add(this.label12);
            this.panel_resize.Controls.Add(this.label11);
            this.panel_resize.Controls.Add(this.rB_resize_size);
            this.panel_resize.Controls.Add(this.rB_resize_scale);
            this.panel_resize.Controls.Add(this.label1);
            this.panel_resize.Location = new System.Drawing.Point(705, 8);
            this.panel_resize.Name = "panel_resize";
            this.panel_resize.Size = new System.Drawing.Size(201, 127);
            this.panel_resize.TabIndex = 37;
            // 
            // comb_resize_height
            // 
            this.comb_resize_height.FormattingEnabled = true;
            this.comb_resize_height.Items.AddRange(new object[] {
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9",
            "1.0"});
            this.comb_resize_height.Location = new System.Drawing.Point(137, 54);
            this.comb_resize_height.Name = "comb_resize_height";
            this.comb_resize_height.Size = new System.Drawing.Size(42, 20);
            this.comb_resize_height.TabIndex = 15;
            this.comb_resize_height.Text = "1.0";
            this.comb_resize_height.TextChanged += new System.EventHandler(this.config_Changed);
            // 
            // comb_resize_width
            // 
            this.comb_resize_width.FormattingEnabled = true;
            this.comb_resize_width.Items.AddRange(new object[] {
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9",
            "1.0"});
            this.comb_resize_width.Location = new System.Drawing.Point(52, 54);
            this.comb_resize_width.Name = "comb_resize_width";
            this.comb_resize_width.Size = new System.Drawing.Size(42, 20);
            this.comb_resize_width.TabIndex = 14;
            this.comb_resize_width.Text = "1.0";
            this.comb_resize_width.TextChanged += new System.EventHandler(this.config_Changed);
            // 
            // txtBox_resize_height
            // 
            this.txtBox_resize_height.Location = new System.Drawing.Point(137, 97);
            this.txtBox_resize_height.Name = "txtBox_resize_height";
            this.txtBox_resize_height.Size = new System.Drawing.Size(42, 21);
            this.txtBox_resize_height.TabIndex = 13;
            this.txtBox_resize_height.Text = "127";
            this.txtBox_resize_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_resize_height.TextChanged += new System.EventHandler(this.config_Changed);
            // 
            // txtBox_resize_width
            // 
            this.txtBox_resize_width.Location = new System.Drawing.Point(52, 97);
            this.txtBox_resize_width.Name = "txtBox_resize_width";
            this.txtBox_resize_width.Size = new System.Drawing.Size(42, 21);
            this.txtBox_resize_width.TabIndex = 12;
            this.txtBox_resize_width.Text = "127";
            this.txtBox_resize_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_resize_width.TextChanged += new System.EventHandler(this.config_Changed);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(111, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "高：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 10;
            this.label13.Text = "宽：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(111, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "高：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "宽：";
            // 
            // rB_resize_size
            // 
            this.rB_resize_size.AutoSize = true;
            this.rB_resize_size.Location = new System.Drawing.Point(9, 80);
            this.rB_resize_size.Name = "rB_resize_size";
            this.rB_resize_size.Size = new System.Drawing.Size(47, 16);
            this.rB_resize_size.TabIndex = 7;
            this.rB_resize_size.TabStop = true;
            this.rB_resize_size.Text = "宽高";
            this.rB_resize_size.UseVisualStyleBackColor = true;
            this.rB_resize_size.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_resize_scale
            // 
            this.rB_resize_scale.AutoSize = true;
            this.rB_resize_scale.Location = new System.Drawing.Point(5, 34);
            this.rB_resize_scale.Name = "rB_resize_scale";
            this.rB_resize_scale.Size = new System.Drawing.Size(47, 16);
            this.rB_resize_scale.TabIndex = 2;
            this.rB_resize_scale.TabStop = true;
            this.rB_resize_scale.Text = "比例";
            this.rB_resize_scale.UseVisualStyleBackColor = true;
            this.rB_resize_scale.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "图像缩放";
            // 
            // panel_divPixel
            // 
            this.panel_divPixel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_divPixel.Controls.Add(this.comb_divPixel_light);
            this.panel_divPixel.Controls.Add(this.comb_divPixel_color);
            this.panel_divPixel.Controls.Add(this.txtBox_divPixel_color);
            this.panel_divPixel.Controls.Add(this.txtBox_divPixel_light);
            this.panel_divPixel.Controls.Add(this.rB_divPixel_light);
            this.panel_divPixel.Controls.Add(this.rB_divPixel_color);
            this.panel_divPixel.Controls.Add(this.label19);
            this.panel_divPixel.Location = new System.Drawing.Point(498, 242);
            this.panel_divPixel.Name = "panel_divPixel";
            this.panel_divPixel.Size = new System.Drawing.Size(201, 97);
            this.panel_divPixel.TabIndex = 38;
            // 
            // comb_divPixel_light
            // 
            this.comb_divPixel_light.FormattingEnabled = true;
            this.comb_divPixel_light.Items.AddRange(new object[] {
            ">",
            "<",
            "="});
            this.comb_divPixel_light.Location = new System.Drawing.Point(63, 67);
            this.comb_divPixel_light.Name = "comb_divPixel_light";
            this.comb_divPixel_light.Size = new System.Drawing.Size(42, 20);
            this.comb_divPixel_light.TabIndex = 15;
            this.comb_divPixel_light.Text = ">";
            this.comb_divPixel_light.TextChanged += new System.EventHandler(this.config_Changed);
            // 
            // comb_divPixel_color
            // 
            this.comb_divPixel_color.FormattingEnabled = true;
            this.comb_divPixel_color.Items.AddRange(new object[] {
            ">",
            "<",
            "="});
            this.comb_divPixel_color.Location = new System.Drawing.Point(63, 34);
            this.comb_divPixel_color.Name = "comb_divPixel_color";
            this.comb_divPixel_color.Size = new System.Drawing.Size(42, 20);
            this.comb_divPixel_color.TabIndex = 14;
            this.comb_divPixel_color.Text = ">";
            this.comb_divPixel_color.TextChanged += new System.EventHandler(this.config_Changed);
            // 
            // txtBox_divPixel_color
            // 
            this.txtBox_divPixel_color.Location = new System.Drawing.Point(114, 33);
            this.txtBox_divPixel_color.Name = "txtBox_divPixel_color";
            this.txtBox_divPixel_color.Size = new System.Drawing.Size(42, 21);
            this.txtBox_divPixel_color.TabIndex = 13;
            this.txtBox_divPixel_color.Text = "127";
            this.txtBox_divPixel_color.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_divPixel_color.TextChanged += new System.EventHandler(this.config_Changed);
            // 
            // txtBox_divPixel_light
            // 
            this.txtBox_divPixel_light.Location = new System.Drawing.Point(114, 68);
            this.txtBox_divPixel_light.Name = "txtBox_divPixel_light";
            this.txtBox_divPixel_light.Size = new System.Drawing.Size(42, 21);
            this.txtBox_divPixel_light.TabIndex = 12;
            this.txtBox_divPixel_light.Text = "127";
            this.txtBox_divPixel_light.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_divPixel_light.TextChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_divPixel_light
            // 
            this.rB_divPixel_light.AutoSize = true;
            this.rB_divPixel_light.Location = new System.Drawing.Point(9, 71);
            this.rB_divPixel_light.Name = "rB_divPixel_light";
            this.rB_divPixel_light.Size = new System.Drawing.Size(47, 16);
            this.rB_divPixel_light.TabIndex = 7;
            this.rB_divPixel_light.TabStop = true;
            this.rB_divPixel_light.Text = "亮度";
            this.rB_divPixel_light.UseVisualStyleBackColor = true;
            this.rB_divPixel_light.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_divPixel_color
            // 
            this.rB_divPixel_color.AutoSize = true;
            this.rB_divPixel_color.Location = new System.Drawing.Point(10, 34);
            this.rB_divPixel_color.Name = "rB_divPixel_color";
            this.rB_divPixel_color.Size = new System.Drawing.Size(47, 16);
            this.rB_divPixel_color.TabIndex = 2;
            this.rB_divPixel_color.TabStop = true;
            this.rB_divPixel_color.Text = "颜色";
            this.rB_divPixel_color.UseVisualStyleBackColor = true;
            this.rB_divPixel_color.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 1;
            this.label19.Text = "像素分离";
            // 
            // panel_clearback
            // 
            this.panel_clearback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_clearback.Controls.Add(this.txtBox_clearback_keepcolor);
            this.panel_clearback.Controls.Add(this.txtBox_clearback_keeplight);
            this.panel_clearback.Controls.Add(this.rB_clearback_keeplight);
            this.panel_clearback.Controls.Add(this.rB_clearback_keepcolor);
            this.panel_clearback.Controls.Add(this.label15);
            this.panel_clearback.Location = new System.Drawing.Point(705, 361);
            this.panel_clearback.Name = "panel_clearback";
            this.panel_clearback.Size = new System.Drawing.Size(201, 97);
            this.panel_clearback.TabIndex = 39;
            // 
            // txtBox_clearback_keepcolor
            // 
            this.txtBox_clearback_keepcolor.Location = new System.Drawing.Point(114, 33);
            this.txtBox_clearback_keepcolor.Name = "txtBox_clearback_keepcolor";
            this.txtBox_clearback_keepcolor.Size = new System.Drawing.Size(42, 21);
            this.txtBox_clearback_keepcolor.TabIndex = 13;
            this.txtBox_clearback_keepcolor.Text = "127";
            this.txtBox_clearback_keepcolor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_clearback_keepcolor.TextChanged += new System.EventHandler(this.config_Changed);
            // 
            // txtBox_clearback_keeplight
            // 
            this.txtBox_clearback_keeplight.Location = new System.Drawing.Point(114, 68);
            this.txtBox_clearback_keeplight.Name = "txtBox_clearback_keeplight";
            this.txtBox_clearback_keeplight.Size = new System.Drawing.Size(42, 21);
            this.txtBox_clearback_keeplight.TabIndex = 12;
            this.txtBox_clearback_keeplight.Text = "127";
            this.txtBox_clearback_keeplight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_clearback_keeplight.TextChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_clearback_keeplight
            // 
            this.rB_clearback_keeplight.AutoSize = true;
            this.rB_clearback_keeplight.Location = new System.Drawing.Point(9, 71);
            this.rB_clearback_keeplight.Name = "rB_clearback_keeplight";
            this.rB_clearback_keeplight.Size = new System.Drawing.Size(71, 16);
            this.rB_clearback_keeplight.TabIndex = 7;
            this.rB_clearback_keeplight.TabStop = true;
            this.rB_clearback_keeplight.Text = "保留亮度";
            this.rB_clearback_keeplight.UseVisualStyleBackColor = true;
            this.rB_clearback_keeplight.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // rB_clearback_keepcolor
            // 
            this.rB_clearback_keepcolor.AutoSize = true;
            this.rB_clearback_keepcolor.Location = new System.Drawing.Point(10, 34);
            this.rB_clearback_keepcolor.Name = "rB_clearback_keepcolor";
            this.rB_clearback_keepcolor.Size = new System.Drawing.Size(83, 16);
            this.rB_clearback_keepcolor.TabIndex = 2;
            this.rB_clearback_keepcolor.TabStop = true;
            this.rB_clearback_keepcolor.Text = "保留颜色数";
            this.rB_clearback_keepcolor.UseVisualStyleBackColor = true;
            this.rB_clearback_keepcolor.CheckedChanged += new System.EventHandler(this.config_Changed);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "清除背景";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(498, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 127);
            this.panel1.TabIndex = 40;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 71);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 16);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "对比度";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "亮度";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 1;
            this.label16.Text = "亮度对比度";
            // 
            // picBox_pre
            // 
            this.picBox_pre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_pre.Location = new System.Drawing.Point(576, 119);
            this.picBox_pre.Name = "picBox_pre";
            this.picBox_pre.Size = new System.Drawing.Size(233, 80);
            this.picBox_pre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_pre.TabIndex = 41;
            this.picBox_pre.TabStop = false;
            // 
            // panel_special
            // 
            this.panel_special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_special.Location = new System.Drawing.Point(498, 345);
            this.panel_special.Name = "panel_special";
            this.panel_special.Size = new System.Drawing.Size(190, 88);
            this.panel_special.TabIndex = 42;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(576, 204);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(233, 284);
            this.tabControl1.TabIndex = 43;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.panel_special);
            this.tabPage1.Controls.Add(this.panel_Clip);
            this.tabPage1.Controls.Add(this.panel_smoothing);
            this.tabPage1.Controls.Add(this.panel_filter);
            this.tabPage1.Controls.Add(this.panel_resize);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel_divPixel);
            this.tabPage1.Controls.Add(this.panel_clrpro);
            this.tabPage1.Controls.Add(this.panel_clearback);
            this.tabPage1.Controls.Add(this.panel_ngt);
            this.tabPage1.Controls.Add(this.panel_Binary);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(225, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "图片处理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.btn_clearNoise);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.picBox_small);
            this.tabPage2.Controls.Add(this.txtBox_MT);
            this.tabPage2.Controls.Add(this.btn_clearEdge);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(225, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "字模处理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_clearNoise
            // 
            this.btn_clearNoise.Location = new System.Drawing.Point(86, 11);
            this.btn_clearNoise.Name = "btn_clearNoise";
            this.btn_clearNoise.Size = new System.Drawing.Size(62, 38);
            this.btn_clearNoise.TabIndex = 54;
            this.btn_clearNoise.Text = "去除杂点";
            this.btn_clearNoise.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(166, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 38);
            this.button3.TabIndex = 55;
            this.button3.Text = "去除毛刺";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // picBox_small
            // 
            this.picBox_small.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_small.Location = new System.Drawing.Point(66, 59);
            this.picBox_small.Name = "picBox_small";
            this.picBox_small.Size = new System.Drawing.Size(100, 50);
            this.picBox_small.TabIndex = 48;
            this.picBox_small.TabStop = false;
            // 
            // txtBox_MT
            // 
            this.txtBox_MT.Location = new System.Drawing.Point(66, 115);
            this.txtBox_MT.Name = "txtBox_MT";
            this.txtBox_MT.Size = new System.Drawing.Size(100, 21);
            this.txtBox_MT.TabIndex = 49;
            // 
            // btn_clearEdge
            // 
            this.btn_clearEdge.Location = new System.Drawing.Point(6, 11);
            this.btn_clearEdge.Name = "btn_clearEdge";
            this.btn_clearEdge.Size = new System.Drawing.Size(62, 38);
            this.btn_clearEdge.TabIndex = 51;
            this.btn_clearEdge.Text = "去除白边";
            this.btn_clearEdge.UseVisualStyleBackColor = true;
            // 
            // listView_MT
            // 
            this.listView_MT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_MT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_MT.GridLines = true;
            this.listView_MT.Location = new System.Drawing.Point(12, 336);
            this.listView_MT.Name = "listView_MT";
            this.listView_MT.Size = new System.Drawing.Size(330, 152);
            this.listView_MT.TabIndex = 44;
            this.listView_MT.UseCompatibleStateImageBehavior = false;
            this.listView_MT.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "字符";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "特征码";
            this.columnHeader3.Width = 200;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(499, 312);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 50;
            this.btn_reset.Text = "重新载入";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // checkBox_splitHand
            // 
            this.checkBox_splitHand.AutoSize = true;
            this.checkBox_splitHand.Location = new System.Drawing.Point(96, 316);
            this.checkBox_splitHand.Name = "checkBox_splitHand";
            this.checkBox_splitHand.Size = new System.Drawing.Size(72, 16);
            this.checkBox_splitHand.TabIndex = 53;
            this.checkBox_splitHand.Text = "手动分割";
            this.checkBox_splitHand.UseVisualStyleBackColor = true;
            // 
            // checkBox_splitAuto
            // 
            this.checkBox_splitAuto.AutoSize = true;
            this.checkBox_splitAuto.Location = new System.Drawing.Point(12, 316);
            this.checkBox_splitAuto.Name = "checkBox_splitAuto";
            this.checkBox_splitAuto.Size = new System.Drawing.Size(72, 16);
            this.checkBox_splitAuto.TabIndex = 52;
            this.checkBox_splitAuto.Text = "自动分割";
            this.checkBox_splitAuto.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 54;
            this.button1.Text = "写出测试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(376, 411);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 55;
            this.button4.Text = "载入测试";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(135, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "取优";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn_bin_getmid_Click);
            // 
            // numericUpDown_ClearN
            // 
            this.numericUpDown_ClearN.Location = new System.Drawing.Point(87, 99);
            this.numericUpDown_ClearN.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_ClearN.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.numericUpDown_ClearN.Name = "numericUpDown_ClearN";
            this.numericUpDown_ClearN.Size = new System.Drawing.Size(36, 21);
            this.numericUpDown_ClearN.TabIndex = 18;
            this.numericUpDown_ClearN.ValueChanged += new System.EventHandler(this.config_Changed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 493);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox_splitHand);
            this.Controls.Add(this.checkBox_splitAuto);
            this.Controls.Add(this.listView_MT);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.picBox_pre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_serchPath);
            this.Controls.Add(this.picBox_show);
            this.Controls.Add(this.picBox_src);
            this.Controls.Add(this.btn_downloadPic);
            this.Controls.Add(this.txtBox_url);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TextChanged += new System.EventHandler(this.config_Changed);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_src)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_show)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel_Clip.ResumeLayout(false);
            this.panel_Clip.PerformLayout();
            this.panel_smoothing.ResumeLayout(false);
            this.panel_smoothing.PerformLayout();
            this.panel_clrpro.ResumeLayout(false);
            this.panel_clrpro.PerformLayout();
            this.panel_Binary.ResumeLayout(false);
            this.panel_Binary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel_ngt.ResumeLayout(false);
            this.panel_ngt.PerformLayout();
            this.panel_filter.ResumeLayout(false);
            this.panel_filter.PerformLayout();
            this.panel_resize.ResumeLayout(false);
            this.panel_resize.PerformLayout();
            this.panel_divPixel.ResumeLayout(false);
            this.panel_divPixel.PerformLayout();
            this.panel_clearback.ResumeLayout(false);
            this.panel_clearback.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_pre)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_small)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ClearN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_url;
        private System.Windows.Forms.Button btn_downloadPic;
        private System.Windows.Forms.PictureBox picBox_src;
        private System.Windows.Forms.PictureBox picBox_show;
        private System.Windows.Forms.Button btn_serchPath;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader param;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_Clip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Clip_right;
        private System.Windows.Forms.TextBox txtBox_Clip_down;
        private System.Windows.Forms.TextBox txtBox_Clip_left;
        private System.Windows.Forms.TextBox txtBox_Clip_up;
        private System.Windows.Forms.Panel panel_smoothing;
        private System.Windows.Forms.RadioButton rB_sm_mid7;
        private System.Windows.Forms.RadioButton rB_sm_ave7;
        private System.Windows.Forms.RadioButton rB_sm_ave5;
        private System.Windows.Forms.RadioButton rB_sm_mid5;
        private System.Windows.Forms.RadioButton rB_sm_ave3;
        private System.Windows.Forms.RadioButton rB_sm_mid3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_clrpro;
        private System.Windows.Forms.RadioButton rB_clrpro_blue;
        private System.Windows.Forms.RadioButton rB_clrpro_green;
        private System.Windows.Forms.RadioButton rB_clrpro_red;
        private System.Windows.Forms.RadioButton rB_clrpro_reversal;
        private System.Windows.Forms.RadioButton rB_clrpro_gray;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel_Binary;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtBox_Bin_threshold;
        private System.Windows.Forms.RadioButton rB__Binary_autoSub;
        private System.Windows.Forms.RadioButton rB__Binary_threshold;
        private System.Windows.Forms.RadioButton rB__Binary_allBlack;
        private System.Windows.Forms.RadioButton rB__Binary_自动阀值;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel_ngt;
        private System.Windows.Forms.RadioButton rB_ngt_thin;
        private System.Windows.Forms.RadioButton rB_ngt_CEdge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rB_ngt_erosion;
        private System.Windows.Forms.RadioButton rB_ngt_swell;
        private System.Windows.Forms.RadioButton rB_ngt_close;
        private System.Windows.Forms.RadioButton rB_ngt_open;
        private System.Windows.Forms.Panel panel_filter;
        private System.Windows.Forms.RadioButton rB_filter_neno;
        private System.Windows.Forms.RadioButton rB_filter_Embosment;
        private System.Windows.Forms.RadioButton rB_filter_soften;
        private System.Windows.Forms.RadioButton rB_filter_atom;
        private System.Windows.Forms.RadioButton rB_filter_sharpen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader check;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缩放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图像裁剪ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图像滤波ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 线性滤镜ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除背景ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 像素分离ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 颜色处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 二值化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 黑白图处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 亮度对比度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private System.Windows.Forms.RadioButton rB_Clip_Cut;
        private System.Windows.Forms.RadioButton rB_Clip_clrBlock;
        private System.Windows.Forms.RadioButton rB_ngt_cNoise;
        private System.Windows.Forms.Button btn_bin_getmid;
        private System.Windows.Forms.Panel panel_resize;
        private System.Windows.Forms.ComboBox comb_resize_height;
        private System.Windows.Forms.ComboBox comb_resize_width;
        private System.Windows.Forms.TextBox txtBox_resize_height;
        private System.Windows.Forms.TextBox txtBox_resize_width;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rB_resize_size;
        private System.Windows.Forms.RadioButton rB_resize_scale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_divPixel;
        private System.Windows.Forms.ComboBox comb_divPixel_light;
        private System.Windows.Forms.ComboBox comb_divPixel_color;
        private System.Windows.Forms.TextBox txtBox_divPixel_color;
        private System.Windows.Forms.TextBox txtBox_divPixel_light;
        private System.Windows.Forms.RadioButton rB_divPixel_light;
        private System.Windows.Forms.RadioButton rB_divPixel_color;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel_clearback;
        private System.Windows.Forms.TextBox txtBox_clearback_keepcolor;
        private System.Windows.Forms.TextBox txtBox_clearback_keeplight;
        private System.Windows.Forms.RadioButton rB_clearback_keeplight;
        private System.Windows.Forms.RadioButton rB_clearback_keepcolor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox picBox_pre;
        private System.Windows.Forms.ToolStripMenuItem 特殊处理ToolStripMenuItem;
        private System.Windows.Forms.Panel panel_special;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ToolStripMenuItem 上移ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下移ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView_MT;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txtBox_MT;
        private System.Windows.Forms.Button btn_clearNoise;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox picBox_small;
        private System.Windows.Forms.Button btn_clearEdge;
        private System.Windows.Forms.CheckBox checkBox_splitHand;
        private System.Windows.Forms.CheckBox checkBox_splitAuto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown numericUpDown_ClearN;
        private System.Windows.Forms.Button button5;
    }
}

