using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace P234
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            if (now.Equals(textBox3.Text))
            {
                try
                {
                    FileInfo fi01 = new FileInfo("" + textBox1.Text);
                    fi01.CopyTo("" + textBox2.Text);
                }
                catch
                {
                }


            }*/


            string str = DateTime.Now.ToString();
            this.textBox1.Text = str;



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            if (now.Equals(textBox3.Text))
            {
                try
                {
                    FileInfo fi01 = new FileInfo("" + textBox1.Text);
                    fi01.CopyTo("" + textBox2.Text);
                }
                catch
                {
                }

            }
        }
    }
}
