using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace 公寓管理系统
{
    public partial class 公寓管理系统 : Form
    {

        int state = 1;
        public string name = null;
        string connnn = null;
        string account = null;

        public 公寓管理系统(string account)
        {
            InitializeComponent();
            this.account = account;
        }
        void show() {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;

            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox21.Visible = false;
            label1.Visible = false;
            label11.Visible = false;
            label12.Visible = false;

            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;

            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
        
        
        dataGridView1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            byte[] byData = new byte[100];
            char[] charData = new char[1000];

            byte[] byData2 = new byte[100];
            char[] charData2 = new char[1000];

            string s = null;



            CenterToScreen();
            show();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            MaximizeBox = false;

            try
            {
                FileStream file = new FileStream("数据库连接字符串.txt", FileMode.Open);
                file.Seek(0, SeekOrigin.Begin);
                file.Read(byData, 0, 100); //byData传进来的字节数组,用以接受FileStream对象中的数据,第2个参数是字节数组中开始写入数据的位置,它通常是0,表示从数组的开端文件中向数组写数据,最后一个参数规定从文件读多少字符.
                Decoder d = Encoding.Default.GetDecoder();
                d.GetChars(byData, 0, byData.Length, charData, 0);

                for (int i = 0; i < charData.Length; i++)
                {
                    name += charData[i];
                }
                //MessageBox.Show(name);
                file.Close();
            }
            catch (Exception ee) 
            {
                MessageBox.Show("请连接数据库！");
            }

            try
            {
                FileStream files = new FileStream("建立数据库表.txt", FileMode.Open);
                files.Seek(0, SeekOrigin.Begin);
                files.Read(byData2, 0, 100); //byData传进来的字节数组,用以接受FileStream对象中的数据,第2个参数是字节数组中开始写入数据的位置,它通常是0,表示从数组的开端文件中向数组写数据,最后一个参数规定从文件读多少字符.
                Decoder d = Encoding.Default.GetDecoder();
                d.GetChars(byData, 0, byData2.Length, charData, 0);

                for (int i = 0; i < charData2.Length; i++)
                {
                    s += charData2[i];
                }
                //MessageBox.Show(name);
                files.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("请建立数据库表！");
            }


        }

        public string connection() 
        {
            
                string name = null;
                byte[] byData = new byte[100];
                char[] charData = new char[1000];
                FileStream file = new FileStream("数据库连接字符串.txt", FileMode.Open);
                file.Seek(0, SeekOrigin.Begin);
                file.Read(byData, 0, 100); //byData传进来的字节数组,用以接受FileStream对象中的数据,第2个参数是字节数组中开始写入数据的位置,它通常是0,表示从数组的开端文件中向数组写数据,最后一个参数规定从文件读多少字符.
                Decoder d = Encoding.Default.GetDecoder();
                d.GetChars(byData, 0, byData.Length, charData, 0);

                for (int i = 0; i < charData.Length; i++)
                {
                    name += charData[i];
                }
                //MessageBox.Show(name);
                file.Close();

                return name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show();

            pictureBox1.Visible = true;
            label5.Visible = true;
            pictureBox1.Location = new Point(54, 30);
            label5.Location = new Point(54, 110);

            pictureBox2.Visible = true;
            label6.Visible = true;
            pictureBox2.Location = new Point(310, 29);
            label6.Location = new Point(309, 110);

            pictureBox3.Visible = true;
            label7.Visible = true;
            pictureBox3.Location = new Point(566, 29);
            label7.Location = new Point(564, 110);

            pictureBox4.Visible = true;
            label8.Visible = true;
            pictureBox4.Location = new Point(56, 197);
            label8.Location = new Point(54, 277);

            pictureBox5.Visible = true;
            label9.Visible = true;
            pictureBox5.Location = new Point(300, 188);
            label9.Location = new Point(309, 277);

            pictureBox6.Visible = true;
            label10.Visible = true;
            pictureBox6.Location = new Point(567, 197);
            label10.Location = new Point(564, 273);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            show();

            pictureBox7.Visible = true;
            label11.Visible = true;
            pictureBox7.Location = new Point(143, 115);
            label11.Location = new Point(151, 199);

            pictureBox21.Visible = true;
            label1.Visible = true;
            pictureBox21.Location = new Point(300, 115);
            label1.Location = new Point(310, 199);

            pictureBox8.Visible = true;
            label12.Visible = true;
            pictureBox8.Location = new Point(468, 115);
            label12.Location = new Point(461, 196);
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            show();

            pictureBox9.Visible = true;
            label13.Visible = true;
            pictureBox9.Location = new Point(54, 30);
            label13.Location = new Point(54, 110);

            pictureBox10.Visible = true;
            label14.Visible = true;
            pictureBox10.Location = new Point(310, 29);
            label14.Location = new Point(320, 110);

            pictureBox11.Visible = true;
            label15.Visible = true;
            pictureBox11.Location = new Point(566, 29);
            label15.Location = new Point(564, 110);

            pictureBox12.Visible = true;
            label16.Visible = true;
            pictureBox12.Location = new Point(56, 197);
            label16.Location = new Point(54, 277);

            pictureBox13.Visible = true;
            label17.Visible = true;
            pictureBox13.Location = new Point(312, 188);
            label17.Location = new Point(310, 277);

            pictureBox14.Visible = true;
            label18.Visible = true;
            pictureBox14.Location = new Point(567, 197);
            label18.Location = new Point(564, 273);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            show();

            pictureBox15.Visible = true;
            label19.Visible = true;
            pictureBox15.Location = new Point(54, 30);
            label19.Location = new Point(54, 110);

            pictureBox16.Visible = true;
            label20.Visible = true;
            pictureBox16.Location = new Point(310, 29);
            label20.Location = new Point(309, 110);

            pictureBox17.Visible = true;
            label21.Visible = true;
            pictureBox17.Location = new Point(566, 29);
            label21.Location = new Point(564, 110);

            pictureBox18.Visible = true;
            label22.Visible = true;
            pictureBox18.Location = new Point(56, 197);
            label22.Location = new Point(63, 277);

            pictureBox19.Visible = true;
            label23.Visible = true;
            pictureBox19.Location = new Point(310, 188);
            label23.Location = new Point(309, 277);

            pictureBox20.Visible = true;
            label24.Visible = true;
            pictureBox20.Location = new Point(567, 197);
            label24.Location = new Point(574, 273);
            
        }

        

        private void 公寓管理系统_FormClosing(object sender, FormClosingEventArgs e)
        {
          if (state == 1)
            {
               
                MessageBoxButtons m1 = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("确定要退出吗？", "退出系统", m1, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;

                }
                 
               
            }
            
            
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = 0;
            MessageBoxButtons m1 = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要退出吗？", "退出系统", m1, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.show();

            }
             
            
        }

        private void 连接数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f1 = new 连接数据库(connnn);
            f1.Show();
        }

        private void 建立数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = connection();
            Form f1 = new 建立数据库表(name);
            f1.Show();
        }

        private void 数据库备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = connection();
            Form f1 = new 数据库备份(name);
            f1.Show();
        }

        private void 数据库恢复ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = connection();
            Form f1 = new 数据库恢复(name);
            f1.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowDialog();
            MessageBox.Show(folderDlg.SelectedPath);
        }

        private void 业务帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f1 = new 学生管理系统帮助();
            f1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = connection();
                panel1.Visible = false;
                Form f1 = new 公寓基本设置(panel1, dataGridView1, name);
                f1.Show();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                string name = connection();

                panel1.Visible = false;
                Form f1 = new 员工评分设置(panel1, dataGridView1, name);
                f1.Show();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                string name = connection();
                panel1.Visible = false;
                Form f1 = new 院系专业设置(panel1, dataGridView1, name);
                f1.Show();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                string name = connection();
                panel1.Visible = false;
                Form f1 = new 物业人员信息(panel1, dataGridView1, name);
                f1.Show();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); } 
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                string name = connection();
                panel1.Visible = false;
                Form f1 = new 员工分数录入(panel1, dataGridView1, name);
                f1.Show();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
                string name = connection();
                panel1.Visible = false;
                Form f1 = new 员工基本资料(panel1, dataGridView1, name);
                f1.Show();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                string name = connection();
                panel1.Visible = false;
                Form f1 = new 学生信息增加(panel1, dataGridView1, name);
                f1.Show();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            try
            {
                string name = connection();
                panel1.Visible = false;
                Form f1 = new 学生住宿统计(panel1, name);
                f1.Show();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            try
            {
                string name = connection();
                panel1.Visible = false;
                Form f1 = new 宿舍报修(panel1, dataGridView1, name);
                f1.Show();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            try
            {
                string name = connection();
                panel1.Visible = false;
                Form f1 = new 宿舍维修施工(panel1, dataGridView1, name);
                f1.Show();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

            try
            {
                string name = connection();
                panel1.Visible = false;
                Form f1 = new 公寓财产统计(panel1, name);
                f1.Show();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            try
            {
                string name = connection();
                panel1.Visible = false;
                Form f1 = new 宿舍物品更换(panel1, dataGridView1, name);
                f1.Show();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            try
            {
                string name = connection();
                panel1.Visible = false;
                Form f1 = new 物品出库登记(panel1, dataGridView1, name);
                f1.Show();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            try
            {
                string name = connection();
                panel1.Visible = false;
                Form f1 = new 物品入库登记(panel1, dataGridView1, name);
                f1.Show();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            try
            {
                string name = connection();
                panel1.Visible = false;
                Form f1 = new 外来人员登记(panel1, dataGridView1, name);
                f1.Show();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            try
            {
                string name = connection();
                panel1.Visible = false;
                Form f1 = new 教师来访登记(panel1, dataGridView1, name);
                f1.Show();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            try
            {
                string name = connection();
                panel1.Visible = false;
                Form f1 = new 学生晚归登记(panel1, dataGridView1, name);
                f1.Show();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            try
            {
                string name = connection();
                panel1.Visible = false;
                Form f1 = new 寝室状态(panel1, name);
                f1.Show();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            try
            {
                string name = connection();
                panel1.Visible = false;
                Form f1 = new 住宿信息查询(panel1, name);
                f1.ShowDialog();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            try
            {
                string name = connection();
                panel1.Visible = false;
                Form f1 = new 宿舍分配(panel1, dataGridView1, name);
                f1.Show();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(DateTime.Now);
        }


        private void 切换用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(delegate { Application.Run(new 登录窗体()); }));
            t.Start();
            this.Dispose(true);
        }

        private void 退出系统ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                Form f1 = new 修改密码(account,name);
                f1.Show();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            try
            {
                string name = connection();
                panel1.Visible = false;
                Form f1 = new 宿舍更换(panel1, dataGridView1, name);
                f1.Show();
            }
            catch (Exception ee) { MessageBox.Show("没有连接数据库！"); }
        }



   



        

       







    }
}
