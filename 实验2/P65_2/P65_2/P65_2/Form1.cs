using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P65_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double rice, nod, quick, wlj;
            rice = Convert.ToDouble(textBox1.Text.ToString());
            nod = Convert.ToDouble(textBox2.Text.ToString());
            quick = Convert.ToDouble(textBox3.Text.ToString());
            wlj = Convert.ToDouble(textBox4.Text.ToString());

            MessageBox.Show("您当前的消费金额为："+ (rice + nod + quick + wlj).ToString()+"元", "商品总价");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
