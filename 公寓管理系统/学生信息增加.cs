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
    public partial class 学生信息增加 : Form
    {
        private Panel panel;
        public string con = null;
        private DataGridView dataGridView1;
        string m1 = null;
        string m2 = null;
        string m3 = null;
        string m4 = null;
        string m5 = null;
        string m6 = null;
        string m7 = null;
        string m8 = null;
        string m9 = null;
        string m10 = null;
        string m11 = null;
        DataGridViewTextBoxColumn s1 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s2 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s3 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s4 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s5 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s6 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s7 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s8 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s9 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s10 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s11 = new DataGridViewTextBoxColumn();
        public 学生信息增加(Panel panel, DataGridView dataGridView,string con)
        {
            InitializeComponent();
            this.panel = panel;
            this.dataGridView1 = dataGridView;
            this.con = con;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox6.Clear();
            textBox8.Clear();
            textBox9.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            panel.Visible = true;

            dataGridView1.Columns.Remove(s1);
            dataGridView1.Columns.Remove(s2);
            dataGridView1.Columns.Remove(s3);
            dataGridView1.Columns.Remove(s4);
            dataGridView1.Columns.Remove(s5);
            dataGridView1.Columns.Remove(s6);
            dataGridView1.Columns.Remove(s7);
            dataGridView1.Columns.Remove(s8);
            dataGridView1.Columns.Remove(s9);
            dataGridView1.Columns.Remove(s10);
            dataGridView1.Columns.Remove(s11);
        }

        private void 学生信息增加_Load(object sender, EventArgs e)
        {
            button5.Enabled = false;

            CenterToParent();

            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;

            this.ControlBox = false;

            dataGridView1.Visible = true;
            dataGridView1.Location = new Point(23,24);
            dataGridView1.Size = new System.Drawing.Size(1012, 400);

            s1.HeaderText = "学号";
            s1.Width = 80;
            dataGridView1.Columns.Add(s1);

            s2.HeaderText = "姓名";
            s2.Width = 70;
            dataGridView1.Columns.Add(s2);

            s3.HeaderText = "性别";
            s3.Width = 60;
            dataGridView1.Columns.Add(s3);

            s4.HeaderText = "年级";
            s4.Width = 60;
            dataGridView1.Columns.Add(s4);

            s5.HeaderText = "班级";
            s5.Width = 60;
            dataGridView1.Columns.Add(s5);

            s6.HeaderText = "学院";
            dataGridView1.Columns.Add(s6);
            s6.Width = 150;

            s7.HeaderText = "系";
            dataGridView1.Columns.Add(s7);
            s7.Width = 150;

            s8.HeaderText = "专业";
            s8.Width = 150;
            dataGridView1.Columns.Add(s8);

            s9.HeaderText = "楼号";
            s9.Width = 60;
            dataGridView1.Columns.Add(s9);

            s10.HeaderText = "寝室号";
            s10.Width = 70;
            dataGridView1.Columns.Add(s10);

            s11.HeaderText = "床号";
            s11.Width = 60;
            dataGridView1.Columns.Add(s11);


            try
            {
                string connn = con;
                SqlConnection connec = new SqlConnection(connn);
                connec.Open();
                string sql2 = String.Format("select * from StudentMessage order by 学号");
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
                    this.dataGridView1.Rows[i].Cells[9].Value = String.Format("{0}", reader[9]);
                    this.dataGridView1.Rows[i].Cells[10].Value = String.Format("{0}", reader[10]);
                }
                reader.Close();
            }
            catch (Exception ee) { MessageBox.Show("数据库中缺少相应的表！"); }

        }

        private void 学生信息增加_FormClosed(object sender, FormClosedEventArgs e)
        {
            panel.Visible = true;
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
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
                string s2 = textBox2.Text;
                string s3 = comboBox1.Text;
                string s4 = textBox3.Text;
                string s5 = textBox4.Text;
                string s6 = comboBox2.Text;
                string s7 = textBox5.Text;
                string s8 = textBox6.Text;
                string s9 = "";
                string s10 = "";
                string s11 = "";


                string sqls1 = String.Format("select * from Academy where 学院='{0}' and 系='{1}' and 专业='{2}'", s6, s7, s8);
                SqlCommand commands1 = new SqlCommand(sqls1, connec);
                SqlDataReader readers1 = commands1.ExecuteReader();
                if (!readers1.Read()) { MessageBox.Show("请重新核对学生学院、系、专业！"); }
                else
                {
                    readers1.Close();
                    string sqls = String.Format("select * from StudentMessage where 学号='{0}'", s1);
                    SqlCommand commands = new SqlCommand(sqls, connec);
                    SqlDataReader readers = commands.ExecuteReader();
                    if (readers.Read())
                    {
                        MessageBox.Show("学号不能重复！");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox7.Clear();
                        textBox6.Clear();
                        textBox8.Clear();
                        textBox9.Clear();
                        comboBox1.SelectedIndex = -1;
                    }
                    else if (s1 == "" || s2 == "" || s3 == "" || s4 == "" || s5 == "" || s6 == "" || s7 == "" || s8 == "")
                    {
                        MessageBox.Show("请输入完整信息！");
                        this.textBox1.Focus();
                    }
                    else
                    {
                        readers.Close();
                        string sql = String.Format("insert into StudentMessage values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',"+
                        "'{8}','{9}','{10}')", s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11);
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
                            textBox7.Clear();
                            textBox6.Clear();
                            textBox8.Clear();
                            textBox9.Clear();
                            comboBox1.SelectedIndex = -1;
                        }
                    }


                    readers.Close();

                }
                readers1.Close();

                string sql2 = String.Format("select * from StudentMessage order by 学号");
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
                    this.dataGridView1.Rows[i].Cells[9].Value = String.Format("{0}", reader[9]);
                    this.dataGridView1.Rows[i].Cells[10].Value = String.Format("{0}", reader[10]);
                }
                reader.Close();
            }
            catch (Exception ee) { MessageBox.Show("数据库中缺少相应的表！"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            button5.Enabled = true;


            string num = textBox1.Text;
            string name = textBox2.Text;

            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;


            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            if (num != "" && name == "")
            {
                string sql = String.Format("select * from StudentMessage where 学号='{0}'", num);
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
                    m10 = String.Format("{0}", reader[9]);
                    m11 = String.Format("{0}", reader[10]);

                    textBox1.Text = String.Format("{0}", reader[0]);
                    textBox2.Text = String.Format("{0}", reader[1]);
                    comboBox1.Text = String.Format("{0}", reader[2]);
                    textBox3.Text = String.Format("{0}", reader[3]);
                    textBox4.Text = String.Format("{0}", reader[4]);
                    comboBox2.Text= String.Format("{0}", reader[5]);
                    textBox5.Text = String.Format("{0}", reader[6]);
                    textBox6.Text = String.Format("{0}", reader[7]);
                    textBox7.Text = String.Format("{0}", reader[8]);
                    textBox8.Text = String.Format("{0}", reader[9]);
                    textBox9.Text = String.Format("{0}", reader[10]);

                }
                reader.Close();
            }
            else if (num != "" && name != "")
            {
                string sql = String.Format("select * from StudentMessage where 学号='{0}' and  姓名='{1}'", num, name);
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
                    m10 = String.Format("{0}", reader[9]);
                    m11 = String.Format("{0}", reader[10]);

                    textBox1.Text = String.Format("{0}", reader[0]);
                    textBox2.Text = String.Format("{0}", reader[1]);
                    comboBox1.Text = String.Format("{0}", reader[2]);
                    textBox3.Text = String.Format("{0}", reader[3]);
                    textBox4.Text = String.Format("{0}", reader[4]);
                    comboBox2.Text = String.Format("{0}", reader[5]);
                    textBox5.Text = String.Format("{0}", reader[6]);
                    textBox6.Text = String.Format("{0}", reader[7]);
                    textBox7.Text = String.Format("{0}", reader[8]);
                    textBox8.Text = String.Format("{0}", reader[9]);
                    textBox9.Text = String.Format("{0}", reader[10]);
                }
                reader.Close();

            }
            else
            {
                MessageBox.Show("请输入(学号)或(学号+姓名)");
                textBox1.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            //textBox7.Enabled = true;
            //textBox8.Enabled = true;
            //textBox9.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;




            string k1 = textBox1.Text;
            string k2 = textBox2.Text;
            string k3 = comboBox1.Text;
            string k4 = textBox3.Text;
            string k5 = textBox4.Text;
            string k6 = comboBox2.Text;
            string k7 = textBox5.Text;
            string k8 = textBox6.Text;
            string k9 = textBox7.Text;
            string k10 = textBox8.Text;
            string k11 = textBox9.Text;


            string[] m = new string[11];
            if (!k1.Equals(m1)) { m[0] = textBox1.Text; } else m[0] = " ";
            if (!k2.Equals(m2)) { m[1] = textBox2.Text; } else m[1] = " ";
            if (!k3.Equals(m3)) { m[2] = comboBox1.Text; } else m[2] = " ";
            if (!k4.Equals(m4)) { m[3] = textBox3.Text; } else m[3] = " ";
            if (!k5.Equals(m5)) { m[4] = textBox4.Text; } else m[4] = " ";
            if (!k6.Equals(m6)) { m[5] = comboBox2.Text; } else m[5] = " ";
            if (!k7.Equals(m7)) { m[6] = textBox5.Text; } else m[6] = " ";
            if (!k8.Equals(m8)) { m[7] = textBox6.Text; } else m[7] = " ";
            if (!k9.Equals(m9)) { m[8] = textBox7.Text; } else m[8] = " ";
            if (!k10.Equals(m10)) { m[9] = textBox8.Text; } else m[9] = " ";
            if (!k11.Equals(m11)) { m[10] = textBox8.Text; } else m[10] = " ";
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("请选择要修改的记录！");
            }
         /*   else if (textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "") 
            {
                textBox7.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
            }*/
            else
            {
                for (int w = 0; w < m.Length; w++)
                {

                    if (m[w] != " ")
                    {
                        if (w == 0)
                        {
                            string sql = String.Format("update StudentMessage set 学号='{0}' where 学号='{1}'", k1, m1);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                            m1 = k1;
                        }
                        else if (w == 1)
                        {
                            string sql = String.Format("update StudentMessage set 姓名='{0}' where 学号='{1}'", k2, m1);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                        }
                        else if (w == 2)
                        {
                            string sql = String.Format("update StudentMessage set  性别='{0}' where 学号='{1}'", k3, m1);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                        }
                        else if (w == 3)
                        {
                            string sql = String.Format("update StudentMessage set 年级='{0}' where 学号='{1}'", k4, m1);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                        }
                        else if (w == 4)
                        {
                            string sql = String.Format("update StudentMessage set 班级='{0}' where 学号='{1}'", k5, m1);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                        }
                        else if (w == 5)
                        {
                            string sqls = String.Format("select * from Academy where 学院='{0}'", k6);
                            SqlCommand commands = new SqlCommand(sqls, connec);
                            int s = commands.ExecuteNonQuery();
                            if (s > 0)
                            {
                                string sql = String.Format("update StudentMessage set 学院='{0}' where 学号='{1}'", k6, m1);
                                SqlCommand command = new SqlCommand(sql, connec);
                                command.ExecuteNonQuery();
                            }
                            else 
                            {
                                MessageBox.Show("请重新核对学院！");
                            }
                        }
                        else if (w == 6)
                        {
                            string sqls = String.Format("select * from Academy where 系='{0}'", k7);
                            SqlCommand commands = new SqlCommand(sqls, connec);
                            int s = commands.ExecuteNonQuery();
                            if (s > 0)
                            {
                                string sql = String.Format("update StudentMessage set 系='{0}' where 学号='{1}'", k7, m1);
                                SqlCommand command = new SqlCommand(sql, connec);
                                command.ExecuteNonQuery();
                            }
                            else
                            {
                                MessageBox.Show("请重新核对系！");
                            }
                        }
                        else if (w == 7)
                        {
                            string sqls = String.Format("select * from Academy where 专业='{0}'", k8);
                            SqlCommand commands = new SqlCommand(sqls, connec);
                            int s = commands.ExecuteNonQuery();
                            if (s > 0)
                            {
                                string sql = String.Format("update StudentMessage set 专业='{0}' where 学号='{1}'", k8, m1);
                                SqlCommand command = new SqlCommand(sql, connec);
                                command.ExecuteNonQuery();
                            }
                            else
                            {
                                MessageBox.Show("请重新核对专业！");
                            }
                        }
                        else if (w == 8)
                        {
                            string sql = String.Format("update StudentMessage set 楼号='{0}' where 学号='{1}'", k9, m1);
                            SqlCommand command = new SqlCommand(sql, connec);
                            int s=command.ExecuteNonQuery();
                            if (s > 0) 
                            {
                                string sqls = String.Format("update StudentMessage set 寝室号='{0}', 床号='{1}' where 学号='{2}'", "","", m1);
                                SqlCommand commands = new SqlCommand(sqls, connec);
                                commands.ExecuteNonQuery();
                            }
                        }
                        else if (w == 9)
                        {
                            string sql = String.Format("update StudentMessage set 寝室号='{0}' where 学号='{1}'", k10, m1);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                        }
                        else if (w == 10)
                        {
                            string sql = String.Format("update StudentMessage set 床号='{0}' where 学号='{1}'", k11, m1);
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

            string sql2 = String.Format("select * from StudentMessage order by 学号");
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
                this.dataGridView1.Rows[s].Cells[9].Value = String.Format("{0}", reader[9]);
                this.dataGridView1.Rows[s].Cells[10].Value = String.Format("{0}", reader[10]);
            }
            reader.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int result;
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("请选择要删除的记录！");
                textBox1.Focus();
            }
            else
            {
                string x = null;
                string x2 = null;
                string x3 = null;

                string sqls = String.Format("select * from StudentMessage where 学号='{0}'", m1);
                SqlCommand commands = new SqlCommand(sqls, connec);
                SqlDataReader readers = commands.ExecuteReader();
                while (readers.Read())
                {
                    x = String.Format("{0}", readers[8]);
                    x2 = String.Format("{0}", readers[9]);
                    x3 = String.Format("{0}", readers[10]);
                }
                readers.Close();

                string sqlss = String.Format("update Flat set 是否入住='{0}' where 楼号='{1}' and 寝室号='{2}' and 床号='{3}'", "", x, x2, x3);
                SqlCommand commandss = new SqlCommand(sqlss, connec);
                commandss.ExecuteNonQuery();

                string sql = String.Format("delete from StudentMessage where 学号='{0}'", m1);
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

            string sql2 = String.Format("select * from StudentMessage order by 学号");
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
                this.dataGridView1.Rows[s].Cells[9].Value = String.Format("{0}", reader[9]);
                this.dataGridView1.Rows[s].Cells[10].Value = String.Format("{0}", reader[10]);
            }
            reader.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.Text=" ";

        }




    }
}
