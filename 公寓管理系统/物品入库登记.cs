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
    public partial class 物品入库登记 : Form
    {
        private Panel panel;
        private DataGridView dataGridView1;
        public string con=null;

        DataGridViewTextBoxColumn s1 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s2 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s3 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s4 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s5 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s6 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s7 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s8 = new DataGridViewTextBoxColumn();
        string m1 = null;
        string m2 = null;
        string m3 = null;
        string m4 = null;
        string m5 = null;
        string m6 = null;
        string m7 = null;
        string m8 = null;


        public 物品入库登记(Panel panel, DataGridView dataGridView,string con)
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
            textBox6.Clear();
            textBox7.Clear();
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


        }

        private void 物品入库登记_Load(object sender, EventArgs e)
        {
            CenterToParent();

            this.ControlBox = false;
            button5.Enabled = false;
            textBox6.Enabled = false;

            int p = dataGridView1.RowCount - 1;
            dataGridView1.EndEdit();
            for (int s = 0; s < p; s++)
            {
                if (dataGridView1.Rows[s].IsNewRow) break;
                dataGridView1.Rows.RemoveAt(s--);
            }

            CenterToParent();
            dataGridView1.Visible = true;
            dataGridView1.Location = new Point(23,24);
            dataGridView1.Size = new System.Drawing.Size(843, 300);



            s1.HeaderText = "入库单号";
            s1.Width = 80;
            dataGridView1.Columns.Add(s1);

            s2.HeaderText = "物品编号";
            s2.Width = 80;
            dataGridView1.Columns.Add(s2);

            s3.HeaderText = "物品名称";
            dataGridView1.Columns.Add(s3);

            s4.HeaderText = "单价";
            s4.Width = 60;
            dataGridView1.Columns.Add(s4);

            s5.HeaderText = "数量";
            s5.Width = 80;
            dataGridView1.Columns.Add(s5);

            s6.HeaderText = "金额";
            dataGridView1.Columns.Add(s6);

            s7.HeaderText = "入库时间";
            s7.Width = 150;
            dataGridView1.Columns.Add(s7);

            s8.HeaderText = "备注";
            s8.Width = 150;
            dataGridView1.Columns.Add(s8);


            try
            {
                string connn = con;
                SqlConnection connec = new SqlConnection(connn);
                connec.Open();
                string sql2 = String.Format("select * from FlatGoodsIn order by 入库单号");
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
                }
                reader.Close();
            }
            catch (Exception ee) { MessageBox.Show("数据库中缺少相应的表！"); }
        }

        private void 物品入库登记_FormClosed(object sender, FormClosedEventArgs e)
        {
            panel.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;

            string num = textBox1.Text;

            dateTimePicker1.Enabled = false;

            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox7.Enabled = false;

            string connn =con;
            SqlConnection connec = new SqlConnection(connn);
            if (num != "")
            {
                string sql = String.Format("select * from FlatGoodsIn where 入库单号='{0}'", num);
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

                    textBox1.Text = String.Format("{0}", reader[0]);
                    textBox2.Text = String.Format("{0}", reader[1]);
                    textBox3.Text = String.Format("{0}", reader[2]);
                    textBox4.Text = String.Format("{0}", reader[3]);
                    textBox5.Text= String.Format("{0}", reader[4]);
                    textBox6.Text= String.Format("{0}", reader[5]);
                    dateTimePicker1.Text= String.Format("{0}", reader[6]);
                    textBox7.Text = String.Format("{0}", reader[7]);
                }
                reader.Close();
            }
            else
            {
                MessageBox.Show("请输入入库单号编号！");
                textBox1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.Enabled = true;

                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox7.Enabled = true;

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
                string s3 = textBox3.Text;
                string s4 = textBox4.Text;
                string s5 = textBox5.Text;
                string s6 = textBox6.Text;
                string s7 = dateTimePicker1.Text;
                string s8 = textBox7.Text;


                string sqlss = String.Format("select * from FlatGoodsIn where 入库单号='{0}'", s1);
                SqlCommand commandss = new SqlCommand(sqlss, connec);
                SqlDataReader readerss = commandss.ExecuteReader();
                if (readerss.Read())
                {
                    MessageBox.Show("入库单号不能重复！");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                }

                else if (s1 == "" || s2 == "" || s3 == "" || s4 == "" || s6 == "" || s5 == "" || s7 == "" || s8 == "")
                {
                    MessageBox.Show("请输入完整信息！");
                    textBox1.Focus();
                }
                else
                {
                    readerss.Close();
                    string sql = String.Format("insert into FlatGoodsIn values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", s1, s2, s3, s4, s5, s6, s7, s8);
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

                        string sqls = String.Format("insert into Goods values('{0}','{1}','{2}','{3}','{4}')", s2, s3, s4, s5, "0");
                        SqlCommand commands = new SqlCommand(sqls, connec);
                        commands.ExecuteNonQuery();
                    }
                }
                readerss.Close();

                string sql2 = String.Format("select * from FlatGoodsIn order by 入库单号");
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
                }
                reader.Close();
            }
            catch (Exception ee) { MessageBox.Show("数据库中缺少相应的表！"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox7.Enabled = true;
            textBox5.Enabled = true;
            textBox4.Enabled = true;
            textBox3.Enabled = true;
            textBox2.Enabled = true;

            dateTimePicker1.Enabled = true;

            string k1 = textBox1.Text;
            string k2 = textBox2.Text;
            string k3 = textBox3.Text;
            string k4 = textBox4.Text;
            string k5 = textBox5.Text;
            string k6 = textBox6.Text;
            string k7 = Convert.ToString(dateTimePicker1.Text);
            string k8 = textBox7.Text;

            string[] m = new string[8];
            if (!k1.Equals(m1)) { m[0] = textBox1.Text; } else m[0] = " ";
            if (!k2.Equals(m2)) { m[1] = textBox2.Text; } else m[1] = " ";
            if (!k3.Equals(m3)) { m[2] = textBox3.Text;} else m[2] = " ";
            if (!k4.Equals(m4)) { m[3] = textBox4.Text;} else m[3] = " ";
            if (!k5.Equals(m5)) { m[4] = textBox5.Text; } else m[4] = " ";
            if (!k6.Equals(m6)) { m[5] = textBox6.Text; } else m[5] = " ";
            if (!k7.Equals(m7)) { m[6] = Convert.ToString(dateTimePicker1.Text); } else m[6] = " ";
            if (!k8.Equals(m8)) { m[7] = textBox7.Text; } else m[7] = " ";

            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == ""||textBox2.Text=="")
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
                            string sql = String.Format("update FlatGoodsIn set 入库单号='{0}' where 入库单号='{1}'", k1, m1);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                            m1 = k1;
                        }
                        else if (w == 1)
                        {
                            string sql = String.Format("update FlatGoodsIn set 物品编号='{0}' where 入库单号='{1}'", k2, m1);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                        }
                        else if (w == 2)
                        {
                            string sql = String.Format("update FlatGoodsIn set 物品名称='{0}' where 入库单号='{1}'", k3, m1);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                        }
                        else if (w == 3)
                        {
                            string sql = String.Format("update FlatGoodsIn set 单价='{0}' where 入库单号='{1}'", k4, m1);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                        }
                        else if (w == 4)
                        {
                            string sql = String.Format("update FlatGoodsIn set 数量='{0}' where 入库单号='{1}'", k5, m1);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                        }
                        else if (w == 5)
                        {
                            string sql = String.Format("update FlatGoodsIn set 金额='{0}' where 入库单号='{1}'", k6, m1);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                        }
                        else if (w == 6)
                        {
                            string sql = String.Format("update FlatGoodsIn set 入库时间='{0}' where 入库单号='{1}'", k7, m1);
                            SqlCommand command = new SqlCommand(sql, connec);
                            command.ExecuteNonQuery();
                        }
                        else if (w == 7)
                        {
                            string sql = String.Format("update FlatGoodsIn set 备注='{0}' where 入库单号='{1}'", k8, m1);
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

            string sql2 = String.Format("select * from FlatGoodsIn order by 入库单号");
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
            }
            reader.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int result;
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("请选择要删除的记录！");
                textBox1.Focus();
            }
            else
            {
                string sql = String.Format("delete from FlatGoodsIn where 入库单号='{0}'", m1);
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

            string sql2 = String.Format("select * from FlatGoodsIn order by 入库单号");
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
            }
            reader.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox5.Text == "") 
            {
                MessageBox.Show("请输入完整信息！");
                textBox1.Focus();
            }
            else
            textBox6.Text = Convert.ToString(Convert.ToDouble(textBox4.Text)*Convert.ToDouble(textBox5.Text));
        }
    }
}
