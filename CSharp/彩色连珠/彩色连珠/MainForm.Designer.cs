namespace 彩色连珠
{
    partial class 彩色连珠
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(彩色连珠));
            this.GameZone = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SaveProcessButton = new System.Windows.Forms.Button();
            this.UndoButton = new System.Windows.Forms.Button();
            this.NextCom = new System.Windows.Forms.GroupBox();
            this.NextPictures = new System.Windows.Forms.PictureBox();
            this.ScoreBox = new System.Windows.Forms.GroupBox();
            this.ScoreLable = new System.Windows.Forms.Label();
            this.MaxScoreLable = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分享到微博ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存进度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.NextCom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NextPictures)).BeginInit();
            this.ScoreBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameZone
            // 
            this.GameZone.Location = new System.Drawing.Point(1, 27);
            this.GameZone.Name = "GameZone";
            this.GameZone.Size = new System.Drawing.Size(601, 601);
            this.GameZone.TabIndex = 0;
            this.GameZone.Paint += new System.Windows.Forms.PaintEventHandler(this.GameZone_Paint);
            this.GameZone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameZone_MouseClick);
            this.GameZone.MouseLeave += new System.EventHandler(this.GameZone_MouseLeave);
            this.GameZone.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameZone_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SaveProcessButton);
            this.panel2.Controls.Add(this.UndoButton);
            this.panel2.Controls.Add(this.NextCom);
            this.panel2.Controls.Add(this.ScoreBox);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.RestartButton);
            this.panel2.Location = new System.Drawing.Point(608, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 601);
            this.panel2.TabIndex = 1;
            // 
            // SaveProcessButton
            // 
            this.SaveProcessButton.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold);
            this.SaveProcessButton.Location = new System.Drawing.Point(-2, 510);
            this.SaveProcessButton.Name = "SaveProcessButton";
            this.SaveProcessButton.Size = new System.Drawing.Size(284, 88);
            this.SaveProcessButton.TabIndex = 5;
            this.SaveProcessButton.Text = "以后再玩";
            this.SaveProcessButton.UseVisualStyleBackColor = true;
            this.SaveProcessButton.Click += new System.EventHandler(this.SaveProcessButton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold);
            this.UndoButton.Location = new System.Drawing.Point(0, 416);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(284, 88);
            this.UndoButton.TabIndex = 4;
            this.UndoButton.Text = "悔棋";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // NextCom
            // 
            this.NextCom.Controls.Add(this.NextPictures);
            this.NextCom.Location = new System.Drawing.Point(1, 114);
            this.NextCom.Name = "NextCom";
            this.NextCom.Size = new System.Drawing.Size(281, 105);
            this.NextCom.TabIndex = 1;
            this.NextCom.TabStop = false;
            this.NextCom.Text = "下一组";
            // 
            // NextPictures
            // 
            this.NextPictures.Location = new System.Drawing.Point(6, 10);
            this.NextPictures.Name = "NextPictures";
            this.NextPictures.Size = new System.Drawing.Size(269, 89);
            this.NextPictures.TabIndex = 0;
            this.NextPictures.TabStop = false;
            // 
            // ScoreBox
            // 
            this.ScoreBox.Controls.Add(this.ScoreLable);
            this.ScoreBox.Controls.Add(this.MaxScoreLable);
            this.ScoreBox.Location = new System.Drawing.Point(7, 13);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Size = new System.Drawing.Size(281, 105);
            this.ScoreBox.TabIndex = 0;
            this.ScoreBox.TabStop = false;
            this.ScoreBox.Text = "成绩";
            // 
            // ScoreLable
            // 
            this.ScoreLable.AutoSize = true;
            this.ScoreLable.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ScoreLable.ForeColor = System.Drawing.Color.ForestGreen;
            this.ScoreLable.Location = new System.Drawing.Point(7, 56);
            this.ScoreLable.Name = "ScoreLable";
            this.ScoreLable.Size = new System.Drawing.Size(85, 24);
            this.ScoreLable.TabIndex = 1;
            this.ScoreLable.Text = "分数：";
            // 
            // MaxScoreLable
            // 
            this.MaxScoreLable.AutoSize = true;
            this.MaxScoreLable.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaxScoreLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MaxScoreLable.Location = new System.Drawing.Point(7, 21);
            this.MaxScoreLable.Name = "MaxScoreLable";
            this.MaxScoreLable.Size = new System.Drawing.Size(110, 24);
            this.MaxScoreLable.TabIndex = 0;
            this.MaxScoreLable.Text = "最高分：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 91);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "小提示";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Fuchsia;
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 71);
            this.label3.TabIndex = 0;
            this.label3.Text = "5个相同颜色的球在一起会消掉，同时加10分，6个球加20分，7个球30分，依次类推，但棋盘越满，难度越大。";
            // 
            // RestartButton
            // 
            this.RestartButton.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold);
            this.RestartButton.Location = new System.Drawing.Point(-1, 322);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(284, 88);
            this.RestartButton.TabIndex = 3;
            this.RestartButton.Text = "重新开始";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.成绩ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重新开始ToolStripMenuItem,
            this.分享到微博ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.保存进度ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.G)));
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.菜单ToolStripMenuItem.Text = "游戏(&G)";
            // 
            // 重新开始ToolStripMenuItem
            // 
            this.重新开始ToolStripMenuItem.Image = global::彩色连珠.Properties.Resources.Play;
            this.重新开始ToolStripMenuItem.Name = "重新开始ToolStripMenuItem";
            this.重新开始ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.重新开始ToolStripMenuItem.Text = "重新开始(&R)";
            this.重新开始ToolStripMenuItem.Click += new System.EventHandler(this.重新开始ToolStripMenuItem_Click);
            // 
            // 分享到微博ToolStripMenuItem
            // 
            this.分享到微博ToolStripMenuItem.Image = global::彩色连珠.Properties.Resources.SinaWeibo_PNG;
            this.分享到微博ToolStripMenuItem.Name = "分享到微博ToolStripMenuItem";
            this.分享到微博ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.分享到微博ToolStripMenuItem.Text = "分享到微博(&W)";
            this.分享到微博ToolStripMenuItem.Click += new System.EventHandler(this.分享到微博ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Image = global::彩色连珠.Properties.Resources.save;
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.退出ToolStripMenuItem.Text = "保存进度(&S)";
            // 
            // 保存进度ToolStripMenuItem
            // 
            this.保存进度ToolStripMenuItem.Image = global::彩色连珠.Properties.Resources.Delete;
            this.保存进度ToolStripMenuItem.Name = "保存进度ToolStripMenuItem";
            this.保存进度ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.保存进度ToolStripMenuItem.Text = "退出";
            // 
            // 成绩ToolStripMenuItem
            // 
            this.成绩ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看成绩ToolStripMenuItem});
            this.成绩ToolStripMenuItem.Name = "成绩ToolStripMenuItem";
            this.成绩ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.成绩ToolStripMenuItem.Text = "成绩(&S)";
            // 
            // 查看成绩ToolStripMenuItem
            // 
            this.查看成绩ToolStripMenuItem.Name = "查看成绩ToolStripMenuItem";
            this.查看成绩ToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.查看成绩ToolStripMenuItem.Text = "查看成绩(&C)";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem1,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 帮助ToolStripMenuItem1
            // 
            this.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1";
            this.帮助ToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.帮助ToolStripMenuItem1.Text = "帮助(&H)";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.关于ToolStripMenuItem.Text = "关于(&A)";
            // 
            // ZoomTimer
            // 
            this.ZoomTimer.Interval = 70;
            this.ZoomTimer.Tick += new System.EventHandler(this.ZommTimerTick);
            // 
            // 彩色连珠
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 628);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GameZone);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "彩色连珠";
            this.Text = "彩色连珠";
            this.Load += new System.EventHandler(this.彩色连珠_Load);
            this.MouseLeave += new System.EventHandler(this.彩色连珠_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.彩色连珠_MouseMove);
            this.panel2.ResumeLayout(false);
            this.NextCom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NextPictures)).EndInit();
            this.ScoreBox.ResumeLayout(false);
            this.ScoreBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GameZone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.GroupBox NextCom;
        private System.Windows.Forms.PictureBox NextPictures;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.GroupBox ScoreBox;
        private System.Windows.Forms.Label ScoreLable;
        private System.Windows.Forms.Label MaxScoreLable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveProcessButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分享到微博ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存进度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Timer ZoomTimer;
    }
}

