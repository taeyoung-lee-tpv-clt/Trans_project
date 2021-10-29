using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace project
{
    public partial class Form1 : Form
    {
        
        
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
        private void Timer1_Tick(object sender,EventArgs e)
        {
            panel5.Width += 3;
            if(panel5.Width >= 300)
            {
                Timer1.Stop();
                this.Size = new Size(300, 450);
                panel4.Visible = false;
                panel5.Visible = false;
            }
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
            try
            {
                button1.Visible = true;
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "tyland.database.windows.net";
                builder.UserID = "tylee";
                builder.Password = "dkansk1@A";
                builder.InitialCatalog = "tyland";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    String sql = "insert into dbo.name VALUES(@textBox1,@textBox2);";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        if (connection.State == ConnectionState.Open)
                            {
                                MessageBox.Show("데이터 넣자");
                            }
                            else
                            {
                                MessageBox.Show("실패");
                            }
                        
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*conn.Open();
            
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
