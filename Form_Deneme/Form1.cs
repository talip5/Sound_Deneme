using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Deneme
{
    public partial class Form1 : Form
    { public Color color1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int form_width = Screen.PrimaryScreen.Bounds.Width;
            //label1.Text = form_width.ToString();
            int form_current_width = this.Width;
            //label1.Text = form_current_width.ToString();
            this.Width = 1800;
            this.Location = new Point(10,10);
            color1 = this.BackColor;
            //label1.Text = color1.Name;
            //label1.Text = color1.IsKnownColor.ToString();           
           // label1.Text = color1.IsEmpty ? string.Empty : color1.ToString();
           //label1.Text =color1.IsEmpty.ToString();
           label1.Text = color1.IsNamedColor.ToString();

        }
    }
}
