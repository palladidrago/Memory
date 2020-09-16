using Memory_Thatcher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Thatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool Is1Back = true;

        private bool Is2Back = true;

        private bool Is3Back = true;

        private bool Is4Back = true;

        private bool Is5Back = true;

        private bool Is6Back = true;

        private bool Is7Back = true;

        private bool Is8Back = true;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Pic1_Click(object sender, EventArgs e)
        {
            if (Is1Back) { this.Pic1.Image = Resources.Back;   }
            else { this.Pic1.Image = Resources.Roni; }
            Is1Back = !Is1Back;
        }
        private void Pic2_Click(object sender, EventArgs e)
        {
            if (Is2Back) { this.Pic2.Image = Resources.Back; }
            else { this.Pic2.Image = Resources.Roni; }
            Is2Back = !Is2Back;

        }
        private void Pic3_Click(object sender, EventArgs e)
        {
            if (Is3Back) { this.Pic3.Image = Resources.Back; }
            else { this.Pic3.Image = Resources.Roni; }
            Is3Back = !Is3Back;

        }
        private void Pic4_Click(object sender, EventArgs e)
        {
            if (Is4Back) { this.Pic4.Image = Resources.Back; }
            else { this.Pic4.Image = Resources.Roni; }
            Is4Back = !Is4Back;

        }
        private void Pic5_Click(object sender, EventArgs e)
        {
            if (Is5Back) { this.Pic5.Image = Resources.Back; }
            else { this.Pic5.Image = Resources.Roni; }
            Is5Back = !Is5Back;
        }
        private void Pic6_Click(object sender, EventArgs e)
        {
            if (Is4Back) { this.Pic6.Image = Resources.Back; }
            else { this.Pic6.Image = Resources.Roni; }
            Is6Back = !Is6Back;

        }
        private void Pic7_Click(object sender, EventArgs e)
        {
            if (Is7Back) { this.Pic7.Image = Resources.Back; }
            else { this.Pic7.Image = Resources.Roni; }
            Is7Back = !Is7Back;

        }
        private void Pic8_Click(object sender, EventArgs e)
        {
            if (Is8Back) { this.Pic8.Image = Resources.Back; }
            else { this.Pic8.Image = Resources.Roni; }
            Is8Back = !Is1Back;

        }
    }
}
