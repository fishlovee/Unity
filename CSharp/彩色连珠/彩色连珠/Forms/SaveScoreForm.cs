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
    public partial class SaveScoreForm : Form
    {
        private 彩色连珠 mainForm;
        public SaveScoreForm(int score, 彩色连珠 form)
        {
            InitializeComponent();
            this.score = score;
            mainForm = form;
            textBox1.Focus();
        }

        private void SaveScoreForm_Load(object sender, EventArgs e)
        {
            label1.Text = "您的得分：" + this.score;
        }



        private int score;
        private string name;

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            ScoreManager.WriteScore(name, score);
            mainForm.GameInit();
            this.Close();
        }

        private void SaveScoreForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("是否重新开始？",
                "询问",
                MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information) 
                == DialogResult.Yes)
            {
                mainForm.RestartGame();
            }
        }
    }
}
