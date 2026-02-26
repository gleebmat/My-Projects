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
    public partial class Form10 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();

        public Form10()
        {
            InitializeComponent();
            player.SoundLocation = @"Magnetic North.wav";
            player1.SoundLocation = @"Curse.wav";
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            player.Play();
            label2.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label3.Visible = false;
            button4.Visible = false;
            label4.Visible = false;
            button5.Visible = false;
            label5.Visible = false;
            button6.Visible = false;
            label6.Visible = false;
            button7.Visible = false;
            label7.Visible = false;
            button8.Visible = false;
            label8.Visible = false;
            button9.Visible = false;
            label9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            label10.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = false;
            label2.Visible = true;
            button2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            label3.Visible = false;
            button4.Visible = true;
            label4.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            label2.Visible = false;
            button3.Visible = true;
            label3.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            label4.Visible = false;
            button5.Visible = true;
            label5.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            label5.Visible = false;
            button6.Visible = true;
            label6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            player1.Play();
            button6.Visible = false;
            label6.Visible = false;
            button7.Visible = true;
            label7.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
            label7.Visible = false;
            button8.Visible = true;
            label8.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Visible = false;
            label8.Visible = false;
            button9.Visible = true;
            label9.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            label9.Visible = false;
            label10.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
