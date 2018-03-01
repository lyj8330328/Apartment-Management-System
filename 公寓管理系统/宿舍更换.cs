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
    public partial class 宿舍更换 : Form
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
        public 宿舍更换(Panel panel, DataGridView dataGridView, string con)
        {
            InitializeComponent();
            this.panel = panel;
            this.dataGridView1 = dataGridView;
            this.con = con;
        }

        private void 宿舍更换_Load(object sender, EventArgs e)
        {
            CenterToParent();

            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;

            button2.Enabled = false;
            this.ControlBox = false;

            dataGridView1.Visible = true;
            dataGridView1.Location = new Point(23, 24);
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

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            string num = textBox1.Text;
            string name = textBox2.Text;

            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;


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
                    textBox3.Text = String.Format("{0}", reader[2]);
                    textBox4.Text = String.Format("{0}", reader[3]);
                    textBox5.Text = String.Format("{0}", reader[4]);
                    textBox6.Text = String.Format("{0}", reader[5]);
                    textBox7.Text = String.Format("{0}", reader[6]);
                    textBox8.Text = String.Format("{0}", reader[7]);
                    textBox9.Text = String.Format("{0}", reader[8]);
                    textBox10.Text = String.Format("{0}", reader[9]);
                    textBox11.Text = String.Format("{0}", reader[10]);

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
                    textBox3.Text = String.Format("{0}", reader[2]);
                    textBox4.Text = String.Format("{0}", reader[3]);
                    textBox5.Text = String.Format("{0}", reader[4]);
                    textBox6.Text = String.Format("{0}", reader[5]);
                    textBox7.Text = String.Format("{0}", reader[6]);
                    textBox8.Text = String.Format("{0}", reader[7]);
                    textBox9.Text = String.Format("{0}", reader[8]);
                    textBox10.Text = String.Format("{0}", reader[9]);
                    textBox11.Text = String.Format("{0}", reader[10]);
                }
                reader.Close();

            }
            else
            {
                MessageBox.Show("请输入(学号)或(学号+姓名)");
                textBox1.Focus();
            }
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

        private void 宿舍更换_FormClosed(object sender, FormClosedEventArgs e)
        {
            panel.Visible = true;
            dataGridView1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;

            string k1 = textBox9.Text;
            string k2 = textBox10.Text;
            string k3 = textBox11.Text;
            string b = null;
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            string sql = String.Format("select 是否入住 from Flat where 寝室号='{0}' and 床号='{1}'",k2,k3);
            SqlCommand command = new SqlCommand(sql, connec);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                b = String.Format("{0}", reader[0]);
            }
            reader.Close();
            string num = null;
            string sqll = String.Format("select 楼号 from FlatMessage");
            SqlCommand commandl = new SqlCommand(sqll, connec);
            SqlDataReader readerl = commandl.ExecuteReader();
            while (readerl.Read())
            {
                num = String.Format("{0}", readerl[0]);
            }
            readerl.Close();

                if ((!k1.Equals(m9)||!k2.Equals(m10)||!k3.Equals(m11))&&b.Equals("是")) { MessageBox.Show("该床位已经入住，请选择其他床位！"); }
                else if (k1!=""&&!k1.Equals(num)) { MessageBox.Show("本公寓楼号为" + num + ",请重新输入!"); }
                else 
                {
                    string sqls = String.Format("update StudentMessage set 楼号='{0}',寝室号='{1}',床号='{2}' where 学号='{3}'", k1,k2,k3, m1);
                    SqlCommand commands = new SqlCommand(sqls, connec);
                    commands.ExecuteNonQuery();


                    string sql1 = String.Format("update Flat set 是否入住='{0}' where 寝室号='{1}' and 床号='{2}'", "是", k2,k3);
                    SqlCommand command1 = new SqlCommand(sql1, connec);
                    command1.ExecuteNonQuery();

                    string sql2 = String.Format("update Flat set 是否入住='{0}' where 寝室号='{1}' and 床号='{2}'", "", m10, m11);
                    SqlCommand command2 = new SqlCommand(sql2, connec);
                    command2.ExecuteNonQuery();
                
                }
            
        


            int i = dataGridView1.RowCount - 1;
            dataGridView1.EndEdit();
            for (int s = 0; s < i; s++)
            {
                if (dataGridView1.Rows[s].IsNewRow) break;
                dataGridView1.Rows.RemoveAt(s--);
            }

            string sql3 = String.Format("select * from StudentMessage order by 学号");
            SqlCommand command3 = new SqlCommand(sql3, connec);
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                DataGridViewRow Row = new DataGridViewRow();
                int s = dataGridView1.Rows.Add(Row);
                this.dataGridView1.Rows[s].Cells[0].Value = String.Format("{0}", reader3[0]);
                this.dataGridView1.Rows[s].Cells[1].Value = String.Format("{0}", reader3[1]);
                this.dataGridView1.Rows[s].Cells[2].Value = String.Format("{0}", reader3[2]);
                this.dataGridView1.Rows[s].Cells[3].Value = String.Format("{0}", reader3[3]);
                this.dataGridView1.Rows[s].Cells[4].Value = String.Format("{0}", reader3[4]);
                this.dataGridView1.Rows[s].Cells[5].Value = String.Format("{0}", reader3[5]);
                this.dataGridView1.Rows[s].Cells[6].Value = String.Format("{0}", reader3[6]);
                this.dataGridView1.Rows[s].Cells[7].Value = String.Format("{0}", reader3[7]);
                this.dataGridView1.Rows[s].Cells[8].Value = String.Format("{0}", reader3[8]);
                this.dataGridView1.Rows[s].Cells[9].Value = String.Format("{0}", reader3[9]);
                this.dataGridView1.Rows[s].Cells[10].Value = String.Format("{0}", reader3[10]);
            }
            reader3.Close();
          

        }

        private void button4_Click(object sender, EventArgs e)
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
            textBox10.Clear();
            textBox11.Clear();
        }

        
    }
}
