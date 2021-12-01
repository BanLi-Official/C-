using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P83_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string star = textBox1.Text.ToString();

            switch (star)
            {
                case "白羊座":
                    textBox2.Text = "白羊座描述：、、、、、、、、、、、、、、、";
                    break;
                case "金牛座":
                    textBox2.Text = "金牛座描述：、、、、、、、、、、、、、、、";
                    break;
                case "双子座":
                    textBox2.Text = "双子座描述：、、、、、、、、、、、、、、、";
                    break;
                case "巨蟹座":
                    textBox2.Text = "巨蟹座描述：、、、、、、、、、、、、、、、";
                    break;
                case "狮子座":
                    textBox2.Text = "狮子座描述：、、、、、、、、、、、、、、、";
                    break;
                case "处女座":
                    textBox2.Text = "处女座描述：、、、、、、、、、、、、、、、";
                    break;
                case "天秤座":
                    textBox2.Text = "天枰座描述：、、、、、、、、、、、、、、、";
                    break;
                case "天蝎座":
                    textBox2.Text = "天蝎座描述：、、、、、、、、、、、、、、、";
                    break;
                case "射手座":
                    textBox2.Text = "射手座描述：、、、、、、、、、、、、、、、";
                    break;
                case "摩羯座":
                    textBox2.Text = "摩羯座描述：、、、、、、、、、、、、、、、";
                    break;
                case "水瓶座":
                    textBox2.Text = "水瓶座描述：、、、、、、、、、、、、、、、";
                    break;
                case "双鱼座":
                    textBox2.Text = "双鱼座描述：、、、、、、、、、、、、、、、";
                    break;
                default:
                    MessageBox.Show("输入有误", "提示");
                    break;


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
