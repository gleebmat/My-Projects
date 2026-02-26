using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace League_Of_Fighting___Magellan_s_Expedition__Remastered_
{
    public partial class Form2 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();



        public Form2()
        {
            InitializeComponent();
            player.SoundLocation = @"Magellan's Expedition.wav";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            label2.Visible = true;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            player.Play();
            button2.Visible = false;
            label2.Visible = false;

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
