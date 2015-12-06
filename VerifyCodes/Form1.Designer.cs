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
            this.button1 = new System.Windows.Forms.Button();
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
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox_fangda = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.txtBox_fillIndex = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.panel_Clip = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Clip_right = new System.Windows.Forms.TextBox();
            this.txtBox_Clip_down = new System.Windows.Forms.TextBox();
            this.txtBox_Clip_left = new System.Windows.Forms.TextBox();
            this.txtBox_Clip_up = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtBox_Bin_threshold = new System.Windows.Forms.TextBox();
            this.rB__Binary_autoSub = new System.Windows.Forms.RadioButton();
            this.rB__Binary_threshold = new System.Windows.Forms.RadioButton();
            this.rB__Binary_allBlack = new System.Windows.Forms.RadioButton();
            this.rB__Binary_自动阀值 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_ngt = new System.Windows.Forms.Panel();
            this.rB_ngt_close = new System.Windows.Forms.RadioButton();
            this.rB_ngt_open = new System.Windows.Forms.RadioButton();
            this.rB_ngt_swell = new System.Windows.Forms.RadioButton();
            this.rB_ngt_erosion = new System.Windows.Forms.RadioButton();
            this.rB_ngt_thin = new System.Windows.Forms.RadioButton();
            this.rB_ngt_CEdge = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.panel_filter = new System.Windows.Forms.Panel();
            this.rB_filter_neno = new System.Windows.Forms.RadioButton();
            this.rB_filter_Embosment = new System.Windows.Forms.RadioButton();
            this.rB_filter_soften = new System.Windows.Forms.RadioButton();
            this.rB_filter_atom = new System.Windows.Forms.RadioButton();
            this.rB_filter_sharpen = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.rB_Clip_Cut = new System.Windows.Forms.RadioButton();
            this.rB_Clip_clrBlock = new System.Windows.Forms.RadioButton();
            this.rB_ngt_cNoise = new System.Windows.Forms.RadioButton();
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
            this.btn_downloadPic.Location = new System.Drawing.Point(560, 30);
            this.btn_downloadPic.Name = "btn_downloadPic";
            this.btn_downloadPic.Size = new System.Drawing.Size(96, 28);
            this.btn_downloadPic.TabIndex = 1;
            this.btn_downloadPic.Text = "下张图像";
            this.btn_downloadPic.UseVisualStyleBackColor = true;
            this.btn_downloadPic.Click += new System.EventHandler(this.btn_downloadPic_Click);
            // 
            // picBox_src
            // 
            this.picBox_src.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_src.Location = new System.Drawing.Point(680, 12);
            this.picBox_src.Name = "picBox_src";
            this.picBox_src.Size = new System.Drawing.Size(100, 50);
            this.picBox_src.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox_src.TabIndex = 2;
            this.picBox_src.TabStop = false;
            // 
            // picBox_show
            // 
            this.picBox_show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_show.Location = new System.Drawing.Point(27, 68);
            this.picBox_show.Name = "picBox_show";
            this.picBox_show.Size = new System.Drawing.Size(744, 323);
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
            this.btn_serchPath.Location = new System.Drawing.Point(435, 35);
            this.btn_serchPath.Name = "btn_serchPath";
            this.btn_serchPath.Size = new System.Drawing.Size(101, 23);
            this.btn_serchPath.TabIndex = 4;
            this.btn_serchPath.Text = "浏览目录";
            this.btn_serchPath.UseVisualStyleBackColor = true;
            this.btn_serchPath.Click += new System.EventHandler(this.btn_serchPath_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(861, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "灰度";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.check,
            this.name,
            this.param});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(784, 71);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(228, 230);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.删除ToolStripMenuItem,
            this.清空ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
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
            this.亮度对比度ToolStripMenuItem});
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.添加ToolStripMenuItem.Text = "添加";
            // 
            // 缩放ToolStripMenuItem
            // 
            this.缩放ToolStripMenuItem.Name = "缩放ToolStripMenuItem";
            this.缩放ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.缩放ToolStripMenuItem.Text = "图像缩放";
            this.缩放ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 图像裁剪ToolStripMenuItem
            // 
            this.图像裁剪ToolStripMenuItem.Name = "图像裁剪ToolStripMenuItem";
            this.图像裁剪ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.图像裁剪ToolStripMenuItem.Text = "图像裁剪";
            this.图像裁剪ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 图像滤波ToolStripMenuItem
            // 
            this.图像滤波ToolStripMenuItem.Name = "图像滤波ToolStripMenuItem";
            this.图像滤波ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.图像滤波ToolStripMenuItem.Text = "图像滤波";
            this.图像滤波ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 线性滤镜ToolStripMenuItem
            // 
            this.线性滤镜ToolStripMenuItem.Name = "线性滤镜ToolStripMenuItem";
            this.线性滤镜ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.线性滤镜ToolStripMenuItem.Text = "线性滤镜";
            this.线性滤镜ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 清除背景ToolStripMenuItem
            // 
            this.清除背景ToolStripMenuItem.Name = "清除背景ToolStripMenuItem";
            this.清除背景ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.清除背景ToolStripMenuItem.Text = "清除背景";
            this.清除背景ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 像素分离ToolStripMenuItem
            // 
            this.像素分离ToolStripMenuItem.Name = "像素分离ToolStripMenuItem";
            this.像素分离ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.像素分离ToolStripMenuItem.Text = "像素分离";
            this.像素分离ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 颜色处理ToolStripMenuItem
            // 
            this.颜色处理ToolStripMenuItem.Name = "颜色处理ToolStripMenuItem";
            this.颜色处理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.颜色处理ToolStripMenuItem.Text = "颜色处理";
            this.颜色处理ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 二值化ToolStripMenuItem
            // 
            this.二值化ToolStripMenuItem.Name = "二值化ToolStripMenuItem";
            this.二值化ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.二值化ToolStripMenuItem.Text = "二值化";
            this.二值化ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 黑白图处理ToolStripMenuItem
            // 
            this.黑白图处理ToolStripMenuItem.Name = "黑白图处理ToolStripMenuItem";
            this.黑白图处理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.黑白图处理ToolStripMenuItem.Text = "黑白图处理";
            this.黑白图处理ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 亮度对比度ToolStripMenuItem
            // 
            this.亮度对比度ToolStripMenuItem.Name = "亮度对比度ToolStripMenuItem";
            this.亮度对比度ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.亮度对比度ToolStripMenuItem.Text = "亮度对比度";
            this.亮度对比度ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.清空ToolStripMenuItem.Text = "清空";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1246, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 21);
            this.textBox1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(815, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "边框置背景【4参】";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(398, 478);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 40);
            this.button4.TabIndex = 10;
            this.button4.Text = "除杂点";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(913, 498);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 27);
            this.button5.TabIndex = 11;
            this.button5.Text = "二值化";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(548, 498);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(45, 21);
            this.textBox2.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(714, 507);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 30);
            this.button6.TabIndex = 13;
            this.button6.Text = "分割线";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(610, 497);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(51, 21);
            this.textBox3.TabIndex = 15;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(578, 544);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 29);
            this.button8.TabIndex = 16;
            this.button8.Text = "重置";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(568, 577);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 17;
            this.button9.Text = "放大";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox_fangda
            // 
            this.textBox_fangda.Location = new System.Drawing.Point(653, 580);
            this.textBox_fangda.Name = "textBox_fangda";
            this.textBox_fangda.Size = new System.Drawing.Size(36, 21);
            this.textBox_fangda.TabIndex = 18;
            this.textBox_fangda.Text = "10";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(972, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 19;
            this.button10.Text = "载入全部";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(410, 580);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(138, 23);
            this.button11.TabIndex = 20;
            this.button11.Text = "当前特征码";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1166, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "手动分割";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(874, 548);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 24;
            this.button13.Text = "均值滤波";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(714, 548);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 26;
            this.button15.Text = "填充";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // txtBox_fillIndex
            // 
            this.txtBox_fillIndex.Location = new System.Drawing.Point(795, 550);
            this.txtBox_fillIndex.Name = "txtBox_fillIndex";
            this.txtBox_fillIndex.Size = new System.Drawing.Size(49, 21);
            this.txtBox_fillIndex.TabIndex = 27;
            this.txtBox_fillIndex.Text = "0";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(731, 580);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 28;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
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
            this.panel_Clip.Controls.Add(this.label1);
            this.panel_Clip.Location = new System.Drawing.Point(1188, 48);
            this.panel_Clip.Name = "panel_Clip";
            this.panel_Clip.Size = new System.Drawing.Size(201, 138);
            this.panel_Clip.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "左：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "下：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "右：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "上:";
            // 
            // txtBox_Clip_right
            // 
            this.txtBox_Clip_right.Location = new System.Drawing.Point(147, 85);
            this.txtBox_Clip_right.Name = "txtBox_Clip_right";
            this.txtBox_Clip_right.Size = new System.Drawing.Size(32, 21);
            this.txtBox_Clip_right.TabIndex = 4;
            // 
            // txtBox_Clip_down
            // 
            this.txtBox_Clip_down.Location = new System.Drawing.Point(104, 111);
            this.txtBox_Clip_down.Name = "txtBox_Clip_down";
            this.txtBox_Clip_down.Size = new System.Drawing.Size(27, 21);
            this.txtBox_Clip_down.TabIndex = 3;
            // 
            // txtBox_Clip_left
            // 
            this.txtBox_Clip_left.Location = new System.Drawing.Point(63, 85);
            this.txtBox_Clip_left.Name = "txtBox_Clip_left";
            this.txtBox_Clip_left.Size = new System.Drawing.Size(29, 21);
            this.txtBox_Clip_left.TabIndex = 2;
            // 
            // txtBox_Clip_up
            // 
            this.txtBox_Clip_up.Location = new System.Drawing.Point(104, 58);
            this.txtBox_Clip_up.Name = "txtBox_Clip_up";
            this.txtBox_Clip_up.Size = new System.Drawing.Size(27, 21);
            this.txtBox_Clip_up.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "裁剪";
            // 
            // panel_smoothing
            // 
            this.panel_smoothing.Controls.Add(this.rB_sm_mid7);
            this.panel_smoothing.Controls.Add(this.rB_sm_ave7);
            this.panel_smoothing.Controls.Add(this.rB_sm_ave5);
            this.panel_smoothing.Controls.Add(this.rB_sm_mid5);
            this.panel_smoothing.Controls.Add(this.rB_sm_ave3);
            this.panel_smoothing.Controls.Add(this.rB_sm_mid3);
            this.panel_smoothing.Controls.Add(this.label6);
            this.panel_smoothing.Location = new System.Drawing.Point(1416, 50);
            this.panel_smoothing.Name = "panel_smoothing";
            this.panel_smoothing.Size = new System.Drawing.Size(208, 136);
            this.panel_smoothing.TabIndex = 30;
            // 
            // rB_sm_mid7
            // 
            this.rB_sm_mid7.AutoSize = true;
            this.rB_sm_mid7.Location = new System.Drawing.Point(15, 106);
            this.rB_sm_mid7.Name = "rB_sm_mid7";
            this.rB_sm_mid7.Size = new System.Drawing.Size(95, 16);
            this.rB_sm_mid7.TabIndex = 7;
            this.rB_sm_mid7.TabStop = true;
            this.rB_sm_mid7.Text = "7*7 中值滤波";
            this.rB_sm_mid7.UseVisualStyleBackColor = true;
            // 
            // rB_sm_ave7
            // 
            this.rB_sm_ave7.AutoSize = true;
            this.rB_sm_ave7.Location = new System.Drawing.Point(113, 106);
            this.rB_sm_ave7.Name = "rB_sm_ave7";
            this.rB_sm_ave7.Size = new System.Drawing.Size(95, 16);
            this.rB_sm_ave7.TabIndex = 6;
            this.rB_sm_ave7.TabStop = true;
            this.rB_sm_ave7.Text = "7*7 均值滤波";
            this.rB_sm_ave7.UseVisualStyleBackColor = true;
            // 
            // rB_sm_ave5
            // 
            this.rB_sm_ave5.AutoSize = true;
            this.rB_sm_ave5.Location = new System.Drawing.Point(113, 71);
            this.rB_sm_ave5.Name = "rB_sm_ave5";
            this.rB_sm_ave5.Size = new System.Drawing.Size(95, 16);
            this.rB_sm_ave5.TabIndex = 5;
            this.rB_sm_ave5.TabStop = true;
            this.rB_sm_ave5.Text = "5*5 均值滤波";
            this.rB_sm_ave5.UseVisualStyleBackColor = true;
            // 
            // rB_sm_mid5
            // 
            this.rB_sm_mid5.AutoSize = true;
            this.rB_sm_mid5.Location = new System.Drawing.Point(15, 71);
            this.rB_sm_mid5.Name = "rB_sm_mid5";
            this.rB_sm_mid5.Size = new System.Drawing.Size(95, 16);
            this.rB_sm_mid5.TabIndex = 4;
            this.rB_sm_mid5.TabStop = true;
            this.rB_sm_mid5.Text = "5*5 中值滤波";
            this.rB_sm_mid5.UseVisualStyleBackColor = true;
            // 
            // rB_sm_ave3
            // 
            this.rB_sm_ave3.AutoSize = true;
            this.rB_sm_ave3.Location = new System.Drawing.Point(113, 35);
            this.rB_sm_ave3.Name = "rB_sm_ave3";
            this.rB_sm_ave3.Size = new System.Drawing.Size(95, 16);
            this.rB_sm_ave3.TabIndex = 3;
            this.rB_sm_ave3.TabStop = true;
            this.rB_sm_ave3.Text = "3*3 均值滤波";
            this.rB_sm_ave3.UseVisualStyleBackColor = true;
            // 
            // rB_sm_mid3
            // 
            this.rB_sm_mid3.AutoSize = true;
            this.rB_sm_mid3.Location = new System.Drawing.Point(15, 35);
            this.rB_sm_mid3.Name = "rB_sm_mid3";
            this.rB_sm_mid3.Size = new System.Drawing.Size(95, 16);
            this.rB_sm_mid3.TabIndex = 2;
            this.rB_sm_mid3.TabStop = true;
            this.rB_sm_mid3.Text = "3*3 中值滤波";
            this.rB_sm_mid3.UseVisualStyleBackColor = true;
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
            this.panel_clrpro.Controls.Add(this.rB_clrpro_blue);
            this.panel_clrpro.Controls.Add(this.rB_clrpro_green);
            this.panel_clrpro.Controls.Add(this.rB_clrpro_red);
            this.panel_clrpro.Controls.Add(this.rB_clrpro_reversal);
            this.panel_clrpro.Controls.Add(this.rB_clrpro_gray);
            this.panel_clrpro.Controls.Add(this.label7);
            this.panel_clrpro.Location = new System.Drawing.Point(1188, 192);
            this.panel_clrpro.Name = "panel_clrpro";
            this.panel_clrpro.Size = new System.Drawing.Size(208, 135);
            this.panel_clrpro.TabIndex = 31;
            // 
            // rB_clrpro_blue
            // 
            this.rB_clrpro_blue.AutoSize = true;
            this.rB_clrpro_blue.Location = new System.Drawing.Point(29, 107);
            this.rB_clrpro_blue.Name = "rB_clrpro_blue";
            this.rB_clrpro_blue.Size = new System.Drawing.Size(47, 16);
            this.rB_clrpro_blue.TabIndex = 7;
            this.rB_clrpro_blue.TabStop = true;
            this.rB_clrpro_blue.Text = "单蓝";
            this.rB_clrpro_blue.UseVisualStyleBackColor = true;
            // 
            // rB_clrpro_green
            // 
            this.rB_clrpro_green.AutoSize = true;
            this.rB_clrpro_green.Location = new System.Drawing.Point(137, 72);
            this.rB_clrpro_green.Name = "rB_clrpro_green";
            this.rB_clrpro_green.Size = new System.Drawing.Size(47, 16);
            this.rB_clrpro_green.TabIndex = 5;
            this.rB_clrpro_green.TabStop = true;
            this.rB_clrpro_green.Text = "单绿";
            this.rB_clrpro_green.UseVisualStyleBackColor = true;
            // 
            // rB_clrpro_red
            // 
            this.rB_clrpro_red.AutoSize = true;
            this.rB_clrpro_red.Location = new System.Drawing.Point(29, 72);
            this.rB_clrpro_red.Name = "rB_clrpro_red";
            this.rB_clrpro_red.Size = new System.Drawing.Size(47, 16);
            this.rB_clrpro_red.TabIndex = 4;
            this.rB_clrpro_red.TabStop = true;
            this.rB_clrpro_red.Text = "单红";
            this.rB_clrpro_red.UseVisualStyleBackColor = true;
            // 
            // rB_clrpro_reversal
            // 
            this.rB_clrpro_reversal.AutoSize = true;
            this.rB_clrpro_reversal.Location = new System.Drawing.Point(137, 36);
            this.rB_clrpro_reversal.Name = "rB_clrpro_reversal";
            this.rB_clrpro_reversal.Size = new System.Drawing.Size(47, 16);
            this.rB_clrpro_reversal.TabIndex = 3;
            this.rB_clrpro_reversal.TabStop = true;
            this.rB_clrpro_reversal.Text = "反转";
            this.rB_clrpro_reversal.UseVisualStyleBackColor = true;
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
            this.panel_Binary.Controls.Add(this.numericUpDown1);
            this.panel_Binary.Controls.Add(this.txtBox_Bin_threshold);
            this.panel_Binary.Controls.Add(this.rB__Binary_autoSub);
            this.panel_Binary.Controls.Add(this.rB__Binary_threshold);
            this.panel_Binary.Controls.Add(this.rB__Binary_allBlack);
            this.panel_Binary.Controls.Add(this.rB__Binary_自动阀值);
            this.panel_Binary.Controls.Add(this.label8);
            this.panel_Binary.Location = new System.Drawing.Point(1416, 333);
            this.panel_Binary.Name = "panel_Binary";
            this.panel_Binary.Size = new System.Drawing.Size(208, 129);
            this.panel_Binary.TabIndex = 32;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(100, 94);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 21);
            this.numericUpDown1.TabIndex = 10;
            // 
            // txtBox_Bin_threshold
            // 
            this.txtBox_Bin_threshold.Location = new System.Drawing.Point(100, 63);
            this.txtBox_Bin_threshold.Name = "txtBox_Bin_threshold";
            this.txtBox_Bin_threshold.Size = new System.Drawing.Size(45, 21);
            this.txtBox_Bin_threshold.TabIndex = 8;
            // 
            // rB__Binary_autoSub
            // 
            this.rB__Binary_autoSub.AutoSize = true;
            this.rB__Binary_autoSub.Location = new System.Drawing.Point(16, 99);
            this.rB__Binary_autoSub.Name = "rB__Binary_autoSub";
            this.rB__Binary_autoSub.Size = new System.Drawing.Size(71, 16);
            this.rB__Binary_autoSub.TabIndex = 5;
            this.rB__Binary_autoSub.TabStop = true;
            this.rB__Binary_autoSub.Text = "自动差值";
            this.rB__Binary_autoSub.UseVisualStyleBackColor = true;
            // 
            // rB__Binary_threshold
            // 
            this.rB__Binary_threshold.AutoSize = true;
            this.rB__Binary_threshold.Location = new System.Drawing.Point(15, 68);
            this.rB__Binary_threshold.Name = "rB__Binary_threshold";
            this.rB__Binary_threshold.Size = new System.Drawing.Size(71, 16);
            this.rB__Binary_threshold.TabIndex = 4;
            this.rB__Binary_threshold.TabStop = true;
            this.rB__Binary_threshold.Text = "指定阀值";
            this.rB__Binary_threshold.UseVisualStyleBackColor = true;
            // 
            // rB__Binary_allBlack
            // 
            this.rB__Binary_allBlack.AutoSize = true;
            this.rB__Binary_allBlack.Location = new System.Drawing.Point(120, 41);
            this.rB__Binary_allBlack.Name = "rB__Binary_allBlack";
            this.rB__Binary_allBlack.Size = new System.Drawing.Size(71, 16);
            this.rB__Binary_allBlack.TabIndex = 3;
            this.rB__Binary_allBlack.TabStop = true;
            this.rB__Binary_allBlack.Text = "非白转黑";
            this.rB__Binary_allBlack.UseVisualStyleBackColor = true;
            // 
            // rB__Binary_自动阀值
            // 
            this.rB__Binary_自动阀值.AutoSize = true;
            this.rB__Binary_自动阀值.Location = new System.Drawing.Point(12, 41);
            this.rB__Binary_自动阀值.Name = "rB__Binary_自动阀值";
            this.rB__Binary_自动阀值.Size = new System.Drawing.Size(71, 16);
            this.rB__Binary_自动阀值.TabIndex = 2;
            this.rB__Binary_自动阀值.TabStop = true;
            this.rB__Binary_自动阀值.Text = "自动阀值";
            this.rB__Binary_自动阀值.UseVisualStyleBackColor = true;
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
            this.panel_ngt.Controls.Add(this.rB_ngt_cNoise);
            this.panel_ngt.Controls.Add(this.rB_ngt_close);
            this.panel_ngt.Controls.Add(this.rB_ngt_open);
            this.panel_ngt.Controls.Add(this.rB_ngt_swell);
            this.panel_ngt.Controls.Add(this.rB_ngt_erosion);
            this.panel_ngt.Controls.Add(this.rB_ngt_thin);
            this.panel_ngt.Controls.Add(this.rB_ngt_CEdge);
            this.panel_ngt.Controls.Add(this.label9);
            this.panel_ngt.Location = new System.Drawing.Point(1188, 333);
            this.panel_ngt.Name = "panel_ngt";
            this.panel_ngt.Size = new System.Drawing.Size(208, 129);
            this.panel_ngt.TabIndex = 33;
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
            // 
            // rB_ngt_thin
            // 
            this.rB_ngt_thin.AutoSize = true;
            this.rB_ngt_thin.Location = new System.Drawing.Point(10, 99);
            this.rB_ngt_thin.Name = "rB_ngt_thin";
            this.rB_ngt_thin.Size = new System.Drawing.Size(47, 16);
            this.rB_ngt_thin.TabIndex = 3;
            this.rB_ngt_thin.TabStop = true;
            this.rB_ngt_thin.Text = "骨架";
            this.rB_ngt_thin.UseVisualStyleBackColor = true;
            // 
            // rB_ngt_CEdge
            // 
            this.rB_ngt_CEdge.AutoSize = true;
            this.rB_ngt_CEdge.Location = new System.Drawing.Point(10, 41);
            this.rB_ngt_CEdge.Name = "rB_ngt_CEdge";
            this.rB_ngt_CEdge.Size = new System.Drawing.Size(71, 16);
            this.rB_ngt_CEdge.TabIndex = 2;
            this.rB_ngt_CEdge.TabStop = true;
            this.rB_ngt_CEdge.Text = "清理白框";
            this.rB_ngt_CEdge.UseVisualStyleBackColor = true;
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
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(410, 544);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 27);
            this.button7.TabIndex = 34;
            this.button7.Text = "黑白图处理";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel_filter
            // 
            this.panel_filter.Controls.Add(this.rB_filter_neno);
            this.panel_filter.Controls.Add(this.rB_filter_Embosment);
            this.panel_filter.Controls.Add(this.rB_filter_soften);
            this.panel_filter.Controls.Add(this.rB_filter_atom);
            this.panel_filter.Controls.Add(this.rB_filter_sharpen);
            this.panel_filter.Controls.Add(this.label10);
            this.panel_filter.Location = new System.Drawing.Point(1416, 192);
            this.panel_filter.Name = "panel_filter";
            this.panel_filter.Size = new System.Drawing.Size(208, 135);
            this.panel_filter.TabIndex = 36;
            // 
            // rB_filter_neno
            // 
            this.rB_filter_neno.AutoSize = true;
            this.rB_filter_neno.Location = new System.Drawing.Point(84, 36);
            this.rB_filter_neno.Name = "rB_filter_neno";
            this.rB_filter_neno.Size = new System.Drawing.Size(47, 16);
            this.rB_filter_neno.TabIndex = 7;
            this.rB_filter_neno.TabStop = true;
            this.rB_filter_neno.Text = "霓虹";
            this.rB_filter_neno.UseVisualStyleBackColor = true;
            // 
            // rB_filter_Embosment
            // 
            this.rB_filter_Embosment.AutoSize = true;
            this.rB_filter_Embosment.Location = new System.Drawing.Point(84, 72);
            this.rB_filter_Embosment.Name = "rB_filter_Embosment";
            this.rB_filter_Embosment.Size = new System.Drawing.Size(47, 16);
            this.rB_filter_Embosment.TabIndex = 5;
            this.rB_filter_Embosment.TabStop = true;
            this.rB_filter_Embosment.Text = "浮雕";
            this.rB_filter_Embosment.UseVisualStyleBackColor = true;
            // 
            // rB_filter_soften
            // 
            this.rB_filter_soften.AutoSize = true;
            this.rB_filter_soften.Location = new System.Drawing.Point(29, 72);
            this.rB_filter_soften.Name = "rB_filter_soften";
            this.rB_filter_soften.Size = new System.Drawing.Size(47, 16);
            this.rB_filter_soften.TabIndex = 4;
            this.rB_filter_soften.TabStop = true;
            this.rB_filter_soften.Text = "柔化";
            this.rB_filter_soften.UseVisualStyleBackColor = true;
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
            // 
            // rB_filter_sharpen
            // 
            this.rB_filter_sharpen.AutoSize = true;
            this.rB_filter_sharpen.Location = new System.Drawing.Point(29, 36);
            this.rB_filter_sharpen.Name = "rB_filter_sharpen";
            this.rB_filter_sharpen.Size = new System.Drawing.Size(47, 16);
            this.rB_filter_sharpen.TabIndex = 2;
            this.rB_filter_sharpen.TabStop = true;
            this.rB_filter_sharpen.Text = "锐化";
            this.rB_filter_sharpen.UseVisualStyleBackColor = true;
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(915, 459);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 32);
            this.button3.TabIndex = 35;
            this.button3.Text = "滤镜";
            this.button3.UseVisualStyleBackColor = true;
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
            // 
            // rB_ngt_cNoise
            // 
            this.rB_ngt_cNoise.AutoSize = true;
            this.rB_ngt_cNoise.Location = new System.Drawing.Point(10, 72);
            this.rB_ngt_cNoise.Name = "rB_ngt_cNoise";
            this.rB_ngt_cNoise.Size = new System.Drawing.Size(71, 16);
            this.rB_ngt_cNoise.TabIndex = 15;
            this.rB_ngt_cNoise.TabStop = true;
            this.rB_ngt_cNoise.Text = "去除杂点";
            this.rB_ngt_cNoise.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1745, 705);
            this.Controls.Add(this.panel_filter);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel_ngt);
            this.Controls.Add(this.panel_Binary);
            this.Controls.Add(this.panel_clrpro);
            this.Controls.Add(this.panel_smoothing);
            this.Controls.Add(this.panel_Clip);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.txtBox_fillIndex);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.textBox_fangda);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_serchPath);
            this.Controls.Add(this.picBox_show);
            this.Controls.Add(this.picBox_src);
            this.Controls.Add(this.btn_downloadPic);
            this.Controls.Add(this.txtBox_url);
            this.Name = "Form1";
            this.Text = "Form1";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_url;
        private System.Windows.Forms.Button btn_downloadPic;
        private System.Windows.Forms.PictureBox picBox_src;
        private System.Windows.Forms.PictureBox picBox_show;
        private System.Windows.Forms.Button btn_serchPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader param;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox_fangda;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox txtBox_fillIndex;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Panel panel_Clip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Clip_right;
        private System.Windows.Forms.TextBox txtBox_Clip_down;
        private System.Windows.Forms.TextBox txtBox_Clip_left;
        private System.Windows.Forms.TextBox txtBox_Clip_up;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button button7;
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
        private System.Windows.Forms.Button button3;
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
    }
}

