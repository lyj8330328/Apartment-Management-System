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
namespace 公寓管理系统
{
    public partial class 建立数据库表 : Form
    {
        public string con = null;
        public 建立数据库表(string con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] sql = new string[20];   //创建sql字符串数组
                string connn = con;    //得到数据库连接字符串，在主窗体得到，然后传递给子窗体
                SqlConnection connec = new SqlConnection(connn);  //创建connection对象
                connec.Open();                              //打开连接
                //编写创建各个表的sql语句
                sql[0] = String.Format("CREATE TABLE Academy (学院 varchar(50),系 varchar(50),专业 varchar(50))");
                sql[1] = String.Format("CREATE TABLE DormitoryGoods (更换单号 varchar(50),楼号 varchar(50),寝室号 "
                    +"varchar(50),更换日期 varchar(50),更换人员 varchar(50),更换原因 varchar(50),备注 varchar(50))");
                sql[2] = String.Format("CREATE TABLE DormitoryMaintain (维修单号 varchar(50),报修单号 varchar(50),"
                    +"楼号 varchar(50),寝室号 varchar(50),维修日期 varchar(50),维修人员 varchar(50),报修原因 varchar(50),备注 varchar(50))");
                sql[3] = String.Format("CREATE TABLE DormitoryService (报修单号 varchar(50),学号 varchar(50),"
                    +"姓名 varchar(50),楼号 varchar(50),寝室号 varchar(50),报修日期 varchar(50),报修原因 varchar(50),备注 varchar(50))");
                sql[4] = String.Format("CREATE TABLE EmployeeInfo (员工编号 varchar(50),员工姓名 varchar(50),性别 varchar(50),"
                    +"文化程度 varchar(50),职称 varchar(50),邮政编码 varchar(50),籍贯 varchar(50),身份证号 varchar(50),备注 varchar(50))");
                sql[5] = String.Format("CREATE TABLE EmployeeScore (员工编号 varchar(50),员工姓名 varchar(50),日期 varchar(50),原因 varchar(50),"
                    +"分数 varchar(50),楼号 varchar(50))");
                sql[6] = String.Format("CREATE TABLE ExternalPeople (姓名 varchar(50),性别 varchar(50),证件类型 varchar(50),证件号码 varchar(50),"
                    +"楼号 varchar(50),寝室号 varchar(50),进入时间 varchar(50),离开时间 varchar(50),备注 varchar(50))");
                sql[7] = String.Format("CREATE TABLE Flat (楼号 varchar(50),层数 varchar(50),寝室号 varchar(50),床号 varchar(50),"
                    +"是否入住 varchar(50))");
                sql[8] = String.Format("CREATE TABLE FlatGoodsIn (入库单号 varchar(50),物品编号 varchar(50),物品名称 varchar(50),"
                    +"单价 varchar(50),数量 varchar(50),金额 varchar(50),入库时间 varchar(50),备注 varchar(50))");
                sql[9] = String.Format("CREATE TABLE FlatGoodsOut (出库单号 varchar(50),物品编号 varchar(50),物品名称 varchar(50),"
                    +"单价 varchar(50),数量 varchar(50),金额 varchar(50),出库时间 varchar(50),备注 varchar(50))");
                sql[10] = String.Format("CREATE TABLE FlatMessage (楼号 varchar(50),层数 varchar(50),房间数 varchar(50),床位数 varchar(50),"
                    +"收费标准 varchar(50),居住性别 varchar(50))");
                sql[11] = String.Format("CREATE TABLE Goods (物品编号 varchar(50),物品名称 varchar(50),单价 varchar(50),原始数量 varchar(50),"
                    +"现有数量 varchar(50))");
                sql[12] = String.Format("CREATE TABLE LateStudent (学号 varchar(50),姓名 varchar(50),楼号 varchar(50),寝室号 varchar(50),"
                    +"进入时间 varchar(50),原因 varchar(50))");
                sql[13] = String.Format("CREATE TABLE PMS (工作证号 varchar(50),姓名 varchar(50),性别 varchar(50),公寓号 varchar(50),"
                    +"物业公司 varchar(50))");
                sql[14] = String.Format("CREATE TABLE ScoreRule (评分规则 varchar(50),分数 varchar(50))");
                sql[15] = String.Format("CREATE TABLE StudentMessage (学号 varchar(50),姓名 varchar(50),性别 varchar(50),年级 varchar(50),"
                    +"班级 varchar(50),学院 varchar(50),系 varchar(50),专业 varchar(50),楼号 varchar(50),寝室号 varchar(50),床号 varchar(50))");
                sql[16] = String.Format("CREATE TABLE TeacherVisit (教师姓名 varchar(50),证件类型 varchar(50),证件号码 varchar(50),"
                    +"楼号 varchar(50),学院 varchar(50),专业 varchar(50),进入时间 varchar(50),离开时间 varchar(50),备注 varchar(50))");
                sql[17] = String.Format("CREATE TABLE UserMessage (用户名 varchar(50),登录密码 varchar(50),联系电话 varchar(50),"
                    +"真实姓名 varchar(50),身份证号 varchar(50))");

                for (int i = 0; i < sql.Length; i++)
                {
                    SqlCommand command = new SqlCommand(sql[i], connec);
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception s)
            {
                MessageBox.Show("建表成功！");

                FileStream fs = new FileStream("建立数据库表.txt", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes("建立成功");
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

        }

        private void 建立数据库表_Load(object sender, EventArgs e)
        {
            CenterToParent();
            this.ControlBox = false;

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            checkBox7.Enabled = false;
            checkBox8.Enabled = false;
            checkBox9.Enabled = false;
            checkBox10.Enabled = false;
            checkBox11.Enabled = false;
            checkBox12.Enabled = false;
            checkBox13.Enabled = false;
            checkBox14.Enabled = false;
            checkBox15.Enabled = false;
            checkBox16.Enabled = false;
            checkBox17.Enabled = false;
            checkBox18.Enabled = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
