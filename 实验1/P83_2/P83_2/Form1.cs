using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P83_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double money = double.Parse( textBox1.Text.ToString());
            double pay = 0;
            if (money < 5000)
            {
                pay = 0;
                MessageBox.Show("您获得的奖金为：" + pay + "元！", "奖金");
            }
            else if (money < 8000)
            {
                pay = money * 0.03;
                MessageBox.Show("您获得的奖金为：" + pay + "元！", "奖金");
            }
            else if (money < 10000)
            {
                pay = money * 0.05;
                MessageBox.Show("您获得的奖金为：" + pay + "元！", "奖金");
            }
            else if (money < 15000)
            {
                pay = money * 0.08;
                MessageBox.Show("您获得的奖金为：" + pay + "元！", "奖金");
            }
            else
            {
                pay = money * 0.1;
                MessageBox.Show("您获得的奖金为：" + pay + "元！", "奖金");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }
    }
}
