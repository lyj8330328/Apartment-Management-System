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
    public partial class 员工评分设置 : Form
    {
        private DataGridView dataGridView2;
        private Panel panel1;
        DataGridViewTextBoxColumn s1 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn s2 = new DataGridViewTextBoxColumn();

        public string con = null;
        public 员工评分设置(Panel panel1, DataGridView dataGridView,string con)
        {
            InitializeComponent();
            this.panel1 = panel1;
            this.dataGridView2 = dataGridView;
            this.con = con;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            panel1.Visible = true;
            dataGridView2.Visible = false;

            dataGridView2.Columns.Remove(s1);
            dataGridView2.Columns.Remove(s2);

        }

        private void 员工评分设置_Load(object sender, EventArgs e)
        {
            button4.Enabled = false;

            this.ControlBox = false;

            CenterToParent();
            dataGridView2.Visible = true;
            dataGridView2.Location = new Point(23,24);
            dataGridView2.Size = new System.Drawing.Size(641, 300);

            
            s1.HeaderText = "评分规则";
            s1.Width = 500;
            dataGridView2.Columns.Add(s1);
          
            s2.HeaderText = "分数";
            dataGridView2.Columns.Add(s2);

            try
            {
                string connn = con;
                SqlConnection connec = new SqlConnection(connn);
                connec.Open();
                string sql2 = String.Format("select * from ScoreRule");
                SqlCommand command2 = new SqlCommand(sql2, connec);
                SqlDataReader reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewRow Row = new DataGridViewRow();
                    int i = dataGridView2.Rows.Add(Row);
                    this.dataGridView2.Rows[i].Cells[0].Value = String.Format("{0}", reader[0]);
                    this.dataGridView2.Rows[i].Cells[1].Value = String.Format("{0}", reader[1]);
                }
                reader.Close();

                string sql3 = String.Format("select * from ScoreRule");
                SqlCommand command3 = new SqlCommand(sql3, connec);
                SqlDataReader reader1 = command3.ExecuteReader();
                while (reader1.Read())
                {
                    DataGridViewRow Row = new DataGridViewRow();
                    int y = dataGridView1.Rows.Add(Row);
                    this.dataGridView1.Rows[y].Cells[0].Value = String.Format("{0}", reader1[0]);
                    this.dataGridView1.Rows[y].Cells[1].Value = String.Format("{0}", reader1[1]);
                }
                reader1.Close();

            }
            catch (Exception ee) { MessageBox.Show("数据库中缺少相应的表！"); }
        }

        private void 员工评分设置_FormClosed(object sender, FormClosedEventArgs e)
        {
            panel1.Visible = true;
            dataGridView2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int z = dataGridView2.RowCount - 1;
                dataGridView2.EndEdit();
                for (int s = 0; s < z; s++)
                {
                    if (dataGridView2.Rows[s].IsNewRow) break;
                    dataGridView2.Rows.RemoveAt(s--);
                }

                int q = dataGridView1.RowCount - 1;
                dataGridView1.EndEdit();
                for (int i = 0; i < q; i++)
                {
                    if (dataGridView1.Rows[i].IsNewRow) break;
                    dataGridView1.Rows.RemoveAt(i--);
                }
                string connn = con;
                SqlConnection connec = new SqlConnection(connn);
                connec.Open();

                string s1 = textBox1.Text;
                string s2 = textBox2.Text;


                if (s1 == "" || s2 == "")
                {
                    MessageBox.Show("请输入完整信息！");
                    textBox1.Focus();
                }
                else
                {
                    string sql = String.Format("insert into ScoreRule values('{0}','{1}')", s1, s2);
                    SqlCommand command = new SqlCommand(sql, connec);
                    int s = command.ExecuteNonQuery();
                    if (s > 0)
                    {
                        MessageBox.Show("增加成功！");
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                }

                string sql2 = String.Format("select * from ScoreRule");
                SqlCommand command2 = new SqlCommand(sql2, connec);
                SqlDataReader reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewRow Row = new DataGridViewRow();
                    int w = dataGridView2.Rows.Add(Row);
                    this.dataGridView2.Rows[w].Cells[0].Value = String.Format("{0}", reader[0]);
                    this.dataGridView2.Rows[w].Cells[1].Value = String.Format("{0}", reader[1]);
                }
                reader.Close();

                string sql3 = String.Format("select * from ScoreRule");
                SqlCommand command3 = new SqlCommand(sql3, connec);
                SqlDataReader reader1 = command3.ExecuteReader();
                while (reader1.Read())
                {
                    DataGridViewRow Row = new DataGridViewRow();
                    int b = dataGridView1.Rows.Add(Row);
                    this.dataGridView1.Rows[b].Cells[0].Value = String.Format("{0}", reader1[0]);
                    this.dataGridView1.Rows[b].Cells[1].Value = String.Format("{0}", reader1[1]);
                }
                reader1.Close();
            }
            catch (Exception ee) { MessageBox.Show("数据库中缺少相应的表！"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int result;
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            string sm = dataGridView1.SelectedCells[0].Value.ToString();
                string sql = String.Format("delete from ScoreRule where 评分规则='{0}'", sm);
                SqlCommand command = new SqlCommand(sql, connec);
                result = command.ExecuteNonQuery();
                if (result > 0) MessageBox.Show("删除成功！");
                int i = dataGridView1.RowCount - 1;
                dataGridView1.EndEdit();
                for (int s = 0; s < i; s++)
                {
                    if (dataGridView1.Rows[s].IsNewRow) break;
                    dataGridView1.Rows.RemoveAt(s--);
                }

                int q = dataGridView2.RowCount - 1;
                dataGridView2.EndEdit();
                for (int s = 0; s < q; s++)
                {
                    if (dataGridView2.Rows[s].IsNewRow) break;
                    dataGridView2.Rows.RemoveAt(s--);
                }

                string sql2 = String.Format("select * from ScoreRule");
                SqlCommand command2 = new SqlCommand(sql2, connec);
                SqlDataReader reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewRow Row = new DataGridViewRow();
                    int w = dataGridView2.Rows.Add(Row);
                    this.dataGridView2.Rows[w].Cells[0].Value = String.Format("{0}", reader[0]);
                    this.dataGridView2.Rows[w].Cells[1].Value = String.Format("{0}", reader[1]);
                }
                reader.Close();

                string sql3 = String.Format("select * from ScoreRule");
                SqlCommand command3 = new SqlCommand(sql3, connec);
                SqlDataReader reader1 = command3.ExecuteReader();
                while (reader1.Read())
                {
                    DataGridViewRow Row = new DataGridViewRow();
                    int b = dataGridView1.Rows.Add(Row);
                    this.dataGridView1.Rows[b].Cells[0].Value = String.Format("{0}", reader1[0]);
                    this.dataGridView1.Rows[b].Cells[1].Value = String.Format("{0}", reader1[1]);
                }
                reader1.Close();
            
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button4.Enabled = true;
        }
    }
}
