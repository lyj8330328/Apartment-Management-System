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
    public partial class 公寓管理系统_管理端_ : Form
    {
        string connnn = null;
        public string name = null;
        public 公寓管理系统_管理端_()
        {
            InitializeComponent();
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

        private void 公寓管理系统_管理端__Load(object sender, EventArgs e)
        {
            byte[] byData = new byte[100];
            char[] charData = new char[1000];

            byte[] byData2 = new byte[100];
            char[] charData2 = new char[1000];

            string s = null;

            CenterToScreen();
           
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form f1 = new 连接数据库(connnn);
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = connection();
            Form f1 = new 数据库备份(name);
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = connection();
            Form f1 = new 添加用户(name);
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = connection();
            Form f1 = new 数据库恢复(name);
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = connection();
            Form f1 = new 建立数据库表(name);
            f1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(delegate { Application.Run(new 登录窗体()); }));
            t.Start();
            this.Dispose(true);
        }

        private void 公寓管理系统_管理端__FormClosing(object sender, FormClosingEventArgs e)
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
}
