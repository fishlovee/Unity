namespace _17_Graphics_DrawLine
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
            this.画直线 = new System.Windows.Forms.Button();
            this.清除 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.画刷 = new System.Windows.Forms.GroupBox();
            this.实心 = new System.Windows.Forms.RadioButton();
            this.渐变 = new System.Windows.Forms.RadioButton();
            this.纹理 = new System.Windows.Forms.RadioButton();
            this.阴影 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.画刷.SuspendLayout();
            this.SuspendLayout();
            // 
            // 画直线
            // 
            this.画直线.Location = new System.Drawing.Point(12, 213);
            this.画直线.Name = "画直线";
            this.画直线.Size = new System.Drawing.Size(53, 23);
            this.画直线.TabIndex = 0;
            this.画直线.Text = "直线";
            this.画直线.UseVisualStyleBackColor = true;
            this.画直线.Click += new System.EventHandler(this.画直线_Click);
            // 
            // 清除
            // 
            this.清除.Location = new System.Drawing.Point(210, 213);
            this.清除.Name = "清除";
            this.清除.Size = new System.Drawing.Size(75, 23);
            this.清除.TabIndex = 1;
            this.清除.Text = "清除";
            this.清除.UseVisualStyleBackColor = true;
            this.清除.Click += new System.EventHandler(this.清除_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "椭圆";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 画刷
            // 
            this.画刷.Controls.Add(this.radioButton5);
            this.画刷.Controls.Add(this.阴影);
            this.画刷.Controls.Add(this.纹理);
            this.画刷.Controls.Add(this.渐变);
            this.画刷.Controls.Add(this.实心);
            this.画刷.Location = new System.Drawing.Point(165, 12);
            this.画刷.Name = "画刷";
            this.画刷.Size = new System.Drawing.Size(107, 174);
            this.画刷.TabIndex = 3;
            this.画刷.TabStop = false;
            this.画刷.Text = "画刷";
            // 
            // 实心
            // 
            this.实心.AutoSize = true;
            this.实心.Location = new System.Drawing.Point(6, 20);
            this.实心.Name = "实心";
            this.实心.Size = new System.Drawing.Size(47, 16);
            this.实心.TabIndex = 0;
            this.实心.TabStop = true;
            this.实心.Text = "实心";
            this.实心.UseVisualStyleBackColor = true;
            this.实心.CheckedChanged += new System.EventHandler(this.实心_CheckedChanged);
            // 
            // 渐变
            // 
            this.渐变.AutoSize = true;
            this.渐变.Location = new System.Drawing.Point(6, 64);
            this.渐变.Name = "渐变";
            this.渐变.Size = new System.Drawing.Size(47, 16);
            this.渐变.TabIndex = 1;
            this.渐变.TabStop = true;
            this.渐变.Text = "渐变";
            this.渐变.UseVisualStyleBackColor = true;
            this.渐变.CheckedChanged += new System.EventHandler(this.渐变_CheckedChanged);
            // 
            // 纹理
            // 
            this.纹理.AutoSize = true;
            this.纹理.Location = new System.Drawing.Point(6, 42);
            this.纹理.Name = "纹理";
            this.纹理.Size = new System.Drawing.Size(47, 16);
            this.纹理.TabIndex = 2;
            this.纹理.TabStop = true;
            this.纹理.Text = "纹理";
            this.纹理.UseVisualStyleBackColor = true;
            this.纹理.CheckedChanged += new System.EventHandler(this.纹理_CheckedChanged);
            // 
            // 阴影
            // 
            this.阴影.AutoSize = true;
            this.阴影.Location = new System.Drawing.Point(6, 86);
            this.阴影.Name = "阴影";
            this.阴影.Size = new System.Drawing.Size(47, 16);
            this.阴影.TabIndex = 3;
            this.阴影.TabStop = true;
            this.阴影.Text = "阴影";
            this.阴影.UseVisualStyleBackColor = true;
            this.阴影.CheckedChanged += new System.EventHandler(this.阴影_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 108);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(95, 16);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.画刷);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.清除);
            this.Controls.Add(this.画直线);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.画刷.ResumeLayout(false);
            this.画刷.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button 画直线;
        private System.Windows.Forms.Button 清除;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox 画刷;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton 阴影;
        private System.Windows.Forms.RadioButton 纹理;
        private System.Windows.Forms.RadioButton 渐变;
        private System.Windows.Forms.RadioButton 实心;
    }
}

