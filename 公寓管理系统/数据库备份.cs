using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
namespace 公寓管理系统
{
    public partial class 数据库备份 : Form
    {
        public string con = null;
        string selectPath = null;
        public 数据库备份(string con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void 数据库备份_Load(object sender, EventArgs e)
        {
            CenterToParent();
            this.ControlBox = false;
        }

        public void copy1(string path) 
        {
            int i = 0;
            string[] s1 = new string[1000];
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            string sql2 = String.Format("select * from PMS order by 工作证号");
            SqlCommand command2 = new SqlCommand(sql2, connec);
            SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                s1[i] = String.Format("{0}", reader[0]) + "," + String.Format("{0}", reader[1]) + "," + String.Format("{0}", reader[2]) + "," + String.Format("{0}", reader[3]) + "," + String.Format("{0}", reader[4]);
                i++;

            }
            reader.Close();
            StreamWriter sw = new StreamWriter(path+"\\"+"PMS.txt");
            sw.WriteLine("工作证号-------姓名-------------性别-----------公寓号---------物业公司");
            for (int s = 0; s < s1.Length; s++)
            {
                sw.WriteLine(s1[s]);
            }
            sw.Close();        
        }

        public void copy2(string path)
        {
            int i = 0;
            string[] s1 = new string[1000];
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            string sql2 = String.Format("select * from EmployeeInfo order by 员工编号");
            SqlCommand command2 = new SqlCommand(sql2, connec);
            SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                s1[i] = String.Format("{0}", reader[0]) + "," + String.Format("{0}", reader[1]) + "," + String.Format("{0}", reader[2]) + "," + String.Format("{0}", reader[3]) + "," + String.Format("{0}", reader[4]) + "," + String.Format("{0}", reader[5]) + "," + String.Format("{0}", reader[6]) + "," + String.Format("{0}", reader[7]) + "," + String.Format("{0}", reader[8]);
                i++;

            }
            reader.Close();
            StreamWriter sw = new StreamWriter(path+"\\"+"EmployeeInfo.txt");
            sw.WriteLine("员工编号-------员工姓名-------------性别-----------文化程度---------职称-------邮政编码--------籍贯--------身份证号--------备注");
            for (int s = 0; s < s1.Length; s++)
            {
                sw.WriteLine(s1[s]);
            }
            sw.Close();
        }

        public void copy3(string path)
        {
            int i = 0;
            string[] s1 = new string[1000];
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            string sql2 = String.Format("select * from EmployeeScore order by 员工编号");
            SqlCommand command2 = new SqlCommand(sql2, connec);
            SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                s1[i] = String.Format("{0}", reader[0]) + "," + String.Format("{0}", reader[1]) + "," + String.Format("{0}", reader[2]) + "," + String.Format("{0}", reader[3]) + "," + String.Format("{0}", reader[4]) + "," + String.Format("{0}", reader[5]);
                i++;

            }
            reader.Close();
            StreamWriter sw = new StreamWriter(path+"\\"+"EmployeeScore.txt");
            sw.WriteLine("员工编号-------员工姓名-------------日期-----------原因---------分数-------楼号");
            for (int s = 0; s < s1.Length; s++)
            {
                sw.WriteLine(s1[s]);
            }
            sw.Close();
        }

        public void copy4(string path)
        {
            int i = 0;
            string[] s1 = new string[1000];
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            string sql2 = String.Format("select * from ScoreRule");
            SqlCommand command2 = new SqlCommand(sql2, connec);
            SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                s1[i] = String.Format("{0}", reader[0]) + "," + String.Format("{0}", reader[1]);
                i++;

            }
            reader.Close();
            StreamWriter sw = new StreamWriter(path+"\\"+"ScoreRule.txt");
            sw.WriteLine("评分规则-------------------------------分数");
            for (int s = 0; s < s1.Length; s++)
            {
                sw.WriteLine(s1[s]);
            }
            sw.Close();
        }

        public void copy5(string path)
        {
            int i = 0;
            string[] s1 = new string[1000];
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            string sql2 = String.Format("select * from Academy ");
            SqlCommand command2 = new SqlCommand(sql2, connec);
            SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                s1[i] = String.Format("{0}", reader[0]) + "," + String.Format("{0}", reader[1]) + "," + String.Format("{0}", reader[2]);
                i++;

            }
            reader.Close();
            StreamWriter sw = new StreamWriter(path+"\\"+"Academy.txt");
            sw.WriteLine("学院--------------系---------------专业");
            for (int s = 0; s < s1.Length; s++)
            {
                sw.WriteLine(s1[s]);
            }
            sw.Close();
        }

        public void copy6(string path)
        {
            int i = 0;
            string[] s1 = new string[1000];
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            string sql2 = String.Format("select * from StudentMessage order by 学号");
            SqlCommand command2 = new SqlCommand(sql2, connec);
            SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                s1[i] = String.Format("{0}", reader[0]) + "," + String.Format("{0}", reader[1]) + "," + String.Format("{0}", reader[2]) + "," + String.Format("{0}", reader[3]) + "," + String.Format("{0}", reader[4]) + "," + String.Format("{0}", reader[5]) + "," + String.Format("{0}", reader[6]) + "," + String.Format("{0}", reader[7]) + "," + String.Format("{0}", reader[8]) + "," + String.Format("{0}", reader[9]) + "," + String.Format("{0}", reader[10]);
                i++;

            }
            reader.Close();
            StreamWriter sw = new StreamWriter(path+"\\"+"StudentMessage.txt");
            sw.WriteLine("学号-------姓名-------------性别-----------年级---------班级-------学院--------系--------专业--------楼号---------寝室号---------床号");
            for (int s = 0; s < s1.Length; s++)
            {
                sw.WriteLine(s1[s]);
            }
            sw.Close();
        }

        public void copy7(string path)
        {
            int i = 0;
            string[] s1 = new string[1000];
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            string sql2 = String.Format("select * from DormitoryService order by 报修单号");
            SqlCommand command2 = new SqlCommand(sql2, connec);
            SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                s1[i] = String.Format("{0}", reader[0]) + "," + String.Format("{0}", reader[1]) + "," + String.Format("{0}", reader[2]) + "," + String.Format("{0}", reader[3]) + "," + String.Format("{0}", reader[4]) + "," + String.Format("{0}", reader[5]) + "," + String.Format("{0}", reader[6]) + "," + String.Format("{0}", reader[7]);
                i++;

            }
            reader.Close();
            StreamWriter sw = new StreamWriter(path+"\\"+"DormitoryService.txt");
            sw.WriteLine("报修单号-------学号-------------姓名-----------楼号---------寝室号-------报修日期--------报修原因--------备注");
            for (int s = 0; s < s1.Length; s++)
            {
                sw.WriteLine(s1[s]);
            }
            sw.Close();
        }

        public void copy8(string path)
        {
            int i = 0;
            string[] s1 = new string[1000];
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            string sql2 = String.Format("select * from DormitoryGoods order by 更换单号");
            SqlCommand command2 = new SqlCommand(sql2, connec);
            SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                s1[i] = String.Format("{0}", reader[0]) + "," + String.Format("{0}", reader[1]) + "," + String.Format("{0}", reader[2]) + "," + String.Format("{0}", reader[3]) + "," + String.Format("{0}", reader[4]) + "," + String.Format("{0}", reader[5]) + "," + String.Format("{0}", reader[6]);
                i++;

            }
            reader.Close();
            StreamWriter sw = new StreamWriter(path+"\\"+"DormitoryGoods.txt");
            sw.WriteLine("更换单号-------楼号-------------寝室号-----------更换日期---------更换人员-------更换原因--------备注");
            for (int s = 0; s < s1.Length; s++)
            {
                sw.WriteLine(s1[s]);
            }
            sw.Close();
        }

        public void copy9(string path)
        {
            int i = 0;
            string[] s1 = new string[1000];
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            string sql2 = String.Format("select * from FlatGoodsIn order by 入库单号");
            SqlCommand command2 = new SqlCommand(sql2, connec);
            SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                s1[i] = String.Format("{0}", reader[0]) + "," + String.Format("{0}", reader[1]) + "," + String.Format("{0}", reader[2]) + "," + String.Format("{0}", reader[3]) + "," + String.Format("{0}", reader[4]) + "," + String.Format("{0}", reader[5]) + "," + String.Format("{0}", reader[6]) + "," + String.Format("{0}", reader[7]);
                i++;

            }
            reader.Close();
            StreamWriter sw = new StreamWriter(path+"\\"+"FlatGoodsIn.txt");
            sw.WriteLine("入库单号-------物品编号-------------物品名称-----------单价---------数量-------金额--------入库时间--------备注");
            for (int s = 0; s < s1.Length; s++)
            {
                sw.WriteLine(s1[s]);
            }
            sw.Close();
        }

        public void copy10(string path)
        {
            int i = 0;
            string[] s1 = new string[1000];
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            string sql2 = String.Format("select * from FlatGoodsOut order by 出库单号");
            SqlCommand command2 = new SqlCommand(sql2, connec);
            SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                s1[i] = String.Format("{0}", reader[0]) + "," + String.Format("{0}", reader[1]) + "," + String.Format("{0}", reader[2]) + "," + String.Format("{0}", reader[3]) + "," + String.Format("{0}", reader[4]) + "," + String.Format("{0}", reader[5]) + "," + String.Format("{0}", reader[6]) + "," + String.Format("{0}", reader[7]);
                i++;

            }
            reader.Close();
            StreamWriter sw = new StreamWriter(path+"\\"+"FlatGoodsOut.txt");
            sw.WriteLine("出库单号-------物品编号-------------物品名称-----------单价---------数量-------金额--------出库时间--------备注");
            for (int s = 0; s < s1.Length; s++)
            {
                sw.WriteLine(s1[s]);
            }
            sw.Close();
        }

        public void copy11(string path)
        {
            int i = 0;
            string[] s1 = new string[1000];
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            string sql2 = String.Format("select * from DormitoryMaintain order by 维修单号 ");
            SqlCommand command2 = new SqlCommand(sql2, connec);
            SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                s1[i] = String.Format("{0}", reader[0]) + "," + String.Format("{0}", reader[1]) + "," + String.Format("{0}", reader[2]) + "," + String.Format("{0}", reader[3]) + "," + String.Format("{0}", reader[4]) + "," + String.Format("{0}", reader[5]) + "," + String.Format("{0}", reader[6]) + "," + String.Format("{0}", reader[7]);
                i++;

            }
            reader.Close();
            StreamWriter sw = new StreamWriter(path+"\\"+"DormitoryMaintain.txt");
            sw.WriteLine("维修单号-------报修单号-------------楼号-----------寝室号---------维修日期-------维修人员--------报修原因--------备注");
            for (int s = 0; s < s1.Length; s++)
            {
                sw.WriteLine(s1[s]);
            }
            sw.Close();
        }

        public void copy12(string path)
        {
            int i = 0;
            string[] s1 = new string[1000];
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            string sql2 = String.Format("select * from ExternalPeople");
            SqlCommand command2 = new SqlCommand(sql2, connec);
            SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                s1[i] = String.Format("{0}", reader[0]) + "," + String.Format("{0}", reader[1]) + "," + String.Format("{0}", reader[2]) + "," + String.Format("{0}", reader[3]) + "," + String.Format("{0}", reader[4]) + "," + String.Format("{0}", reader[5]) + "," + String.Format("{0}", reader[6]) + "," + String.Format("{0}", reader[7]) + "," + String.Format("{0}", reader[8]);
                i++;

            }
            reader.Close();
            StreamWriter sw = new StreamWriter(path+"\\"+"ExternalPeople.txt");
            sw.WriteLine("姓名-------性别-------------证件类型-----------证件号码---------楼号-------寝室号--------进入时间--------离开时间--------备注");
            for (int s = 0; s < s1.Length; s++)
            {
                sw.WriteLine(s1[s]);
            }
            sw.Close();
        }

        public void copy13(string path)
        {
            int i = 0;
            string[] s1 = new string[1000];
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            string sql2 = String.Format("select * from LateStudent order by 学号");
            SqlCommand command2 = new SqlCommand(sql2, connec);
            SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                s1[i] = String.Format("{0}", reader[0]) + "," + String.Format("{0}", reader[1]) + "," + String.Format("{0}", reader[2]) + "," + String.Format("{0}", reader[3]) + "," + String.Format("{0}", reader[4]) + "," + String.Format("{0}", reader[5]);
                i++;

            }
            reader.Close();
            StreamWriter sw = new StreamWriter(path+"\\"+"LateStudent.txt");
            sw.WriteLine("学号-------姓名-------------楼号-----------寝室号---------进入时间-------原因");
            for (int s = 0; s < s1.Length; s++)
            {
                sw.WriteLine(s1[s]);
            }
            sw.Close();
        }

        public void copy14(string path)
        {
            int i = 0;
            string[] s1 = new string[1000];
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            string sql2 = String.Format("select * from TeacherVisit");
            SqlCommand command2 = new SqlCommand(sql2, connec);
            SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                s1[i] = String.Format("{0}", reader[0]) + "," + String.Format("{0}", reader[1]) + "," + String.Format("{0}", reader[2]) + "," + String.Format("{0}", reader[3]) + "," + String.Format("{0}", reader[4]) + "," + String.Format("{0}", reader[5]) + "," + String.Format("{0}", reader[6]) + "," + String.Format("{0}", reader[7]) + "," + String.Format("{0}", reader[8]);
                i++;

            }
            reader.Close();
            StreamWriter sw = new StreamWriter(path+"\\"+"TeacherVisit.txt");
            sw.WriteLine("教师姓名-------证件类型-------------证件号码-----------楼号---------学院-------专业--------进入时间--------离开时间--------备注");
            for (int s = 0; s < s1.Length; s++)
            {
                sw.WriteLine(s1[s]);
            }
            sw.Close();
        }

        public void copy15(string path)
        {
            int i = 0;
            string[] s1 = new string[1000];
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            string sql2 = String.Format("select * from Flat order by 楼号");
            SqlCommand command2 = new SqlCommand(sql2, connec);
            SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                s1[i] = String.Format("{0}", reader[0]) + "," + String.Format("{0}", reader[1]) + "," + String.Format("{0}", reader[2]) + "," + String.Format("{0}", reader[3]) + "," + String.Format("{0}", reader[4]) ;
                i++;

            }
            reader.Close();
            StreamWriter sw = new StreamWriter(path+"\\"+"Flat.txt");
            sw.WriteLine("楼号-------层数-------------寝室号-----------床号---------是否入住");
            for (int s = 0; s < s1.Length; s++)
            {
                sw.WriteLine(s1[s]);
            }
            sw.Close();
        }

        public void copy16(string path)
        {
            int i = 0;
            string[] s1 = new string[1000];
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            string sql2 = String.Format("select * from FlatMessage order by 楼号");
            SqlCommand command2 = new SqlCommand(sql2, connec);
            SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                s1[i] = String.Format("{0}", reader[0]) + "," + String.Format("{0}", reader[1]) + "," + String.Format("{0}", reader[2]) + "," + String.Format("{0}", reader[3]) + "," + String.Format("{0}", reader[4]) + "," + String.Format("{0}", reader[5]) ;
                i++;

            }
            reader.Close();
            StreamWriter sw = new StreamWriter(path+"\\"+"FlatMessage.txt");
            sw.WriteLine("楼号-------层数-------------房间数-----------床位数---------收费标准-------居住性别");
            for (int s = 0; s < s1.Length; s++)
            {
                sw.WriteLine(s1[s]);
            }
            sw.Close();
        }

        public void copy17(string path)
        {
            int i = 0;
            string[] s1 = new string[1000];
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            string sql2 = String.Format("select * from Goods order by 物品编号");
            SqlCommand command2 = new SqlCommand(sql2, connec);
            SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                s1[i] = String.Format("{0}", reader[0]) + "," + String.Format("{0}", reader[1]) + "," + String.Format("{0}", reader[2]) + "," + String.Format("{0}", reader[3]) + "," + String.Format("{0}", reader[4]) ;
                i++;

            }
            reader.Close();
            StreamWriter sw = new StreamWriter(path+"\\"+"Goods.txt");
            sw.WriteLine("物品编号-------物品名称-------------单价-----------原始数量---------现有数量");
            for (int s = 0; s < s1.Length; s++)
            {
                sw.WriteLine(s1[s]);
            }
            sw.Close();
        }

        public void copy18(string path)
        {
            int i = 0;
            string[] s1 = new string[1000];
            string connn = con;
            SqlConnection connec = new SqlConnection(connn);
            connec.Open();
            string sql2 = String.Format("select * from UserMessage ");
            SqlCommand command2 = new SqlCommand(sql2, connec);
            SqlDataReader reader = command2.ExecuteReader();
            while (reader.Read())
            {
                s1[i] = String.Format("{0}", reader[0]) + "," + String.Format("{0}", reader[1]) + "," + String.Format("{0}", reader[2]) + "," + String.Format("{0}", reader[3]);
                i++;

            }
            reader.Close();
            StreamWriter sw = new StreamWriter(path + "\\" + "UserMessage.txt");
            sw.WriteLine("用户名-------登录密码-------------联系电话-----------真实姓名");
            for (int s = 0; s < s1.Length; s++)
            {
                sw.WriteLine(s1[s]);
            }
            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {



                if (checkBox1.Checked) { copy1(selectPath); }
                if (checkBox2.Checked) { copy2(selectPath); }
                if (checkBox3.Checked) { copy3(selectPath); }
                if (checkBox4.Checked) { copy4(selectPath); }
                if (checkBox5.Checked) { copy5(selectPath); }
                if (checkBox6.Checked) { copy6(selectPath); }
                if (checkBox7.Checked) { copy7(selectPath); }
                if (checkBox8.Checked) { copy8(selectPath); }
                if (checkBox9.Checked) { copy9(selectPath); }
                if (checkBox10.Checked) { copy10(selectPath); }
                if (checkBox11.Checked) { copy11(selectPath); }
                if (checkBox12.Checked) { copy12(selectPath); }
                if (checkBox13.Checked) { copy13(selectPath); }
                if (checkBox14.Checked) { copy14(selectPath); }
                if (checkBox15.Checked) { copy15(selectPath); }
                if (checkBox16.Checked) { copy16(selectPath); }
                if (checkBox17.Checked) { copy17(selectPath); }
                if (checkBox18.Checked) { copy18(selectPath); }

                StreamWriter sw = new StreamWriter(selectPath + "\\" + "数据库备份.txt");
                sw.WriteLine("abcd");
                sw.Close();
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(selectPath);
                if (di.GetFiles().Length + di.GetDirectories().Length != 0) { MessageBox.Show("备份成功！"); }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
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


        }
    }

