using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P82
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(textBox1.Text.ToString());
            double pay;
            if (weight < 20)
            {
                pay = 0;
                MessageBox.Show("您的托运费为" + pay + "元", "计费");
            }
            else if (weight <= 30)
            {
                pay = (weight - 20) * 30;
                MessageBox.Show("您的托运费为" + pay + "元", "计费");
            }
            else if (weight <= 40)
            {
                pay = 300 + (weight - 30) * 40;
                MessageBox.Show("您的托运费为" + pay + "元", "计费");
            }
            else if (weight <= 50)
            {
                pay = 300 + 400 + (weight - 40) * 50;
                MessageBox.Show("您的托运费为" + pay + "元", "计费");
            }
            else 
            {
                MessageBox.Show("不允许携带", "计费");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
