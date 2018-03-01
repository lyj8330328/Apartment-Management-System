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
    public partial class 寝室状态 : Form
    {
        private Panel panel;
        public string con = null;
        public 寝室状态(Panel panel,string con)
        {
            InitializeComponent();
            this.panel = panel;
            this.con = con;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            panel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            int z = dataGridView1.RowCount - 1;
            dataGridView1.EndEdit();
            for (int s = 0; s < z; s++)
            {
                if (dataGridView1.Rows[s].IsNewRow) break;
                dataGridView1.Rows.RemoveAt(s--);
            }

        }

        private void 寝室状态_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void 寝室状态_FormClosed(object sender, FormClosedEventArgs e)
        {
            panel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connn = con;
                SqlConnection connec = new SqlConnection(connn);

                string num1 = textBox1.Text;
                string num2 = textBox2.Text;

                string sql = String.Format("select * from StudentMessage where 楼号='{0}' and 寝室号='{1}' order by 学号", num1, num2);
                SqlCommand command = new SqlCommand(sql, connec);
                connec.Open();
                SqlDataReader reader = command.ExecuteReader();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int z = dataGridView1.RowCount - 1;
            dataGridView1.EndEdit();
            for (int s = 0; s < z; s++)
            {
                if (dataGridView1.Rows[s].IsNewRow) break;
                dataGridView1.Rows.RemoveAt(s--);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int z = dataGridView1.RowCount - 1;
            dataGridView1.EndEdit();
            for (int s = 0; s < z; s++)
            {
                if (dataGridView1.Rows[s].IsNewRow) break;
                dataGridView1.Rows.RemoveAt(s--);
            }
        }
    }
}
