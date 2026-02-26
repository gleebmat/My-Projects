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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (checkBox1.Checked==true)
                {
                    DataStorage.ApplyBandages = true;
                }
               
                if(radioButton6.Checked==true)
                {
                    DataStorage.TypeOfPirate = "Weak Pirate";
                }
                else if(radioButton5.Checked==true)
                {
                    DataStorage.TypeOfPirate = "Medium Pirate";
                }
                else if(radioButton4.Checked==true)
                {
                    DataStorage.TypeOfPirate = "Strong Pirate";
                }
                
                DataStorage.EnemyName = textBox1.Text;
                Hide();
                Form7 f7 = new Form7();
                f7.ShowDialog();
                Close();

            }
            catch(Exception error)
            {
                MessageBox.Show(error + "");
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Enemy 1";
            DataStorage.EnemyModel = DataStorage.Enemy1;
            radioButton6.Checked = true;
            label3.Text = DataStorage.Name;
            pictureBox1.BackgroundImage = Image.FromFile(DataStorage.PlayerModel);
            radioButton6.Checked = true;
            pictureBox2.BackgroundImage = Image.FromFile("D://Portfolio//My Own Games//League Of Fighting - Magellan's Expedition (Remastered)//League Of Fighting - Magellan's Expedition (Remastered)//bin//Debug//Enemy1.jpg");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Enemy 1")
            {
                pictureBox2.BackgroundImage = Image.FromFile(DataStorage.Enemy1);
                DataStorage.EnemyModel = DataStorage.Enemy1;
            }
            if (comboBox1.SelectedItem == "Enemy 2")
            {
                pictureBox2.BackgroundImage = Image.FromFile(DataStorage.Enemy2);
                DataStorage.EnemyModel = DataStorage.Enemy2;
            }
            if (comboBox1.SelectedItem == "Enemy 3")
            {
                pictureBox2.BackgroundImage = Image.FromFile(DataStorage.Enemy3);
                DataStorage.EnemyModel = DataStorage.Enemy3;
            }
            if (comboBox1.SelectedItem == "Enemy 4")
            {
                pictureBox2.BackgroundImage = Image.FromFile(DataStorage.Enemy4);
                DataStorage.EnemyModel = DataStorage.Enemy4;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
