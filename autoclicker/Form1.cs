using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Threading;

//Learn-Site.Com
namespace autoclicker
{
    public partial class Form1 : Form
    {
        //mouse event constants
        const int MOUSEEVENTF_LEFTDOWN = 2;
        const int MOUSEEVENTF_LEFTUP = 4;
        const int MOUSEEVENTF_RIGHTDOWN = 8;
        const int MOUSEEVENTF_RIGHT_UP = 16;
        //input type constant
        const int INPUT_MOUSE = 0;

        [DllImport("User32.dll", SetLastError = true)]
        public static extern int SendInput(int nInputs, ref INPUT pInputs, int cbSize);

        Point clickLocation;
        Point CLICK2;
        Point CLICK3;
        static string fname1, fname2;
        Bitmap img1, img2;
        int count1 = 0, count2 = 0;
        bool flag = true;

        public Form1()
        {
            InitializeComponent();
            this.Text = "autoclicker " + clickLocation.ToString();
        }

        private void btnSetPoint_Click(object sender, EventArgs e)
        {
            timerPoint.Interval = 5000;
            timerPoint.Start();
        }

        private void timerPoint_Tick(object sender, EventArgs e)
        {
            clickLocation = Cursor.Position;
            this.Text = "autoclicker " + clickLocation.ToString();
            timerPoint.Stop();
        }
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter+=1;
            //set cursor position to memorized location
            Cursor.Position = clickLocation;
           
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0; //clickLocation.X;
            i.mi.dy = 0; // clickLocation.Y;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
            this.Text += counter.ToString();
            if (counter==1)
            {
                
                this.Activate();
                timer1.Stop();
                timer2.Start();
                counter = 0;
                this.Activate();
            }
        }

        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        public struct INPUT
        {
            public uint type;
            public MOUSEINPUT mi;
        };

        private void btnStart_Click(object sender, EventArgs e)
        {
            //set appropriate timer interval - if user selected seconds or milliseconds
            if (rbMilliseconds.Checked)
            {
                timer1.Interval = (int)numericUpDown1.Value;
                timer2.Interval = (int)numericUpDown1.Value;
                timer4.Interval = (int)numericUpDown1.Value;
            }
            else
            {
                timer1.Interval = (int)numericUpDown1.Value * 1000;
                timer2.Interval = (int)numericUpDown1.Value * 1000;
                timer4.Interval = (int)numericUpDown1.Value * 1000;

            }
            

            if (!timer1.Enabled)
            {
                timer1.Start();
                this.Text = "autoclicker - started";
            }
            else
            {
                timer1.Stop();
                this.Text = "autoclicker - stopped";
            }

            ////
            //if (rbMilliseconds.Checked)
            //    timer2.Interval = (int)numericUpDown2.Value;
            //else
            //    timer2.Interval = (int)numericUpDown2.Value * 1000;

            //if (!timer2.Enabled)
            //{
            //    timer2.Start();
            //    this.Text = "autoclicker2 - started";
            //}
            //else
            //{
            //    timer2.Stop();
            //    this.Text = "autoclicker2 - stopped";
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text += "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timerpoint2.Interval = 5000;
            timerpoint2.Start();
        }
        Bitmap bmp_image;
        private void fd(object sender,EventArgs e)
        {
            MessageBox.Show("a");
        }
        private void timerpoint2_Tick(object sender, EventArgs e)
        {
           
            CLICK2 = Cursor.Position;
            // MessageBox.Show()//
            //this.BackColor = Color.FromArgb(s.BitsPerPixel, bmp_image.GetPixel(a, b).G, bmp_image.GetPixel(a, b).B);
            this.Text += "autoclicker " + CLICK2.ToString();
            timerpoint2.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter += 1;
            Cursor.Position = CLICK2;

            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0; //clickLocation.X;
            i.mi.dy = 0; // clickLocation.Y;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            
            //send the input
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
            
            if (counter== 1)
            {
               
                this.Activate();
                timer2.Stop();
                timer4.Start();
                counter = 0;
                this.Activate();
            }
        }
        Color c;
        private void button4_Click_1(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.AnyColor = true;

            colorDialog1.SolidColorOnly = false;

            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                c = colorDialog1.Color;
                this.BackColor = c;
            }
            
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timepoint3.Interval = 5000;
            timepoint3.Start();
        }
        //private static Thread th = new Thread(new ThreadStart(f));
        //public void startProgress()
        //{
        //    th = new Thread(new ThreadStart(f));
        //    th.Start();
        //}
        //public void stopProgress()
        //{
        //    th.Abort();
        //    th = null;
        //}
        //private static void f()
        //{
        //    File.Delete(@"D:\pardakht1.png");
        //    aa = 1;
        //}
        public static int aa = 0;
        private void timer4_Tick(object sender, EventArgs e)
        {
            counter += 1;
            Cursor.Position = CLICK3;

            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0; //clickLocation.X;
            i.mi.dy = 0; // clickLocation.Y;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));

            if (counter == 1)
            {
                Screen s = Screen.PrimaryScreen;
                Bitmap bit = new Bitmap(CLICK3.X, CLICK3.Y);
                Graphics g = Graphics.FromImage(bit);
                g.CopyFromScreen(CLICK3.X, CLICK3.Y, 5, 20, new Size(150, 150));
                if (File.Exists(@"D:\pardakht.png"))
                {

                    bit.Save(@"D:\pardakht1.png", System.Drawing.Imaging.ImageFormat.Png);

                    //ar = File.ReadAllBytes(@"D:\pardakht.png");
                    //byte[] bs = (byte[])ar;
                    //string food = Encoding.ASCII.GetString(bs);
                    //byte[] binaryString = File.ReadAllBytes(@"D:\pardakht1.png");
                    //string foo = Encoding.UTF8.GetString(binaryString);
                    //timer1.Stop();
                    //timer2.Stop();
                    //timer4.Stop();
                    //MessageBox.Show(binaryString.ToString() + "  " + ar.ToString());



                    fname1 = @"D:\pardakht.png";
                    fname2 = @"D:\pardakht1.png";
                    string img1_ref, img2_ref;
                    img1 = new Bitmap(fname1);
                    img2 = new Bitmap(fname2);
                    if (img1.Width == img2.Width && img1.Height == img2.Height)
                    {
                        for (int ii = 0; ii < img1.Width; ii++)
                        {
                            for (int j = 0; j < img1.Height; j++)
                            {
                                img1_ref = img1.GetPixel(ii, j).ToString();
                                img2_ref = img2.GetPixel(ii, j).ToString();
                                if (img1_ref != img2_ref)
                                {
                                    count2++;
                                    flag = false;
                                    break;
                                }
                                count1++;
                            }
                            
                        }

                        if (flag == false)
                        {
                            timer1.Stop();
                            timer2.Stop();
                            timer4.Stop();
                            MessageBox.Show("finish");
                        }

                        else
                        {

                  

                                File.Delete(@"D:\pardakht1.png");
                            
                            this.Activate();
                            timer4.Stop();
                            timer1.Start();
                            counter = 0;
                            this.Activate();
                            //startProgress();
                            //if (aa == 1)
                            //{
                            //    stopProgress();
                            //}
                        }
                           
                    }
                    else
                        MessageBox.Show("can not compare this images");
                    
                }
                

            }
        }

        private void timepoint3_Tick(object sender, EventArgs e)
        {
            CLICK3 = Cursor.Position;
            Screen s = Screen.PrimaryScreen;
            Bitmap bit = new Bitmap(CLICK3.X, CLICK3.Y);
            Graphics g = Graphics.FromImage(bit);
            g.CopyFromScreen(CLICK3.X, CLICK3.Y, 5, 20, new Size(150, 150));
            bit.Save(@"D:\pardakht.png", System.Drawing.Imaging.ImageFormat.Png);
            
            this.Text += "autoclicker " + CLICK3.ToString();
            timepoint3.Stop();
        }
       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
        }
        Color ccs; 
        private void button6_Click(object sender, EventArgs e)
        {

           
            


        }
    }
}