using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P312
{
    public partial class Form1 : Form
    {
        public static string str = "";//创建字符串变量
        public Form1()
        {
            InitializeComponent();
        }



        private void showinf()//用于显示数据表的信息
        {
            using (SqlConnection con = new SqlConnection("server=127.0.0.1;pwd=123456;uid=root;database=enterprise"))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from boss", con);
                da.Fill(dt);
                this.dataGridView1.DataSource = dt.DefaultView;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            showinf();//调用方法
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            SqlConnection conn = new SqlConnection();//实例SqlConnection对象
            conn.ConnectionString = "Server=127.0.0.1;uid=root;pwd=123456;database=enterprise";//设置连接字符串
            conn.Open();//打开数据库连接
            //使用 SqlCommand提交查询命令
            SqlCommand cmd = new SqlCommand("select * from boss ", conn);
            //获取数据适配器
            SqlDataAdapter da = new SqlDataAdapter();//
            da.SelectCommand = cmd;
            //填充DataSet
            DataSet ds = new DataSet();
            da.Fill(ds);
            //绑定DataSet数据
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            //断开连接
            conn.Close();
        }
    }
}
