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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        public string MySetting { get; private set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySetting = textBox1.Text; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
