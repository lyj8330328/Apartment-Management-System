using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
namespace 公寓管理系统
{
    public partial class 密码找回 : Form
    {
        string account = null;
        string connn = null;
        public 密码找回(string con,string account)
        {
            InitializeComponent();
            this.account = account;
            this.connn = con;
        }

        private void 密码找回_Load(object sender, EventArgs e)
        {
            textBox1.Text = account;
            CenterToParent();
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string cnum = null;
            string ac = textBox1.Text;
            string snum = textBox2.Text;
            string npass = textBox3.Text;
            string cpass = textBox4.Text;


            SqlConnection connec = new SqlConnection(connn);
            connec.Open();

            string sqll = String.Format("select * from UserMessage where 用户名='{0}'", ac);
            SqlCommand command = new SqlCommand(sqll, connec);
            int ss = command.ExecuteNonQuery();
            if (ss > 0)
            {
                string sqls = String.Format("select 身份证号 from UserMessage where 用户名='{0}'", ac);
                SqlCommand commands = new SqlCommand(sqls, connec);
                SqlDataReader readers = commands.ExecuteReader();
                while (readers.Read())
                {
                    cnum = String.Format("{0}", readers[0]);
                }
                readers.Close();

                if (ac == "" || snum == "" || npass == "" || cpass == "")
                {
                    MessageBox.Show("请输入完整信息！");
                }
                else if (!npass.Equals(cpass)) { MessageBox.Show("两次输入的密码不一致！"); }
                else if (cnum.Equals(snum))
                {
                    string sql = String.Format("update  UserMessage set 登录密码='{0}' where 用户名='{1}'", npass, ac);
                    SqlCommand commandss = new SqlCommand(sql, connec);
                    int s = commandss.ExecuteNonQuery();
                    if (s > 0)
                    {
                        MessageBox.Show("修改成功！");
                        Thread t = new Thread(new ThreadStart(delegate { Application.Run(new 登录窗体()); }));
                        t.Start();
                        this.Dispose(true);
                    }

                }
                else
                {
                    MessageBox.Show("身份证号码不正确，请重新输入！");
                    textBox2.Focus();
                }
            }
            else 
            {
                MessageBox.Show("用户名不正确,请重新输入！");
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  textBox1.Clear();
           // textBox2.Clear(); 
           // textBox3.Clear();
            //textBox4.Clear();
            this.Close();
        }


    }
}
