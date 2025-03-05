using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMCSHW_4
{
    public partial class Form1 : Form
    {
        private VideoCapture _capture;
        private Thread _captureThread;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _capture = new VideoCapture(0);
            _captureThread = new Thread(DisplayWebcam);
            _captureThread.Start();
        }

        private void DisplayWebcam()
        {
            while (_capture.IsOpened)
            {
                Mat frame = _capture.QueryFrame();
                if (frame == null) continue;

                //Raw Image code
                int newHeight = (frame.Size.Height * PictureBoxRaw.Size.Width) / frame.Size.Width;
                Size newSize = new Size(PictureBoxRaw.Size.Width, newHeight);
                CvInvoke.Resize(frame, frame, newSize);
                PictureBoxRaw.Image = frame.ToBitmap();

                // Lane Line Detection (Binary Thresholding)
                Mat grayFrame = new Mat();
                CvInvoke.CvtColor(frame, grayFrame, ColorConversion.Bgr2Gray);
                Mat laneBinary = new Mat();
                CvInvoke.Threshold(grayFrame, laneBinary, 200, 255, ThresholdType.Binary);
                PictureBoxLaneLines.Image = laneBinary.ToBitmap();

                // Red Line Detection (HSV)
                Mat hsvFrame = new Mat();
                CvInvoke.CvtColor(frame, hsvFrame, ColorConversion.Bgr2Hsv);
                Mat redMask = new Mat();
                CvInvoke.InRange(hsvFrame, new ScalarArray(new MCvScalar(0, 120, 70)), new ScalarArray(new MCvScalar(10, 255, 255)), redMask);
                PictureBoxRedLine.Image = redMask.ToBitmap();

                // Line Following Logic
                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_captureThread != null && _captureThread.IsAlive)
                _captureThread.Abort();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

