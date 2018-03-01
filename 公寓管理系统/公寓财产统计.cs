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
    public partial class 公寓财产统计 : Form
    {
        private Panel panel;
        public string con;
        public 公寓财产统计(Panel panel,string con)
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

        private void 公寓财产登记_Load(object sender, EventArgs e)
        {
            CenterToParent();
            this.ControlBox = false;
        }

        private void 公寓财产登记_FormClosed(object sender, FormClosedEventArgs e)
        {
            panel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                string[] num = new string[100];         //存放物品编号
                string[] name = new string[100];        //存放物品名称
                string[] price = new string[100];       //存放物品价格
                string[] s = new string[100];           //存放物品现有数量

                string connn = con;                    //得到数据库连接字符串
                SqlConnection connec = new SqlConnection(connn); //创建connection对象
                connec.Open();                                   //打开连接
                //先从Goods表中读取物品编号、物品名称、物品价格等信息
                string sql4 = String.Format("select * from Goods");
                SqlCommand command4 = new SqlCommand(sql4, connec);
                SqlDataReader reader4 = command4.ExecuteReader();

                while (reader4.Read())
                {
                    num[i] = String.Format("{0}", reader4[0]);
                    name[i] = String.Format("{0}", reader4[1]);
                    price[i] = String.Format("{0}", reader4[2]);
                    i++;
                }
                reader4.Close();

                for (int y = 0; y < i; y++)
                {
                    //根据已经查询到物品信息，再从FlatGoodsIn表中得到物品现有数量的信息
                    string sql = String.Format("select * from FlatGoodsIn where 物品编号='{0}' and 物品名称='{1}' and 单价='{2}'",
                        num[y], name[y], price[y]);
                    SqlCommand command = new SqlCommand(sql, connec);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        s[y] = String.Format("{0}", reader[4]);
                    }
                    reader.Close();

                    //更新Goods表中现有数量信息
                    string sql2 = String.Format("update Goods set 现有数量='{0}' where 物品编号='{1}'", s[y], num[y]);
                    SqlCommand command2 = new SqlCommand(sql2, connec);
                    command2.ExecuteNonQuery();
                }

                //将Goods表中的信息显示到屏幕上
                string sql5 = String.Format("select * from Goods order by 物品编号");
                SqlCommand command5 = new SqlCommand(sql5, connec);
                SqlDataReader reader5 = command5.ExecuteReader();
                while (reader5.Read())
                {
                    DataGridViewRow Row = new DataGridViewRow();
                    int b = dataGridView1.Rows.Add(Row);
                    this.dataGridView1.Rows[b].Cells[0].Value = String.Format("{0}", reader5[0]);
                    this.dataGridView1.Rows[b].Cells[1].Value = String.Format("{0}", reader5[1]);
                    this.dataGridView1.Rows[b].Cells[2].Value = String.Format("{0}", reader5[2]);
                    this.dataGridView1.Rows[b].Cells[3].Value = String.Format("{0}", reader5[3]);
                    this.dataGridView1.Rows[b].Cells[4].Value = String.Format("{0}", reader5[4]);
                }
                reader5.Close();
            }
           catch (Exception ee) { MessageBox.Show("数据库中缺少相应的表！"); }
        }
    }
}
