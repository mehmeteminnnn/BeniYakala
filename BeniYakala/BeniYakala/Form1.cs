using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeniYakala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int i = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = i.ToString();
            if(i<20)
            {
                i++;
            }
            else
            {
                MessageBox.Show("Oyun Bitti!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd= new Random();
            button1.Left=Convert.ToInt32(rnd.Next(Size.Width-button1.Size.Width));
            button1.Top = Convert.ToInt32(rnd.Next(Size.Height - (label1.Height)*2));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }
    }
}
