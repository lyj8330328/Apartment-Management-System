using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace 公寓管理系统
{
    
    public partial class 添加用户 : Form
    {
        public string con = null;
        public 添加用户(string con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string rpassword = textBox3.Text;
            string tel = textBox4.Text;
            string realname = textBox5.Text;
            string snum = textBox6.Text;
            //获取用户输入的用户名、密码、电话、姓名、身份证号

            string connn = con;
            SqlConnection connec = new SqlConnection(connn);  //创建connection对象
            connec.Open();                                    //打开连接
            string sqls = String.Format("select * from UserMessage where 用户名='{0}'", username);//先判断用户名是否重复
            SqlCommand commands = new SqlCommand(sqls, connec);
            SqlDataReader readers = commands.ExecuteReader();
            if (readers.Read())
            {
                MessageBox.Show("该账号已经被注册！");

            }

            else
            {
                readers.Close();
                if (password.Equals(rpassword) == false)          //判断两次输入的密码是否一致
                {
                    MessageBox.Show("两次输入的密码不一致！");
                }
                else if (username == "" || password == "" || rpassword == "" || tel == "" || realname == ""||snum=="")
                {
                    MessageBox.Show("请输入完整信息！");
                    this.textBox1.Focus();
                }            
                else if (username.Length < 8)                 //用户名必须不少于8位
                {
                    label7.Visible = true;
                    label7.Text = "用户名长度不少于8位";
                }
                else
                {
                    string sql = String.Format("insert into UserMessage values('{0}','{1}','{2}','{3}','{4}')",
                        username, password, tel, realname,snum);   //把输入的信息插入到数据库中的表
                    SqlCommand command = new SqlCommand(sql, connec);
                    int s = command.ExecuteNonQuery();
                    if (s > 0)
                    {
                        MessageBox.Show("增加成功！");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 添加用户_Load(object sender, EventArgs e)
        {
            CenterToParent();
            label7.Visible = false;
            MaximizeBox = false;
        }

       
    }
}
