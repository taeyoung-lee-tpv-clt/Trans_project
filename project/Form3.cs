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
namespace project
{
    public partial class Form3 : Form
    {
        VideoCapture capture;
        Mat frame;
        Bitmap image;
        private Thread camera;
        int isCameraRunning = 0;

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

            while (isCameraRunning == 1)
            {
                capture.Read(frame);
                if (!frame.Empty())
                {
                    image = BitmapConverter.ToBitmap(frame);
                    pictureBox2.Image = image;
                }
                image = null;
            }

        }
        public Form3()
        {
            InitializeComponent();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            frame.Dispose();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text.Equals("Start"))
            {
                CaptureCamera();
                button1.Text = "Stop";
                isCameraRunning = 1;
            }
            else
            {
                if (capture.IsOpened())
                {
                    capture.Release();
                }
                button1.Text = "Start";
                isCameraRunning = 0;
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
