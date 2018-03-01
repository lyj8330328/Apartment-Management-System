using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace 公寓管理系统
{
    public partial class 连接数据库 : Form
    {
        public 连接数据库(string s)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connn = textBox2.Text;    //获取用户在文本框输入的数据库连接字符串
            if (connn == "") { MessageBox.Show("请输入连接字符串！"); } //如果为空，弹出对话框，提示请输入连接字符串。
            else
            {
                SqlConnection connec = new SqlConnection(connn);   //创建connection对象，参数为输入的数据库连接字符串
                connec.Open();                                   //打开连接
                string sql = String.Format("CREATE TABLE AAAAA (LastName varchar,"
                                           +"FirstName varchar,Address varchar,Age int)");//sql语句，在数据库中建立一个表
                SqlCommand command = new SqlCommand(sql, connec); //创建command对象，参数为sql语句和数据库连接字符串
                command.ExecuteNonQuery();           //执行sql语句

                string sqls = String.Format("insert into AAAAA values('{0}','{1}','{2}','{3}')", 1, 2, 3, 4);  //向表内插入数据
                SqlCommand commands = new SqlCommand(sqls, connec);
                int ss = commands.ExecuteNonQuery();
                if (ss > 0)        //判断是否插入成功
                {
                    MessageBox.Show("连接成功！");
                    string sqlss = String.Format("DROP TABLE AAAAA");   //删除刚刚建立的表
                    SqlCommand commandss = new SqlCommand(sqlss, connec);
                    commandss.ExecuteNonQuery();

                    FileStream fs = new FileStream("数据库连接字符串.txt", FileMode.Create);  
                    //把用户输入的数据库连接字符串写入txt文档中，供其他模块读取
                    byte[] data = System.Text.Encoding.Default.GetBytes(connn);
                    fs.Write(data, 0, data.Length);
                    fs.Flush();
                    fs.Close();

                }
            }
        }

        private void 连接数据库_Load(object sender, EventArgs e)
        {
            CenterToParent();
            this.ControlBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
