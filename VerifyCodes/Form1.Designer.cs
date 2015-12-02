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
            this.button1 = new System.Windows.Forms.Button();
            this.picBox_src = new System.Windows.Forms.PictureBox();
            this.picBox_show = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_src)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_show)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_url
            // 
            this.txtBox_url.Location = new System.Drawing.Point(12, 42);
            this.txtBox_url.Name = "txtBox_url";
            this.txtBox_url.Size = new System.Drawing.Size(498, 21);
            this.txtBox_url.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "下载图像";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // picBox_src
            // 
            this.picBox_src.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_src.Location = new System.Drawing.Point(653, 15);
            this.picBox_src.Name = "picBox_src";
            this.picBox_src.Size = new System.Drawing.Size(100, 50);
            this.picBox_src.TabIndex = 2;
            this.picBox_src.TabStop = false;
            // 
            // picBox_show
            // 
            this.picBox_show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_show.Location = new System.Drawing.Point(12, 88);
            this.picBox_show.Name = "picBox_show";
            this.picBox_show.Size = new System.Drawing.Size(498, 295);
            this.picBox_show.TabIndex = 3;
            this.picBox_show.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 401);
            this.Controls.Add(this.picBox_show);
            this.Controls.Add(this.picBox_src);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picBox_src;
        private System.Windows.Forms.PictureBox picBox_show;
    }
}

