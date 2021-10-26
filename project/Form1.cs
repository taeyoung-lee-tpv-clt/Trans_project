using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        
        /*SqlDataReader dr;

        FileStream fs;
        StreamWriter sw;

        Thread mythread;
        bool mythread_run;

        string listBoxStr;
        bool runFirst;*/
        public Form1()
        {
            InitializeComponent();

            
        }
        private void Connection_Load(object sender,EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        { 
            
        }

        private void Time_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Base_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            
                
                /*conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("연결");
                }
                else
                {
                    MessageBox.Show("실패");
                }

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                //db 정보 입력
                cmd.CommandText = "INSERT INTO app.logINFO(userID,userPW) VALUES(@userID,@userPW)";
                cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.VarChar, 100));
                cmd.Parameters.Add(new SqlParameter("@userPW", SqlDbType.VarChar, 100));

                cmd.Parameters["userID"].Value = textBox1.Text;
               *//* cmd.Parameters["userPW"].Value = textBox2.Text;*//*

                cmd.ExecuteNonQuery();
                conn.Close();
                textBox1.Text = textBox2.Text = "";
                MessageBox.Show("데이터 추가가 완료 되었습니다");*/
                /* fs = new FileStream("C:\Users\tylee\Documents\test",);
                sw = new StreamWriter(fs);*/

               /* mythread = new Thread(thread_Work);
                mythread.Start();*/
           
        }
        private void thread_Work()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*conn = new SqlConnection("server=211.248.188.9:3306;database=app;uid=root;pwd=test123");
            conn.Open();*/
            MessageBox.Show("멍멍아빠");
            /*conn.Close();*/
            this.Hide();
            Form2 frm = new Form2();
            frm.Owner = this;
            frm.Show();
        }
    }
}
