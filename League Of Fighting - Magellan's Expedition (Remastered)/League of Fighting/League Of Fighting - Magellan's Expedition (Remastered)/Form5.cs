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
    public partial class Form5 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();

        public Form5()
        {
            InitializeComponent();
            player.SoundLocation = @"Drink.wav";
            player1.SoundLocation = @"1741.wav";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form10 f10 = new Form10();
            f10.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            pictureBox1.BackgroundImage = Image.FromFile(DataStorage.PlayerModel);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            player.Play();
            pictureBox1.BackgroundImage = null;
            label2.Text = "Welcome to the Sea!\n\nYour name - "+DataStorage.Name+"\n\nYour surname - "+DataStorage.Surname+"\n\nYour alias - "+DataStorage.Alias+"\n\nYour age : "+DataStorage.Age;
            label2.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
