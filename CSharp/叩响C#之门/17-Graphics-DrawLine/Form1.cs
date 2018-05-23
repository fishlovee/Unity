using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_Graphics_DrawLine
{
    public partial class Form1 : Form
    {
        private Brush brush = new SolidBrush(Color.White);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 画直线_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(new Pen(Color.OrangeRed, 5), new Point(20, 50), new Point(200, 50));
            g.Dispose();
        }

        private void 清除_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            g.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(new Pen(Color.Green, 5), new Rectangle(new Point(20, 50), new Size(80, 50)));
            g.FillEllipse(brush, new Rectangle(new Point(20, 50), new Size(80, 50)));
            g.Dispose();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 实心_CheckedChanged(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.Green);
        }

        private void 纹理_CheckedChanged(object sender, EventArgs e)
        {
            //brush = new TextureBrush();
        }

        private void 渐变_CheckedChanged(object sender, EventArgs e)
        {
            Point start = new Point(50, 50);
            Point end = new Point(100, 100);
            brush = new LinearGradientBrush(start, end, Color.Red, Color.Yellow);
        }

        private void 阴影_CheckedChanged(object sender, EventArgs e)
        {
            brush = new HatchBrush(HatchStyle.ForwardDiagonal, Color.Red, Color.LightGreen);
        }
    }
}
