using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Threading;
using System.Net.Sockets;
using System.Net;
namespace project
{
    public partial class Form2 : Form
    {
        const int MAX_SLIDING_WIDTH = 137;
        const int MIN_SLIDING_WIDTH = 50;

        const int step = 10;

        int _posSliding = 137;
        //카메라
        VideoCapture capture;
        Mat frame;
        Bitmap image;
        private Thread camera;
        int isCameraRun = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cameraBtn.Text.Equals("camera"))
            {
                CaptureCamera();
                cameraBtn.Text = "Stop";
                isCameraRun = 1;
            }
            else
            {
                if (capture.IsOpened())
                {
                    capture.Release();
                }
                cameraBtn.Text = "camera";
                isCameraRun = 0;
            }
            
        }
        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }
        private void CaptureCameraCallback()
        {
            frame = new Mat();
            capture = new VideoCapture();
            capture.Open(1);

            while(isCameraRun == 1)
            {
                capture.Read(frame);
                if (!frame.Empty())
                {
                    image = BitmapConverter.ToBitmap(frame);
                    pictureBox1.Image = image;
                }
                image = null; 
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                cameraBtn.Text = "1";
                button2.Text = "2";
                checkBox1.Text = ">";
            }
            else
            {
                cameraBtn.Text = "button1";
                button2.Text = "button2";
                checkBox1.Text = "<";
            }
            timer1.Start();
        }
        private void timer1_Tick(object sender,EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                _posSliding -= step;
                if (_posSliding >= MIN_SLIDING_WIDTH)
                    timer1.Stop();
            }
            else
            {
                _posSliding += step;
                if (_posSliding >= MAX_SLIDING_WIDTH)
                    timer1.Stop();

            }
            panel1.Width = _posSliding;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm = new Form3();
            frm.Owner = this;
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            async void connect()
            {
                
                TcpClient tcp = new TcpClient();
                await Task.Run(() =>
                {
                    try
                    {
                        tcp.Connect(IPAddress.Parse("211.248.188.9"),54527);
                      
                    }
                    catch(Exception e) 
                    {
                        MessageBox.Show(e.Message);
                    }
                    if (tcp.Connected)
                    {
                        MessageBox.Show("연결 성공");
                    }
                    else
                    {
                        MessageBox.Show("실패");
                    }
                });
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm = new Form5();
            frm.Owner = this;
            frm.Show();
        }
    }
}
