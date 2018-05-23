using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 彩色连珠.Forms
{
    public partial class CMsgBox : Form
    {
        public CMsgBox(Form form)
        {
            InitializeComponent();
        }

        private void CMsgBox_Load(object sender, EventArgs e)
        {

        }

        public void Show(string caption, string txt)
        {
            TxtLable.Text = txt;
            this.Text = caption;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
