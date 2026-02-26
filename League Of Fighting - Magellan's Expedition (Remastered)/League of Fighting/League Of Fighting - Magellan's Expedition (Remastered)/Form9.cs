using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace League_Of_Fighting___Magellan_s_Expedition__Remastered_
{
    public partial class Form9 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form9()
        {
            InitializeComponent();
            player.SoundLocation = @"Button1.wav";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Play();
            label1.Visible = true;
            button2.Visible = true;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Play();
            label2.Visible = true;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.Play();
            Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            Close();
        }
    }
}
