using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 彩色连珠
{
    public partial class weiboShare : Form
    {
        public weiboShare(string contenx)
        {
            InitializeComponent();
            WbTxtBox.Text = contenx;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WithPicture_CheckedChanged(object sender, EventArgs e)
        {
            pictureShareBox.Visible = PictureChecked.Checked;
        }
        
        private void weiboShare_Load(object sender, EventArgs e)
        {
            pictureShareBox.Image = Image.FromFile("weibo.png");
        }

        private void Canelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void weiboShare_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox1.Refresh();
        }
    }
}
