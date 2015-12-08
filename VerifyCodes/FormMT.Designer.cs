namespace VerifyCodes
{
    partial class FormMT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBox_show = new System.Windows.Forms.PictureBox();
            this.btn_clearEdge = new System.Windows.Forms.Button();
            this.picBox_small = new System.Windows.Forms.PictureBox();
            this.txtBox_MT = new System.Windows.Forms.TextBox();
            this.listView_MT = new System.Windows.Forms.ListView();
            this.checkBox_splitAuto = new System.Windows.Forms.CheckBox();
            this.checkBox_splitHand = new System.Windows.Forms.CheckBox();
            this.btn_clearNoise = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_small)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_show
            // 
            this.picBox_show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_show.Location = new System.Drawing.Point(12, 71);
            this.picBox_show.Name = "picBox_show";
            this.picBox_show.Size = new System.Drawing.Size(600, 236);
            this.picBox_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox_show.TabIndex = 0;
            this.picBox_show.TabStop = false;
            // 
            // btn_clearEdge
            // 
            this.btn_clearEdge.Location = new System.Drawing.Point(361, 19);
            this.btn_clearEdge.Name = "btn_clearEdge";
            this.btn_clearEdge.Size = new System.Drawing.Size(75, 23);
            this.btn_clearEdge.TabIndex = 1;
            this.btn_clearEdge.Text = "去除白边";
            this.btn_clearEdge.UseVisualStyleBackColor = true;
            // 
            // picBox_small
            // 
            this.picBox_small.Location = new System.Drawing.Point(630, 122);
            this.picBox_small.Name = "picBox_small";
            this.picBox_small.Size = new System.Drawing.Size(100, 50);
            this.picBox_small.TabIndex = 2;
            this.picBox_small.TabStop = false;
            // 
            // txtBox_MT
            // 
            this.txtBox_MT.Location = new System.Drawing.Point(630, 178);
            this.txtBox_MT.Name = "txtBox_MT";
            this.txtBox_MT.Size = new System.Drawing.Size(100, 21);
            this.txtBox_MT.TabIndex = 3;
            // 
            // listView_MT
            // 
            this.listView_MT.Location = new System.Drawing.Point(12, 324);
            this.listView_MT.Name = "listView_MT";
            this.listView_MT.Size = new System.Drawing.Size(600, 270);
            this.listView_MT.TabIndex = 4;
            this.listView_MT.UseCompatibleStateImageBehavior = false;
            // 
            // checkBox_splitAuto
            // 
            this.checkBox_splitAuto.AutoSize = true;
            this.checkBox_splitAuto.Location = new System.Drawing.Point(57, 26);
            this.checkBox_splitAuto.Name = "checkBox_splitAuto";
            this.checkBox_splitAuto.Size = new System.Drawing.Size(72, 16);
            this.checkBox_splitAuto.TabIndex = 5;
            this.checkBox_splitAuto.Text = "自动分割";
            this.checkBox_splitAuto.UseVisualStyleBackColor = true;
            // 
            // checkBox_splitHand
            // 
            this.checkBox_splitHand.AutoSize = true;
            this.checkBox_splitHand.Location = new System.Drawing.Point(141, 26);
            this.checkBox_splitHand.Name = "checkBox_splitHand";
            this.checkBox_splitHand.Size = new System.Drawing.Size(72, 16);
            this.checkBox_splitHand.TabIndex = 6;
            this.checkBox_splitHand.Text = "手动分割";
            this.checkBox_splitHand.UseVisualStyleBackColor = true;
            // 
            // btn_clearNoise
            // 
            this.btn_clearNoise.Location = new System.Drawing.Point(442, 19);
            this.btn_clearNoise.Name = "btn_clearNoise";
            this.btn_clearNoise.Size = new System.Drawing.Size(75, 23);
            this.btn_clearNoise.TabIndex = 7;
            this.btn_clearNoise.Text = "去除杂点";
            this.btn_clearNoise.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(523, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "去除毛刺";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(644, 84);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "重新载入";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // FormMT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 606);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_clearNoise);
            this.Controls.Add(this.checkBox_splitHand);
            this.Controls.Add(this.checkBox_splitAuto);
            this.Controls.Add(this.listView_MT);
            this.Controls.Add(this.txtBox_MT);
            this.Controls.Add(this.picBox_small);
            this.Controls.Add(this.btn_clearEdge);
            this.Controls.Add(this.picBox_show);
            this.Name = "FormMT";
            this.Text = "FormMT";
            this.Load += new System.EventHandler(this.FormMT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_small)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_show;
        private System.Windows.Forms.Button btn_clearEdge;
        private System.Windows.Forms.PictureBox picBox_small;
        private System.Windows.Forms.TextBox txtBox_MT;
        private System.Windows.Forms.ListView listView_MT;
        private System.Windows.Forms.CheckBox checkBox_splitAuto;
        private System.Windows.Forms.CheckBox checkBox_splitHand;
        private System.Windows.Forms.Button btn_clearNoise;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_reset;
    }
}