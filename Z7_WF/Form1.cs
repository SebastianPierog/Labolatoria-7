using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z7_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var settings = new Settings();
            settings.ShowDialog();
            textBox1.Text = settings.MySetting;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();
            if (result ==  DialogResult.OK)
            {
                button2.BackColor = colorDialog1.Color; 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.ShowBalloonTip(1000, "Tytuł", "Treść", ToolTipIcon.Info);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();

            var font = fontDialog1.Font;
            richTextBox1.Font = font;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }
    }
}
