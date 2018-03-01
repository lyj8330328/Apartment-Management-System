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
    public partial class 学生住宿统计 : Form
    {
        private Panel panel;
        public string con = null;
        public 学生住宿统计(Panel panel,string con)
        {
            this.panel = panel;
            this.con = con;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            panel.Visible = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void 学生住宿统计_Load(object sender, EventArgs e)
        {
            CenterToParent();
            this.ControlBox = false;
        }

        private void 学生住宿统计_FormClosed(object sender, FormClosedEventArgs e)
        {
            panel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                int w = 0;
                string[,] m = new string[100, 3];  //用来存放院、系、专业等信息
                string s4 = null;
                int[] t = new int[100];               //存放学生人数
                for (int y = 0; y < 100; y++) { t[y] = 0; }
                string connn = con;                 //得到数据库连接字符串
                SqlConnection connec = new SqlConnection(connn);  //创建connection对象
                connec.Open();                    //打开连接

                string sql2 = String.Format("select 居住性别 from FlatMessage");  //查询性别
                SqlCommand command2 = new SqlCommand(sql2, connec);
                SqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    s4 = String.Format("{0}", reader2[0]);
                }
                reader2.Close();

                string sql3 = String.Format("select * from Academy");    //查询院、系、专业
                SqlCommand command3 = new SqlCommand(sql3, connec);
                SqlDataReader reader1 = command3.ExecuteReader();
                while (reader1.Read())
                {
                    m[w, 0] = String.Format("{0}", reader1[0]);
                    m[w, 1] = String.Format("{0}", reader1[1]);
                    m[w, 2] = String.Format("{0}", reader1[2]);
                    w++;
                }
                reader1.Close();

                //通过已经查询到的院、系、专业信息，再查询对应的院、系、专业的学生个数。
                for (int p = 0; p < w; p++)                  
                {
                    string sql = String.Format("select * from StudentMessage where 学院='{0}' and 系='{1}' and 专业='{2}'",
                        m[p, 0], m[p, 1], m[p, 2]);
                    SqlCommand command = new SqlCommand(sql, connec);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        t[p]++;
                    }
                    reader.Close();
                }

                //屏幕上显示相应的信息
                string sql4 = String.Format("select * from Academy");
                SqlCommand command4 = new SqlCommand(sql4, connec);
                SqlDataReader reader4 = command4.ExecuteReader();
                while (reader4.Read())
                {
                    DataGridViewRow Row = new DataGridViewRow();
                    int b = dataGridView1.Rows.Add(Row);
                    this.dataGridView1.Rows[b].Cells[0].Value = String.Format("{0}", reader4[0]);
                    this.dataGridView1.Rows[b].Cells[1].Value = String.Format("{0}", reader4[1]);
                    this.dataGridView1.Rows[b].Cells[2].Value = String.Format("{0}", reader4[2]);
                    this.dataGridView1.Rows[b].Cells[3].Value = Convert.ToString(t[i]);
                    this.dataGridView1.Rows[b].Cells[4].Value = s4;
                    i++;
                }
                reader4.Close();
            }
            catch (Exception ee) { MessageBox.Show("数据库中缺少相应的表！"); }

        }
    }
}
