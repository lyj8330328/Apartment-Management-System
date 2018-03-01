using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Threading;
namespace 公寓管理系统
{
    public partial class 数据库恢复 : Form
    {
        string con = null;
        string selectPath = null;
        public 数据库恢复(string con)
        {
            InitializeComponent();
            this.con = con;
        }


      /*  public void recover1(string path)
        {
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            StreamReader sr = new StreamReader(path+"\\"+"PMS.txt");
            string s = null;
            int i = 0;
            string[] m = new string[100];
            while ((s = sr.ReadLine()) != "")
            {
                m = s.Split(',');
                for (i = 0; i < m.Length; i++) { }
                if (i > 1)
                {
                    string sql = String.Format("insert into PMS values('{0}','{1}','{2}','{3}','{4}')", m[0], m[1], m[2], m[3], m[4]);
                    SqlCommand command = new SqlCommand(sql, connec);
                    int p = command.ExecuteNonQuery();
                }
            }
        }*/

        public void recover1(string path)
        {
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            StreamReader sr = new StreamReader(path + "\\" + "PMS.txt");
            string s = null;
            int i = 0;
            string[] m = new string[100];
            while ((s = sr.ReadLine()) != "")
            {
                m = s.Split(',');
                for (i = 0; i < m.Length; i++) { }
                if (i > 1)
                {
                    string sql = String.Format("insert into PMS values('{0}','{1}','{2}','{3}','{4}')", m[0], m[1], m[2], m[3], m[4]);
                    SqlCommand command = new SqlCommand(sql, connec);
                    int p = command.ExecuteNonQuery();
                }
            }
        }

        public void recover2(string path)
        {
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            StreamReader sr = new StreamReader(path + "\\" + "EmployeeInfo.txt");
            string s = null;
            int i = 0;
            string[] m = new string[100];
            while ((s = sr.ReadLine()) != "")
            {
                m = s.Split(',');
                for (i = 0; i < m.Length; i++) { }
                if (i > 1)
                {
                    string sql = String.Format("insert into EmployeeInfo values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", m[0], m[1], m[2], m[3], m[4],m[5],m[6],m[7],m[8]);
                    SqlCommand command = new SqlCommand(sql, connec);
                    int p = command.ExecuteNonQuery();
                }
            }
        }

        public void recover3(string path)
        {
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            StreamReader sr = new StreamReader(path + "\\" + "EmployeeScore.txt");
            string s = null;
            int i = 0;
            string[] m = new string[100];
            while ((s = sr.ReadLine()) != "")
            {
                m = s.Split(',');
                for (i = 0; i < m.Length; i++) { }
                if (i > 1)
                {
                    string sql = String.Format("insert into EmployeeScore values('{0}','{1}','{2}','{3}','{4}','{5}')", m[0], m[1], m[2], m[3], m[4],m[5]);
                    SqlCommand command = new SqlCommand(sql, connec);
                    int p = command.ExecuteNonQuery();
                }
            }
        }

        public void recover4(string path)
        {
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            StreamReader sr = new StreamReader(path + "\\" + "ScoreRule.txt");
            string s = null;
            int i = 0;
            string[] m = new string[100];
            while ((s = sr.ReadLine()) != "")
            {
                m = s.Split(',');
                for (i = 0; i < m.Length; i++) { }
                if (i > 1)
                {
                    string sql = String.Format("insert into ScoreRule values('{0}','{1}')", m[0], m[1]);
                    SqlCommand command = new SqlCommand(sql, connec);
                    int p = command.ExecuteNonQuery();
                }
            }
        }

        public void recover5(string path)
        {
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            StreamReader sr = new StreamReader(path + "\\" + "Academy.txt");
            string s = null;
            int i = 0;
            string[] m = new string[100];
            while ((s = sr.ReadLine()) != "")
            {
                m = s.Split(',');
                for (i = 0; i < m.Length; i++) { }
                if (i > 1)
                {
                    string sql = String.Format("insert into Academy values('{0}','{1}','{2}')", m[0], m[1], m[2]);
                    SqlCommand command = new SqlCommand(sql, connec);
                    int p = command.ExecuteNonQuery();
                }
            }
        }

        public void recover6(string path)
        {
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            StreamReader sr = new StreamReader(path + "\\" + "StudentMessage.txt");
            string s = null;
            int i = 0;
            string[] m = new string[100];
            while ((s = sr.ReadLine()) != "")
            {
                m = s.Split(',');
                for (i = 0; i < m.Length; i++) { }
                if (i > 1)
                {
                    string sql = String.Format("insert into StudentMessage values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", m[0], m[1], m[2], m[3], m[4],m[5],m[6],m[7],m[8],m[9],m[10]);
                    SqlCommand command = new SqlCommand(sql, connec);
                    int p = command.ExecuteNonQuery();
                }
            }
        }

        public void recover7(string path)
        {
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            StreamReader sr = new StreamReader(path + "\\" + "DormitoryService.txt");
            string s = null;
            int i = 0;
            string[] m = new string[100];
            while ((s = sr.ReadLine()) != "")
            {
                m = s.Split(',');
                for (i = 0; i < m.Length; i++) { }
                if (i > 1)
                {
                    string sql = String.Format("insert into DormitoryService values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", m[0], m[1], m[2], m[3], m[4],m[5],m[6],m[7]);
                    SqlCommand command = new SqlCommand(sql, connec);
                    int p = command.ExecuteNonQuery();
                }
            }
        }

        public void recover8(string path)
        {
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            StreamReader sr = new StreamReader(path + "\\" + "DormitoryGoods.txt");
            string s = null;
            int i = 0;
            string[] m = new string[100];
            while ((s = sr.ReadLine()) != "")
            {
                m = s.Split(',');
                for (i = 0; i < m.Length; i++) { }
                if (i > 1)
                {
                    string sql = String.Format("insert into DormitoryGoods values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", m[0], m[1], m[2], m[3], m[4],m[5],m[6]);
                    SqlCommand command = new SqlCommand(sql, connec);
                    int p = command.ExecuteNonQuery();
                }
            }
        }

        public void recover9(string path)
        {
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            StreamReader sr = new StreamReader(path + "\\" + "FlatGoodsIn.txt");
            string s = null;
            int i = 0;
            string[] m = new string[100];
            while ((s = sr.ReadLine()) != "")
            {
                m = s.Split(',');
                for (i = 0; i < m.Length; i++) { }
                if (i > 1)
                {
                    string sql = String.Format("insert into FlatGoodsIn values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", m[0], m[1], m[2], m[3], m[4],m[5],m[6],m[7]);
                    SqlCommand command = new SqlCommand(sql, connec);
                    int p = command.ExecuteNonQuery();
                }
            }
        }

        public void recover10(string path)
        {
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            StreamReader sr = new StreamReader(path + "\\" + "FlatGoodsOut.txt");
            string s = null;
            int i = 0;
            string[] m = new string[100];
            while ((s = sr.ReadLine()) != "")
            {
                m = s.Split(',');
                for (i = 0; i < m.Length; i++) { }
                if (i > 1)
                {
                    string sql = String.Format("insert into FlatGoodsOut values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", m[0], m[1], m[2], m[3], m[4],m[5],m[6],m[7]);
                    SqlCommand command = new SqlCommand(sql, connec);
                    int p = command.ExecuteNonQuery();
                }
            }
        }


        public void recover11(string path)
        {
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            StreamReader sr = new StreamReader(path + "\\" + "DormitoryMaintain.txt");
            string s = null;
            int i = 0;
            string[] m = new string[100];
            while ((s = sr.ReadLine()) != "")
            {
                m = s.Split(',');
                for (i = 0; i < m.Length; i++) { }
                if (i > 1)
                {
                    string sql = String.Format("insert into DormitoryMaintain values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", m[0], m[1], m[2], m[3], m[4],m[5],m[6],m[7]);
                    SqlCommand command = new SqlCommand(sql, connec);
                    int p = command.ExecuteNonQuery();
                }
            }
        }

        public void recover12(string path)
        {
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            StreamReader sr = new StreamReader(path + "\\" + "ExternalPeople.txt");
            string s = null;
            int i = 0;
            string[] m = new string[100];
            while ((s = sr.ReadLine()) != "")
            {
                m = s.Split(',');
                for (i = 0; i < m.Length; i++) { }
                if (i > 1)
                {
                    string sql = String.Format("insert into ExternalPeople values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", m[0], m[1], m[2], m[3], m[4],m[5],m[6],m[7],m[8]);
                    SqlCommand command = new SqlCommand(sql, connec);
                    int p = command.ExecuteNonQuery();
                }
            }
        }

        public void recover13(string path)
        {
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            StreamReader sr = new StreamReader(path + "\\" + "LateStudent.txt");
            string s = null;
            int i = 0;
            string[] m = new string[100];
            while ((s = sr.ReadLine()) != "")
            {
                m = s.Split(',');
                for (i = 0; i < m.Length; i++) { }
                if (i > 1)
                {
                    string sql = String.Format("insert into LateStudent values('{0}','{1}','{2}','{3}','{4}','{5}')", m[0], m[1], m[2], m[3], m[4],m[5]);
                    SqlCommand command = new SqlCommand(sql, connec);
                    int p = command.ExecuteNonQuery();
                }
            }
        }


        public void recover14(string path)
        {
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            StreamReader sr = new StreamReader(path + "\\" + "TeacherVisit.txt");
            string s = null;
            int i = 0;
            string[] m = new string[100];
            while ((s = sr.ReadLine()) != "")
            {
                m = s.Split(',');
                for (i = 0; i < m.Length; i++) { }
                if (i > 1)
                {
                    string sql = String.Format("insert into TeacherVisit values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", m[0], m[1], m[2], m[3], m[4],m[5],m[6],m[7],m[8]);
                    SqlCommand command = new SqlCommand(sql, connec);
                    int p = command.ExecuteNonQuery();
                }
            }
        }


        public void recover15(string path)
        {
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            StreamReader sr = new StreamReader(path + "\\" + "Flat.txt");
            string s = null;
            int i = 0;
            string[] m = new string[100];
            while ((s = sr.ReadLine()) != "")
            {
                m = s.Split(',');
                for (i = 0; i < m.Length; i++) { }
                if (i > 1)
                {
                    string sql = String.Format("insert into Flat values('{0}','{1}','{2}','{3}','{4}')", m[0], m[1], m[2], m[3], m[4]);
                    SqlCommand command = new SqlCommand(sql, connec);
                    int p = command.ExecuteNonQuery();
                }
            }
        }


        public void recover16(string path)
        {
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            StreamReader sr = new StreamReader(path + "\\" + "FlatMessage.txt");
            string s = null;
            int i = 0;
            string[] m = new string[100];
            while ((s = sr.ReadLine()) != "")
            {
                m = s.Split(',');
                for (i = 0; i < m.Length; i++) { }
                if (i > 1)
                {
                    string sql = String.Format("insert into FlatMessage values('{0}','{1}','{2}','{3}','{4}','{5}')", m[0], m[1], m[2], m[3], m[4],m[5]);
                    SqlCommand command = new SqlCommand(sql, connec);
                    int p = command.ExecuteNonQuery();
                }
            }
        }


        public void recover17(string path)
        {
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            StreamReader sr = new StreamReader(path + "\\" + "Goods.txt");
            string s = null;
            int i = 0;
            string[] m = new string[100];
            while ((s = sr.ReadLine()) != "")
            {
                m = s.Split(',');
                for (i = 0; i < m.Length; i++) { }
                if (i > 1)
                {
                    string sql = String.Format("insert into Goods values('{0}','{1}','{2}','{3}','{4}')", m[0], m[1], m[2], m[3], m[4]);
                    SqlCommand command = new SqlCommand(sql, connec);
                    int p = command.ExecuteNonQuery();
                }
            }
        }

        public void recover18(string path)
        {
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            StreamReader sr = new StreamReader(path + "\\" + "UserMessage.txt");
            string s = null;
            int i = 0;
            string[] m = new string[100];
            while ((s = sr.ReadLine()) != "")
            {
                m = s.Split(',');
                for (i = 0; i < m.Length; i++) { }
                if (i > 1)
                {
                    string sql = String.Format("insert into UserMessage values('{0}','{1}','{2}','{3}')", m[0], m[1], m[2], m[3]);
                    SqlCommand command = new SqlCommand(sql, connec);
                    int p = command.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string m = null;
                StreamReader sr = new StreamReader(selectPath + "\\" + "数据库备份.txt");
                m = Convert.ToString(sr.ReadLine());
                sr.Close();
                if (m.Equals("abcd"))
                {
                    if (checkBox1.Checked) { recover1(selectPath); }
                    if (checkBox2.Checked) { recover2(selectPath); }
                    if (checkBox3.Checked) { recover3(selectPath); }
                    if (checkBox4.Checked) { recover4(selectPath); }
                    if (checkBox5.Checked) { recover5(selectPath); }
                    if (checkBox6.Checked) { recover6(selectPath); }
                    if (checkBox7.Checked) { recover7(selectPath); }
                    if (checkBox8.Checked) { recover8(selectPath); }
                    if (checkBox9.Checked) { recover9(selectPath); }
                    if (checkBox10.Checked) { recover10(selectPath); }
                    if (checkBox11.Checked) { recover11(selectPath); }
                    if (checkBox12.Checked) { recover12(selectPath); }
                    if (checkBox13.Checked) { recover13(selectPath); }
                    if (checkBox14.Checked) { recover14(selectPath); }
                    if (checkBox15.Checked) { recover15(selectPath); }
                    if (checkBox16.Checked) { recover16(selectPath); }
                    if (checkBox17.Checked) { recover17(selectPath); }
                    if (checkBox18.Checked) { recover18(selectPath); }
                    //delete();
                    File.Delete(selectPath + "\\" + "数据库备份.txt");
                    MessageBox.Show("恢复成功！");

                }
               else { MessageBox.Show("请核对备份文件！"); }
            }
            catch (Exception ssss) { MessageBox.Show("数据库中没有表！"); }
                //delete();
           // System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(selectPath);
           // if (di.GetFiles().Length + di.GetDirectories().Length != 0) { MessageBox.Show("恢复成功！或者指定文件夹为空！"); }
               // Directory.Delete(selectPath, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           System.Threading.Thread s = new System.Threading.Thread(new System.Threading.ThreadStart(test));
            s.ApartmentState = System.Threading.ApartmentState.STA;
            s.Start();
        }
        public void test()
        {           
            FolderBrowserDialog browseDialog = new FolderBrowserDialog();
            browseDialog.ShowDialog();
            selectPath = browseDialog.SelectedPath;
            textBox1.Text = selectPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void delete() 
        {
            /*
            File.Delete(selectPath + "\\" + "PMS.txt");
            File.Delete(selectPath + "\\" + "EmployeeInfo.txt");
            File.Delete(selectPath + "\\" + "EmployeeScore.txt");
            File.Delete(selectPath + "\\" + "ScoreRule.txt");
            File.Delete(selectPath + "\\" + "Academy.txt");
            File.Delete(selectPath + "\\" + "StudentMessage.txt");
            File.Delete(selectPath + "\\" + "DormitoryService.txt");
            File.Delete(selectPath + "\\" + "DormitoryGoods.txt");
            File.Delete(selectPath + "\\" + "FlatGoodsIn.txt");
            File.Delete(selectPath + "\\" + "FlatGoodsOut.txt");
            File.Delete(selectPath + "\\" + "DormitoryMaintain.txt");
            File.Delete(selectPath + "\\" + "ExternalPeople.txt");
            File.Delete(selectPath + "\\" + "LateStudent.txt");
            File.Delete(selectPath + "\\" + "TeacherVisit.txt.txt");
            File.Delete(selectPath + "\\" + "Flat.txt");
            File.Delete(selectPath + "\\" + "FlatMessage.txt");
            File.Delete(selectPath + "\\" + "Goods.txt"); 
        */
            File.Delete(selectPath + "\\" + "数据库备份.txt");
        }

        private void 数据库恢复_Load(object sender, EventArgs e)
        {
            CenterToParent();
            this.ControlBox = false;
        }
        }
    }

