using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P65_1
{
    public partial class Form1 : Form
    {
        int math, english, chinese, chemistry;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            math = Convert.ToInt32(textBox1.Text.ToString());
            english = Convert.ToInt32(textBox2.Text.ToString());
            chinese= Convert.ToInt32(textBox3.Text.ToString());
            chemistry = Convert.ToInt32(textBox4.Text.ToString());

            textBox5.Text =( math + english + chinese + chemistry).ToString();
            textBox6.Text =(Convert.ToInt32(textBox5.Text.ToString())/ 4).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
