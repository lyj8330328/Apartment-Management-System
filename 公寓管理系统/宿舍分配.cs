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
    public partial class 宿舍分配 : Form
    {
        private Panel panel;
        public string con = null;
        private DataGridView dataGridView1;

        DataGridViewTextBoxColumn s1 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s2 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s3 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s4 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s5 = new DataGridViewTextBoxColumn();

        public 宿舍分配(Panel panel, DataGridView dataGridView, string con)
        {
            InitializeComponent();
            this.panel = panel;
            this.con = con;
            this.dataGridView1 = dataGridView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            dataGridView1.Visible = false;

            dataGridView1.Columns.Remove(s1);
            dataGridView1.Columns.Remove(s2);
            dataGridView1.Columns.Remove(s3);
            dataGridView1.Columns.Remove(s4);
            dataGridView1.Columns.Remove(s5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void 宿舍分配_Load(object sender, EventArgs e)
        {
            CenterToParent();

            this.ControlBox = false;

            dataGridView1.Visible = true;
            dataGridView1.Location = new Point(23, 24);
            dataGridView1.Size = new System.Drawing.Size(680, 400);

            s1.HeaderText = "学院";
            s1.Width = 150;
            dataGridView1.Columns.Add(s1);

            s2.HeaderText = "系";
            s2.Width = 150;
            dataGridView1.Columns.Add(s2);

            s3.HeaderText = "专业";
            s3.Width = 150;
            dataGridView1.Columns.Add(s3);

            s4.HeaderText = "年级";
            s4.Width = 100;
            dataGridView1.Columns.Add(s4);

            s5.HeaderText = "班级";
            s5.Width = 100;
            dataGridView1.Columns.Add(s5);

            try
            {
                string[] k = new string[100];
                string[] k2 = new string[100];
                string[] k3 = new string[100];
                string[] k4 = new string[100];
                string[] k5 = new string[100];
                string[] k6 = new string[100];
                string[] k7 = new string[100];
                string[] k8 = new string[100];

                int i = 0;
                int d = 0;
                string connn = con;
                SqlConnection connec = new SqlConnection(connn);
                connec.Open();
                string sql3 = String.Format("select * from Academy");
                SqlCommand command3 = new SqlCommand(sql3, connec);
                SqlDataReader reader1 = command3.ExecuteReader();
                while (reader1.Read())
                {
                    k[i] = String.Format("{0}", reader1[0]);
                    k2[i] = String.Format("{0}", reader1[1]);
                    k3[i] = String.Format("{0}", reader1[2]);
                    i++;
                }
                reader1.Close();

                for (int w = 0; w < i; w++)
                {
                    string sql4 = String.Format("select distinct 年级,班级 from StudentMessage where 学院='{0}' and 系='{1}' and 专业='{2}' ",
                        k[w], k2[w], k3[w]);
                    SqlCommand command4 = new SqlCommand(sql4, connec);
                    SqlDataReader reader4 = command4.ExecuteReader();
                    while (reader4.Read())
                    {
                        k4[d] = String.Format("{0}", reader4[0]);
                        k5[d] = String.Format("{0}", reader4[1]);
                        k6[d] = k[w];
                        k7[d] = k2[w];
                        k8[d] = k3[w];
                        d++;
                    }
                    reader4.Close();
                }
                for (int c = 0; c < d; c++)
                {
                    DataGridViewRow Row = new DataGridViewRow();
                    int b = dataGridView1.Rows.Add(Row);
                    this.dataGridView1.Rows[b].Cells[0].Value = k6[c];
                    this.dataGridView1.Rows[b].Cells[1].Value = k7[c];
                    this.dataGridView1.Rows[b].Cells[2].Value = k8[c];
                    this.dataGridView1.Rows[b].Cells[3].Value = k4[c];
                    this.dataGridView1.Rows[b].Cells[4].Value = k5[c];
                }
            }
            catch (Exception ee) { MessageBox.Show("数据库中缺少相应的表！"); }
        }

        private void 宿舍分配_FormClosed(object sender, FormClosedEventArgs e)
        {
            panel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
            int i = 0;
            int j = 0;
            int x = 0;
                //获取界面上输入的相应信息
            string s1 = comboBox1.Text;
            string s2 = comboBox2.Text;
            string s3 = textBox1.Text;
            string s4 = textBox2.Text;
            string s5 = textBox3.Text;


            string[] m = new string[100000];   //保存学生的学号
            string[] m2 = new string[100000];  //保存学生的楼号
            string[] m3 = new string[100000];  //保存学生的寝室号
            string[] m4 = new string[100000];  //保存学生的床号
            string[,] u = new string[100000, 3];  //保存未分配寝室的信息

            string connn = con;   //获取数据库连接字符串
            SqlConnection connec = new SqlConnection(connn);  //创建connection对象
            connec.Open();            //打开连接

            //根据输入的信息核对数据库中是否存在满足条件的学生信息
            string sql = String.Format("select * from StudentMessage where 学院='{0}' and 系='{1}' and 专业='{2}' "
                +"and 年级='{3}' and 班级='{4}'",
                s1, s2, s3, s4, s5);
            SqlCommand command = new SqlCommand(sql, connec);
            SqlDataReader reader = command.ExecuteReader();
            if (!reader.Read()) { MessageBox.Show("请重新核对输入信息！"); reader.Close(); }
            else
            {
                reader.Close();
                //从数据库中的StudentMessage表中读取信息，将学号、楼号、寝室号、床号分别保存
                string sqlp = String.Format("select * from StudentMessage where 学院='{0}' and 系='{1}' and 专业='{2}'"
                    +" and 年级='{3}' and 班级='{4}'", s1, s2, s3, s4, s5);
                SqlCommand commandp = new SqlCommand(sqlp, connec);
                SqlDataReader readerp = commandp.ExecuteReader();
                while (readerp.Read())
                {
                    m[i] = String.Format("{0}", readerp[0]);
                    m2[i] = String.Format("{0}", readerp[8]);
                    m3[i] = String.Format("{0}", readerp[9]);
                    m4[i] = String.Format("{0}", readerp[10]);
                    i++;
                }
                readerp.Close();
            }

            for (int t = 0; t < i; t++)
            {
                if (m2[t] != "" && m3[t] != "" && m4[t] != "") { x++; }   //如果入住学生已经分配完宿舍则输出提示信息
            }

            if (x > 0) { MessageBox.Show("现有学生已经分配完毕！"); }
            else                                                      //否则进行寝室的分配
            {
                string sql3 = String.Format("select * from Flat");
                SqlCommand command3 = new SqlCommand(sql3, connec);
                SqlDataReader reader3 = command3.ExecuteReader();
                while (reader3.Read())
                {
                    if ((String.Format("{0}", reader3[4]).Equals("是"))==false)   //将Flat表中未分配的寝室信息保存在u二维数组中
                    {                        
                        u[j, 0] = String.Format("{0}", reader3[0]);
                        u[j, 1] = String.Format("{0}", reader3[2]);
                        u[j, 2] = String.Format("{0}", reader3[3]);
                        j++;
                    }
                }
                reader3.Close();

                for (int y = 0; y < i; y++)
                {
                    //更新学生表StudentMessage中相应的信息
                    string sql7 = String.Format("update StudentMessage set 楼号='{0}' where 学号='{1}'", u[y, 0], m[y]);
                    SqlCommand command7 = new SqlCommand(sql7, connec);
                    command7.ExecuteNonQuery();

                    string sql8 = String.Format("update StudentMessage set 寝室号='{0}' where 学号='{1}'", u[y, 1], m[y]);
                    SqlCommand command8 = new SqlCommand(sql8, connec);
                    command8.ExecuteNonQuery();

                    string sql9 = String.Format("update StudentMessage set  床号='{0}' where 学号='{1}'", u[y, 2], m[y]);
                    SqlCommand command9 = new SqlCommand(sql9, connec);
                    command9.ExecuteNonQuery();

                }

                for (int k = 0; k < i; k++)
                {
                    //将已经分配了的寝室的入住状态改成“是”
                    string sql4 = String.Format("update Flat set 是否入住='{0}' where 楼号='{1}' and 寝室号='{2}' "
                        +"and 床号='{3}'", "是", u[k, 0], u[k, 1], u[k, 2]);
                    SqlCommand command4 = new SqlCommand(sql4, connec);
                    command4.ExecuteNonQuery();
                }

                if (i > 0) { MessageBox.Show("分配成功！"); }
            }
            } catch(Exception ee){MessageBox.Show("数据库中缺少相应的表！");}

            }
        }
    }
