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
using System.IO;
namespace 公寓管理系统
{
    public partial class 登录窗体 : Form
    {
        string caccount = null;
        public 登录窗体()
        {
            InitializeComponent();
        }

        public string connection()
        {

            string name = null;
            byte[] byData = new byte[100];
            char[] charData = new char[1000];
            FileStream file = new FileStream("数据库连接字符串.txt", FileMode.Open);
            file.Seek(0, SeekOrigin.Begin);
            file.Read(byData, 0, 100); //byData传进来的字节数组,用以接受FileStream对象中的数据,第2个参数是字节数组中开始写入数据的位置,它通常是0,表示从数组的开端文件中向数组写数据,最后一个参数规定从文件读多少字符.
            Decoder d = Encoding.Default.GetDecoder();
            d.GetChars(byData, 0, byData.Length, charData, 0);

            for (int i = 0; i < charData.Length; i++)
            {
                name += charData[i];
            }
            //MessageBox.Show(name);
            file.Close();

            return name;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
                string account = textBox1.Text;
                string password = textBox2.Text;
                if (account == "") { MessageBox.Show("请输入账号！"); }
                else if (account != "" && password == "") { MessageBox.Show("请输入密码！"); }
                else
                {
                    if (account.Equals("admin") && password.Equals("admin") && radioButton2.Checked == true)
                    {
                        Thread t = new Thread(new ThreadStart(delegate { Application.Run(new 公寓管理系统_管理端_()); }));
                        t.Start();
                        this.Dispose(true);
                    }
                    else
                    {
                        try
                        {
                            string connn = connection();
                            SqlConnection connec = new SqlConnection(connn);
                            connec.Open();
                            string sql4 = String.Format("select * from UserMessage where 用户名='{0}' and 登录密码='{1}'", account, password);
                            SqlCommand command4 = new SqlCommand(sql4, connec);
                            SqlDataReader reader4 = command4.ExecuteReader();
                            if (reader4.Read() && radioButton1.Checked == true)
                            // if(account.Equals("2013005805")&&password.Equals("123456")&&checkBox1.Checked==true)
                            {
                                Thread t = new Thread(new ThreadStart(delegate { Application.Run(new 公寓管理系统(account)); }));
                                t.Start();
                                this.Dispose(true);

                            }

                            else if (radioButton1.Checked == false && radioButton2.Checked == false)
                            {
                                MessageBox.Show("请选择用户类型！");

                            }
                            else
                            {
                                MessageBox.Show("用户名或密码错误！");
                                caccount = account;
                            }
                            //reader4.Close();
                        }
                        catch 
                        {
                            MessageBox.Show("数据库表错误！");
                        }
                    }
                    
                }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 登录窗体_Load(object sender, EventArgs e)
        {
           
            CenterToScreen();
            this.ControlBox = false;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(delegate { Application.Run(new 密码找回(connection(),caccount)); }));
            t.Start();
            this.Dispose(true);
        }



    }
}
