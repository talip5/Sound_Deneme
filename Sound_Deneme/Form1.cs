using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sound_Deneme
{
    public partial class Form1 : Form
    {
        public string url5;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged+=ComboBox1_SelectedIndexChanged;
                     
                  
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.SelectedText;

            
            //axWindowsMediaPlayer1.URL =comboBox1.SelectedText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartPosition =FormStartPosition.Manual;
            //this.ClientSize = new Size(800,600);
            this.Width = 1200;
           this.Height =600;
            this.Font = new Font(this.Font.Name,14);
            this.Text = " Hello";
            button1.Font = this.Font;
           //label1.Text =this.Width.ToString();
            this.Location = new Point(10, 10);
            panel1.BackColor = Color.Orange;
            panel2.BackColor = Color.Green;
            panel3.BackColor = Color.BlueViolet;
            label1.BackColor = Color.White;
            label2.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel2.Dock = DockStyle.Fill;
            panel3.Dock = DockStyle.Right;
            int width_panel2 = panel2.Width;
            int height_panel2 = panel2.Height;
            label1.Text = width_panel2.ToString();
            label2.Text = height_panel2.ToString();
            axWindowsMediaPlayer1.Width = width_panel2;
            axWindowsMediaPlayer1.Height = height_panel2-200;
            button1.Text = "start";
            button2.Text ="Play";
            button3.Text ="Pause";
            button4.Text ="Stop";
            comboBox1.Text ="Giriş yapınız";
            comboBox1.Items.Add("C:\\MediaPlayer\\ses1.mp3");
            //axWindowsMediaPlayer1.URL =(@"C:\MediaPlayer\ses1.mp3");
            url5 = axWindowsMediaPlayer1.URL;
            url5 =(@"C:\MediaPlayer\ses1.mp3");
            comboBox1.Items.Add(url5);
            comboBox1.Items.Add("C:\\MediaPlayer\\video1.mp4");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.URL=(@"C:\MediaPlayer\ses1.mp3");
            //axWindowsMediaPlayer1.URL=(@"http:/37.247.98.8/stream/166/");
            axWindowsMediaPlayer1.URL = url5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = comboBox1.Text;
            axWindowsMediaPlayer1.URL =comboBox1.Text;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
