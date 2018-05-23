namespace 彩色连珠
{
    partial class weiboShare
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
            this.label1 = new System.Windows.Forms.Label();
            this.WbTxtBox = new System.Windows.Forms.TextBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.Canelbutton = new System.Windows.Forms.Button();
            this.PictureChecked = new System.Windows.Forms.CheckBox();
            this.pictureShareBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShareBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "发布到新浪微博：";
            // 
            // WbTxtBox
            // 
            this.WbTxtBox.Location = new System.Drawing.Point(12, 66);
            this.WbTxtBox.Multiline = true;
            this.WbTxtBox.Name = "WbTxtBox";
            this.WbTxtBox.Size = new System.Drawing.Size(534, 135);
            this.WbTxtBox.TabIndex = 2;
            this.WbTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Loginbutton
            // 
            this.Loginbutton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Loginbutton.Location = new System.Drawing.Point(358, 257);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(99, 36);
            this.Loginbutton.TabIndex = 3;
            this.Loginbutton.Text = "登陆并授权";
            this.Loginbutton.UseVisualStyleBackColor = true;
            // 
            // Canelbutton
            // 
            this.Canelbutton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.Canelbutton.Location = new System.Drawing.Point(358, 315);
            this.Canelbutton.Name = "Canelbutton";
            this.Canelbutton.Size = new System.Drawing.Size(75, 39);
            this.Canelbutton.TabIndex = 4;
            this.Canelbutton.Text = "取消";
            this.Canelbutton.UseVisualStyleBackColor = true;
            this.Canelbutton.Click += new System.EventHandler(this.Canelbutton_Click);
            // 
            // PictureChecked
            // 
            this.PictureChecked.AutoSize = true;
            this.PictureChecked.Checked = true;
            this.PictureChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PictureChecked.Location = new System.Drawing.Point(12, 216);
            this.PictureChecked.Name = "PictureChecked";
            this.PictureChecked.Size = new System.Drawing.Size(72, 16);
            this.PictureChecked.TabIndex = 5;
            this.PictureChecked.Text = "是否带图";
            this.PictureChecked.UseVisualStyleBackColor = true;
            this.PictureChecked.CheckedChanged += new System.EventHandler(this.WithPicture_CheckedChanged);
            // 
            // pictureShareBox
            // 
            this.pictureShareBox.Location = new System.Drawing.Point(12, 244);
            this.pictureShareBox.Name = "pictureShareBox";
            this.pictureShareBox.Size = new System.Drawing.Size(195, 127);
            this.pictureShareBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureShareBox.TabIndex = 6;
            this.pictureShareBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::彩色连珠.Properties.Resources.分享到微博_32;
            this.pictureBox1.Location = new System.Drawing.Point(358, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 32);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // weiboShare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 383);
            this.Controls.Add(this.pictureShareBox);
            this.Controls.Add(this.PictureChecked);
            this.Controls.Add(this.Canelbutton);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.WbTxtBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "weiboShare";
            this.Text = "weiboShare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.weiboShare_FormClosing);
            this.Load += new System.EventHandler(this.weiboShare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureShareBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox WbTxtBox;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Button Canelbutton;
        private System.Windows.Forms.CheckBox PictureChecked;
        private System.Windows.Forms.PictureBox pictureShareBox;
    }
}