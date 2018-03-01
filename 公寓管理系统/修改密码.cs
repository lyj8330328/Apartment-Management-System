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
    public partial class 修改密码 : Form
    {
        
        public string con = null;
        public string account = null;
        public 修改密码(string account,string con)
        {
            InitializeComponent();
            this.con = con;
            this.account = account;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ps1 = textBox1.Text;
            string ps2 = textBox2.Text;
            string ps3 = textBox3.Text;

            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();

            if (ps2.Equals(ps3) == false)
            {
                MessageBox.Show("两次输入的密码不一致！");
            }
            if (ps2.Equals(ps1) == true) { MessageBox.Show("新密码不能与旧密码相同！"); }
            else if (ps1 == "" || ps2 == "" || ps3 == "") { MessageBox.Show("请输入完整信息！"); }
            else
            {
                string sql = String.Format("select * from UserMessage where 用户名='{0}'and 登录密码='{1}'", account, ps1);
                SqlCommand command = new SqlCommand(sql, connec);
                SqlDataReader s = command.ExecuteReader();
                if (s.Read())
                {
                    
                    s.Close();
                    string sql2 = String.Format("update  UserMessage set 登录密码='{0}' where 用户名='{1}'", ps2, account);
                    SqlCommand command2 = new SqlCommand(sql2, connec);
                    int s2=command2.ExecuteNonQuery();
                    if (s2>0)
                    {
                        
                        MessageBox.Show("密码修改成功，请重新登录！");
                        Application.Exit();
                        Thread t = new Thread(new ThreadStart(delegate { Application.Run(new 登录窗体()); }));
                        t.Start();
                        this.Dispose(true);
                       
                    }
                    
                }
                
            }

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 修改密码_Load(object sender, EventArgs e)
        {
            CenterToParent();
            MaximizeBox = false;
        }

      


    }
}
