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
    public partial class 教师来访登记 : Form
    {
        private Panel panel;
        private DataGridView dataGridView1;
        public string con = null;
        string m1 = null;
        string m2 = null;
        string m3 = null;
        string m4 = null;
        string m5 = null;
        string m6 = null;
        string m7 = null;
        string m8 = null;
        string m9 = null;
        DataGridViewTextBoxColumn s1 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s2 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s3 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s4 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s5 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s6 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s7 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s8 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s9 = new DataGridViewTextBoxColumn();
        public 教师来访登记(Panel panel, DataGridView dataGridView,string con)
        {
            InitializeComponent();
            this.panel = panel;
            this.dataGridView1 = dataGridView;
            this.con = con;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            panel.Visible = true;

            dataGridView1.Visible = false;

            dataGridView1.Columns.Remove(s1);
            dataGridView1.Columns.Remove(s2);
            dataGridView1.Columns.Remove(s3);
            dataGridView1.Columns.Remove(s4);
            dataGridView1.Columns.Remove(s5);
            dataGridView1.Columns.Remove(s6);
            dataGridView1.Columns.Remove(s7);
            dataGridView1.Columns.Remove(s8);
            dataGridView1.Columns.Remove(s9);

        }

        private void 教师来访登记_Load(object sender, EventArgs e)
        {
            textBox1.Focus();

            this.ControlBox = false;

            button7.Enabled = false;
            button5.Enabled = false;
            //textBox7.Enabled = false;

            CenterToParent();

            dataGridView1.Visible = true;
            dataGridView1.Location = new Point(23,24);
            dataGridView1.Size = new System.Drawing.Size(1063, 300);



            s1.HeaderText = "教师姓名";
            s1.Width = 80;
            dataGridView1.Columns.Add(s1);

            s2.HeaderText = "证件类型";
            s2.Width = 80;
            dataGridView1.Columns.Add(s2);

            s3.HeaderText = "证件号码";
            s3.Width = 150;
            dataGridView1.Columns.Add(s3);

            s4.HeaderText = "楼号";
            s4.Width = 60;
            dataGridView1.Columns.Add(s4);

            s5.HeaderText = "学院";
            s5.Width = 150;
            dataGridView1.Columns.Add(s5);

            s6.HeaderText = "专业";
            dataGridView1.Columns.Add(s6);

            s7.HeaderText = "进入时间";
            s7.Width = 150;
            dataGridView1.Columns.Add(s7);

            s8.HeaderText = "离开时间";
            s8.Width = 150;
            dataGridView1.Columns.Add(s8);

            s9.HeaderText = "备注";
            s9.Width = 100;
            dataGridView1.Columns.Add(s9);

            try
            {
                string connn = con;
                SqlConnection connec = new SqlConnection(connn);
                connec.Open();
                string sql2 = String.Format("select * from TeacherVisit  ");
                SqlCommand command2 = new SqlCommand(sql2, connec);
                SqlDataReader reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewRow Row = new DataGridViewRow();
                    int i = dataGridView1.Rows.Add(Row);
                    this.dataGridView1.Rows[i].Cells[0].Value = String.Format("{0}", reader[0]);
                    this.dataGridView1.Rows[i].Cells[1].Value = String.Format("{0}", reader[1]);
                    this.dataGridView1.Rows[i].Cells[2].Value = String.Format("{0}", reader[2]);
                    this.dataGridView1.Rows[i].Cells[3].Value = String.Format("{0}", reader[3]);
                    this.dataGridView1.Rows[i].Cells[4].Value = String.Format("{0}", reader[4]);
                    this.dataGridView1.Rows[i].Cells[5].Value = String.Format("{0}", reader[5]);
                    this.dataGridView1.Rows[i].Cells[6].Value = String.Format("{0}", reader[6]);
                    this.dataGridView1.Rows[i].Cells[7].Value = String.Format("{0}", reader[7]);
                    this.dataGridView1.Rows[i].Cells[8].Value = String.Format("{0}", reader[8]);
                }
                reader.Close();
            }
            catch (Exception ee) { MessageBox.Show("数据库中缺少相应的表！"); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox1.Clear();
            textBox2.Clear(); 
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox5.Clear();
            textBox7.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;

                // button5.Enabled = false;
                textBox6.Enabled = false;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;

                int z = dataGridView1.RowCount - 1;
                dataGridView1.EndEdit();
                for (int s = 0; s < z; s++)
                {
                    if (dataGridView1.Rows[s].IsNewRow) break;
                    dataGridView1.Rows.RemoveAt(s--);
                }
                string connn = con;
                SqlConnection connec = new SqlConnection(connn);
                connec.Open();
                string s1 = textBox1.Text;
                string s2 = comboBox1.Text;
                string s3 = textBox2.Text;
                string s4 = textBox3.Text;
                string s5 = comboBox2.Text;
                string s6 = textBox4.Text;
                string s7 = textBox5.Text;
                string s8 = "";
                string s9 = textBox7.Text;
                if (s1 == "" || s2 == "" || s3 == "" || s4 == "" || s5 == "" || s6 == "" || s7 == "" || s9 == "")
                {
                    MessageBox.Show("请输入完整信息！");
                    this.textBox1.Focus();
                }
                else
                {
                    string sql = String.Format("insert into TeacherVisit values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", s1, s2, s3, s4, s5, s6, s7, s8, s9);
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
                        textBox7.Clear();
                        comboBox1.Text = "";
                        comboBox2.Text = "";
                    }
                }
                string sql2 = String.Format("select * from TeacherVisit");
                SqlCommand command2 = new SqlCommand(sql2, connec);
                SqlDataReader reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewRow Row = new DataGridViewRow();
                    int i = dataGridView1.Rows.Add(Row);
                    this.dataGridView1.Rows[i].Cells[0].Value = String.Format("{0}", reader[0]);
                    this.dataGridView1.Rows[i].Cells[1].Value = String.Format("{0}", reader[1]);
                    this.dataGridView1.Rows[i].Cells[2].Value = String.Format("{0}", reader[2]);
                    this.dataGridView1.Rows[i].Cells[3].Value = String.Format("{0}", reader[3]);
                    this.dataGridView1.Rows[i].Cells[4].Value = String.Format("{0}", reader[4]);
                    this.dataGridView1.Rows[i].Cells[5].Value = String.Format("{0}", reader[5]);
                    this.dataGridView1.Rows[i].Cells[6].Value = String.Format("{0}", reader[6]);
                    this.dataGridView1.Rows[i].Cells[7].Value = String.Format("{0}", reader[7]);
                    this.dataGridView1.Rows[i].Cells[8].Value = String.Format("{0}", reader[8]);
                }
                reader.Close();
            }
            catch (Exception ee) { MessageBox.Show("数据库中缺少相应的表！"); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button7.Enabled = true;

            string name = textBox1.Text;
            string certificate = comboBox1.Text;
            string num = textBox2.Text;

            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            //textBox6.Enabled = false;
            textBox7.Enabled = false;
            comboBox2.Enabled = false;


            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            if (num != "" && name != "" && certificate != "")
            {
                string sql = String.Format("select * from TeacherVisit where 教师姓名='{0}' and 证件类型='{1}' and 证件号码='{2}'", name, certificate, num);
                SqlCommand command = new SqlCommand(sql, connec);
                connec.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    m1 = String.Format("{0}", reader[0]);
                    m2 = String.Format("{0}", reader[1]);
                    m3 = String.Format("{0}", reader[2]);
                    m4 = String.Format("{0}", reader[3]);
                    m5 = String.Format("{0}", reader[4]);
                    m6 = String.Format("{0}", reader[5]);
                    m7 = String.Format("{0}", reader[6]);
                    m8 = String.Format("{0}", reader[7]);
                    m9 = String.Format("{0}", reader[8]);

                     textBox1.Text = String.Format("{0}", reader[0]);
                     comboBox1.Text  = String.Format("{0}", reader[1]);
                     textBox2.Text= String.Format("{0}", reader[2]);
                     textBox3.Text = String.Format("{0}", reader[3]);
                     comboBox2.Text= String.Format("{0}", reader[4]);
                     textBox4.Text= String.Format("{0}", reader[5]);
                     textBox5.Text= String.Format("{0}", reader[6]);
                     textBox6.Text= String.Format("{0}", reader[7]);
                     textBox7.Text= String.Format("{0}", reader[8]);

                }
                reader.Close();
            }
            else
            {
                MessageBox.Show("请输入(姓名+证件类型+证件号码)！");
                textBox1.Focus();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;


            button4.Enabled = false;
            button5.Enabled = false;
            string k1 = textBox1.Text;
            string k2 = comboBox1.Text;
            string k3 = textBox2.Text;
            string k4 = textBox3.Text;
            string k5 = comboBox2.Text;
            string k6 = textBox4.Text;
            string k7 = textBox5.Text;
            string k8 = textBox6.Text;
            string k9 = textBox7.Text;

            string[] m = new string[9];
            if (!k1.Equals(m1)) { m[0] = textBox1.Text; } else m[0] = " ";
            if (!k2.Equals(m2)) { m[1] = comboBox1.Text; } else m[1] = " ";
            if (!k3.Equals(m3)) { m[2] = textBox2.Text;} else m[2] = " ";
            if (!k4.Equals(m4)) { m[3] = textBox3.Text; } else m[3] = " ";
            if (!k5.Equals(m5)) { m[4] = comboBox2.Text; } else m[4] = " ";
            if (!k6.Equals(m6)) { m[5] = textBox4.Text; } else m[5] = " ";
            if (!k7.Equals(m7)) { m[6] = textBox5.Text;} else m[6] = " ";
            if (!k8.Equals(m8)) { m[7] = textBox6.Text; } else m[7] = " ";
            if (!k9.Equals(m9)) { m[8] = textBox7.Text;} else m[8] = " ";
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("请选择要修改的记录！");
            }
            else
            {
                for (int w = 0; w < m.Length; w++)
                {
                    if (m[w] != " ")
                    {
                        if (w == 0)
                        {
                            string sql = String.Format("update TeacherVisit set 教师姓名='{0}' where 证件号码='{1}'", k1, m3);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                        }
                        else if (w == 1)
                        {
                            string sql = String.Format("update TeacherVisit set 证件类型='{0}' where 证件号码='{1}'", k2, m3);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                        }
                        else if (w == 2)
                        {
                            string sql = String.Format("update TeacherVisit set 证件号码='{0}' where 证件号码='{1}'", k3, m3);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                            k3 = m3;
                        }
                        else if (w == 3)
                        {
                            string sql = String.Format("update TeacherVisit set 楼号='{0}' where 证件号码='{1}'", k4, m3);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                          
                        }
                        else if (w == 4)
                        {
                            string sql = String.Format("update TeacherVisit set 学院='{0}' where 证件号码='{1}'", k5, m3);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                        }
                        else if (w == 5)
                        {
                            string sql = String.Format("update TeacherVisit set 专业='{0}' where 证件号码='{1}'", k6, m3);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                        }
                        else if (w == 6)
                        {
                            string sql = String.Format("update TeacherVisit set 进入时间='{0}' where 证件号码='{1}'", k7, m3);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                        }
                        else if (w == 7)
                        {
                            string sql = String.Format("update TeacherVisit set 离开时间='{0}' where 证件号码='{1}'", k8, m3);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                        }
                        else if (w == 8)
                        {
                            string sql = String.Format("update TeacherVisit set 备注='{0}' where 证件号码='{1}'", k9, m3);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            int i = dataGridView1.RowCount - 1;
            dataGridView1.EndEdit();
            for (int s = 0; s < i; s++)
            {
                if (dataGridView1.Rows[s].IsNewRow) break;
                dataGridView1.Rows.RemoveAt(s--);
            }

            string sql2 = String.Format("select * from TeacherVisit");
            SqlCommand command2 = new SqlCommand(sql2, connec);
            SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                DataGridViewRow Row = new DataGridViewRow();
                int s = dataGridView1.Rows.Add(Row);
                this.dataGridView1.Rows[s].Cells[0].Value = String.Format("{0}", reader[0]);
                this.dataGridView1.Rows[s].Cells[1].Value = String.Format("{0}", reader[1]);
                this.dataGridView1.Rows[s].Cells[2].Value = String.Format("{0}", reader[2]);
                this.dataGridView1.Rows[s].Cells[3].Value = String.Format("{0}", reader[3]);
                this.dataGridView1.Rows[s].Cells[4].Value = String.Format("{0}", reader[4]);
                this.dataGridView1.Rows[s].Cells[5].Value = String.Format("{0}", reader[5]);
                this.dataGridView1.Rows[s].Cells[6].Value = String.Format("{0}", reader[6]);
                this.dataGridView1.Rows[s].Cells[7].Value = String.Format("{0}", reader[7]);
                this.dataGridView1.Rows[s].Cells[8].Value = String.Format("{0}", reader[8]);
            }
            reader.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int result;
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("请选择要删除的记录！");
                textBox1.Focus();
            }
            else
            {
                string sql = String.Format("delete from TeacherVisit where 证件号码='{0}'", m3);
                SqlCommand command = new SqlCommand(sql, connec);
                result = command.ExecuteNonQuery();
                if (result > 0) MessageBox.Show("删除成功！");
            }
            int i = dataGridView1.RowCount - 1;
            dataGridView1.EndEdit();
            for (int s = 0; s < i; s++)
            {
                if (dataGridView1.Rows[s].IsNewRow) break;
                dataGridView1.Rows.RemoveAt(s--);
            }
            string sql2 = String.Format("select * from TeacherVisit");
            SqlCommand command2 = new SqlCommand(sql2, connec);
            SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                DataGridViewRow Row = new DataGridViewRow();
                int s = dataGridView1.Rows.Add(Row);
                this.dataGridView1.Rows[s].Cells[0].Value = String.Format("{0}", reader[0]);
                this.dataGridView1.Rows[s].Cells[1].Value = String.Format("{0}", reader[1]);
                this.dataGridView1.Rows[s].Cells[2].Value = String.Format("{0}", reader[2]);
                this.dataGridView1.Rows[s].Cells[3].Value = String.Format("{0}", reader[3]);
                this.dataGridView1.Rows[s].Cells[4].Value = String.Format("{0}", reader[4]);
                this.dataGridView1.Rows[s].Cells[5].Value = String.Format("{0}", reader[5]);
                this.dataGridView1.Rows[s].Cells[6].Value = String.Format("{0}", reader[6]);
                this.dataGridView1.Rows[s].Cells[7].Value = String.Format("{0}", reader[7]);
                this.dataGridView1.Rows[s].Cells[8].Value = String.Format("{0}", reader[8]);
            }
            reader.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Text = Convert.ToString(DateTime.Now);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox6.Text = Convert.ToString(DateTime.Now);

            string t1 = textBox1.Text;
            string t2 = comboBox1.Text;
            string t3 = textBox2.Text;
            string t4 = textBox3.Text;
            string t5 = comboBox2.Text;
            string t6 = textBox4.Text;
            string t7 = textBox5.Text;
            string t8 = textBox6.Text;
            string t9 = textBox7.Text;


            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();


            string sql = String.Format("delete from TeacherVisit where 证件号码='{0}'", m3);
            SqlCommand command = new SqlCommand(sql, connec);
            command.ExecuteNonQuery();

            if (t1 == "" || t2 == "" || t3 == "" || t4 == "" || t5 == "" || t6 == "" || t7 == "" || t8 == "" || t9 == "")
            {
                MessageBox.Show("请选择对应的信息！");
            }
            else
            {
                string sql2 = String.Format("insert into TeacherVisit values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", t1, t2, t3, t4, t5, t6, t7, t8, t9);
                SqlCommand command2 = new SqlCommand(sql2, connec);
                int m = command2.ExecuteNonQuery();
                if (m > 0)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    comboBox1.Text = " ";
                    comboBox2.Text = " ";
                }
            }


            int i = dataGridView1.RowCount - 1;
            dataGridView1.EndEdit();
            for (int s = 0; s < i; s++)
            {
                if (dataGridView1.Rows[s].IsNewRow) break;
                dataGridView1.Rows.RemoveAt(s--);
            }

            string sql3 = String.Format("select * from TeacherVisit");
            SqlCommand command3 = new SqlCommand(sql3, connec);
            SqlDataReader reader = command3.ExecuteReader();
            while (reader.Read())
            {
                DataGridViewRow Row = new DataGridViewRow();
                int s = dataGridView1.Rows.Add(Row);
                this.dataGridView1.Rows[s].Cells[0].Value = String.Format("{0}", reader[0]);
                this.dataGridView1.Rows[s].Cells[1].Value = String.Format("{0}", reader[1]);
                this.dataGridView1.Rows[s].Cells[2].Value = String.Format("{0}", reader[2]);
                this.dataGridView1.Rows[s].Cells[3].Value = String.Format("{0}", reader[3]);
                this.dataGridView1.Rows[s].Cells[4].Value = String.Format("{0}", reader[4]);
                this.dataGridView1.Rows[s].Cells[5].Value = String.Format("{0}", reader[5]);
                this.dataGridView1.Rows[s].Cells[6].Value = String.Format("{0}", reader[6]);
                this.dataGridView1.Rows[s].Cells[7].Value = String.Format("{0}", reader[7]);
                this.dataGridView1.Rows[s].Cells[8].Value = String.Format("{0}", reader[8]);
            }
            reader.Close();
        }

    }
}
