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
            this.txtBox_url = new System.Windows.Forms.TextBox();
            this.btn_downloadPic = new System.Windows.Forms.Button();
            this.picBox_src = new System.Windows.Forms.PictureBox();
            this.picBox_show = new System.Windows.Forms.PictureBox();
            this.btn_serchPath = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox_fangda = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button12 = new System.Windows.Forms.Button();
            this.txtBox_lvbo = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.txtBox_fillIndex = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_src)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_show)).BeginInit();
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
            this.btn_downloadPic.Location = new System.Drawing.Point(1202, 37);
            this.btn_downloadPic.Name = "btn_downloadPic";
            this.btn_downloadPic.Size = new System.Drawing.Size(96, 28);
            this.btn_downloadPic.TabIndex = 1;
            this.btn_downloadPic.Text = "下载图像";
            this.btn_downloadPic.UseVisualStyleBackColor = true;
            this.btn_downloadPic.Click += new System.EventHandler(this.btn_downloadPic_Click);
            // 
            // picBox_src
            // 
            this.picBox_src.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_src.Location = new System.Drawing.Point(560, 12);
            this.picBox_src.Name = "picBox_src";
            this.picBox_src.Size = new System.Drawing.Size(100, 50);
            this.picBox_src.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox_src.TabIndex = 2;
            this.picBox_src.TabStop = false;
            // 
            // picBox_show
            // 
            this.picBox_show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_show.Location = new System.Drawing.Point(12, 88);
            this.picBox_show.Name = "picBox_show";
            this.picBox_show.Size = new System.Drawing.Size(498, 295);
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
            this.button1.Location = new System.Drawing.Point(1148, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "灰度";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(873, 567);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(228, 230);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1318, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 21);
            this.textBox1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1126, 496);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "边框置背景【4参】";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1126, 541);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 39);
            this.button3.TabIndex = 9;
            this.button3.Text = "清理边框背景色";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1126, 586);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 40);
            this.button4.TabIndex = 10;
            this.button4.Text = "除杂点";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1126, 632);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 38);
            this.button5.TabIndex = 11;
            this.button5.Text = "二值化";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1282, 598);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(45, 21);
            this.textBox2.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1126, 713);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 30);
            this.button6.TabIndex = 13;
            this.button6.Text = "分割线";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1126, 676);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(138, 31);
            this.button7.TabIndex = 14;
            this.button7.Text = "反转";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1344, 597);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(51, 21);
            this.textBox3.TabIndex = 15;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1294, 713);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 29);
            this.button8.TabIndex = 16;
            this.button8.Text = "重置";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1284, 746);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 17;
            this.button9.Text = "放大";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox_fangda
            // 
            this.textBox_fangda.Location = new System.Drawing.Point(1374, 748);
            this.textBox_fangda.Name = "textBox_fangda";
            this.textBox_fangda.Size = new System.Drawing.Size(36, 21);
            this.textBox_fangda.TabIndex = 18;
            this.textBox_fangda.Text = "10";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1148, 420);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 19;
            this.button10.Text = "载入全部";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1126, 749);
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
            this.checkBox1.Location = new System.Drawing.Point(1023, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "手动分割";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(1284, 680);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(69, 23);
            this.button12.TabIndex = 22;
            this.button12.Text = "中值滤波";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // txtBox_lvbo
            // 
            this.txtBox_lvbo.Location = new System.Drawing.Point(1374, 665);
            this.txtBox_lvbo.Name = "txtBox_lvbo";
            this.txtBox_lvbo.Size = new System.Drawing.Size(39, 21);
            this.txtBox_lvbo.TabIndex = 23;
            this.txtBox_lvbo.Text = "3";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(1282, 651);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 24;
            this.button13.Text = "均值滤波";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(1284, 458);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(111, 46);
            this.button14.TabIndex = 25;
            this.button14.Text = "黑化";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(1278, 512);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 26;
            this.button15.Text = "填充";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // txtBox_fillIndex
            // 
            this.txtBox_fillIndex.Location = new System.Drawing.Point(1359, 514);
            this.txtBox_fillIndex.Name = "txtBox_fillIndex";
            this.txtBox_fillIndex.Size = new System.Drawing.Size(49, 21);
            this.txtBox_fillIndex.TabIndex = 27;
            this.txtBox_fillIndex.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 796);
            this.Controls.Add(this.txtBox_fillIndex);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.txtBox_lvbo);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.textBox_fangda);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox_fangda;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox txtBox_lvbo;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox txtBox_fillIndex;
    }
}

