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
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();


        public Form1()
        {
            InitializeComponent();
            player.SoundLocation = @"Button1.wav";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Play();
            Hide();
            Form9 f9 = new Form9();
            f9.ShowDialog();
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
