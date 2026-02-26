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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox4.SelectedItem = "Model 1";
            pictureBox1.BackgroundImage = Image.FromFile(DataStorage.Model1);
            DataStorage.Model1 = DataStorage.PlayerModel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="")
            {
                MessageBox.Show("Okay, how should I call you? Bastard, maybe???");
                DataStorage.Name = "Joe";

            }
            else
            {
                DataStorage.Name = comboBox1.Text;

            }
            if (comboBox2.Text=="")
            {
                MessageBox.Show("Excellent work, jerk! Nice surname!");
                DataStorage.Surname = "Immobilizer";

            }
            else
            {
                DataStorage.Surname = comboBox2.Text;

            }
            if (comboBox3.Text=="")
            {
                MessageBox.Show("Oh wow, what a pretty alias, idiot!");
                DataStorage.Alias = "Captain Yarrface";
            }
            else
            {
                DataStorage.Alias = comboBox3.Text;

            }
            if (trackBar1.Value<14||trackBar1.Value>85)
            {
                MessageBox.Show("Oh! Your age isn't suitable! I'll give you 35 years!");
                DataStorage.Age = 35;

            }
            else
            {
                DataStorage.Age = trackBar1.Value;
            }
            MessageBox.Show("So,\n" + DataStorage.Age + "-year " + DataStorage.Name + " " + DataStorage.Surname + " or just " + DataStorage.Alias);
            
            Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            Close();
        }

   


private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox4.SelectedItem=="Model 1")
            {                
                pictureBox1.BackgroundImage = Image.FromFile(DataStorage.Model1);
                DataStorage.PlayerModel = DataStorage.Model1;
            }
            else
            if (comboBox4.SelectedItem == "Model 2")
            {
                pictureBox1.BackgroundImage = Image.FromFile(DataStorage.Model2);
                DataStorage.PlayerModel = DataStorage.Model2;
            }
            else
            if (comboBox4.SelectedItem == "Model 3")
            {
                pictureBox1.BackgroundImage = Image.FromFile(DataStorage.Model3);
                DataStorage.PlayerModel = DataStorage.Model3;
            }
            else
            if (comboBox4.SelectedItem == "Model 4")
            {
                pictureBox1.BackgroundImage = Image.FromFile(DataStorage.Model4);
                DataStorage.PlayerModel = DataStorage.Model4;
            }
            else
            if (comboBox4.SelectedItem == "Model 5")
            {
                pictureBox1.BackgroundImage = Image.FromFile(DataStorage.Model5);
                DataStorage.PlayerModel = DataStorage.Model5;
            }
            else
            if (comboBox4.SelectedItem == "Model 6")
            {
                pictureBox1.BackgroundImage = Image.FromFile(DataStorage.Model6);
                DataStorage.PlayerModel = DataStorage.Model6;
            }
            else
            if (comboBox4.SelectedItem == "Model 7")
            {
                pictureBox1.BackgroundImage = Image.FromFile(DataStorage.Model7);
                DataStorage.PlayerModel = DataStorage.Model7;
            }
            else
            if (comboBox4.SelectedItem == "Model 8")
            {
                pictureBox1.BackgroundImage = Image.FromFile(DataStorage.Model8);
                DataStorage.PlayerModel = DataStorage.Model8;
            }
            else
            {
                pictureBox1.BackgroundImage = Image.FromFile(DataStorage.Model3);
                DataStorage.PlayerModel = DataStorage.Model3;

            }
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label5.Text = "Age : " + trackBar1.Value;
        }
    }
}
