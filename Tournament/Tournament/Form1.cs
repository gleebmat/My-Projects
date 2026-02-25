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

namespace Tournament
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();//создаём специальные хранилища для аудиофайлов
        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player3 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player4 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player5 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player6 = new System.Media.SoundPlayer();
        Random hit1 = new Random();

        int hit;
        int end = 0;
        int life = 100;
        int years;
        string name;
        int strong = 0;
        int clever = 0;
        int brave = 0;
        int nosy = 0;
        int lucky = 0;
        int level = 1;
        int famous = 0;
        int a = 0;
        int b = 0;
        int c = 0;
        int days = 13;

        public Form1()
        {
            InitializeComponent();
            player.SoundLocation = "MBMainTheme.wav";//указываем название
            player2.SoundLocation = "Mount-Blade-41__allmp3.su_.wav";
            player3.SoundLocation = "Ambushed.wav";
            player4.SoundLocation = "Calm-Night.wav";
            player5.SoundLocation = "Uncertain-Homestead.wav";
            player6.SoundLocation = "Crazy-Battle.wav";
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
        }



        private void buttonStart_Click(object sender, EventArgs e)//все кнопки!!!
        {

        }


        private void buttonHello_Click_1(object sender, EventArgs e)//переключает на второе окно Настроек
        {
            labelHello.Visible = false;
            buttonHello.Visible = false;
            labelHello1.Visible = true;
            buttonHello1.Visible = true;

        }

        private void buttonHello1_Click_1(object sender, EventArgs e)//переключает на третье окно Настроек
        {
            label17.Visible = true;
            label18.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox3.Text = strong.ToString();
            textBox4.Text = clever.ToString();
            textBox5.Text = lucky.ToString();
            textBox6.Text = nosy.ToString();
            textBox7.Text = brave.ToString();
            textBox8.Text = famous.ToString();
            textBox9.Text = level.ToString();
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            labelHello1.Visible = false;
            buttonHello1.Visible = false;
            labelHello2.Visible = true;
            buttonSettings.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            trackBar2.Visible = true;
            groupBox1.Visible = true;
            
        }

        private void buttonHello2_Click(object sender, EventArgs e)//обработка настроек
        {
            name = textBox2.Text;
            if (years <= 12 || years >= 65)
            {
                MessageBox.Show("Ваш возраст не подходит к экстремальным приключениям!\nОн будет равен 35, ладно?");
                years = 35;
            }
            MessageBox.Show("Вы прошли вступление игры!\nВаше имя - ' " + name + " '\nВаш возраст - " + years);
            tabPage11.Enabled = false;
            tabPage12.Visible = true;
            tabPage12.Enabled = true;
            buttonAnswer.Visible = true;
            label5.Visible = true;
            label6.Visible = false;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = false;
            label13.Visible = false;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {   
            label4.Text = "Возраст - "+trackBar2.Value;
            years = Convert.ToInt32(trackBar2.Value);

        }


        private void labelHello_Click(object sender, EventArgs e)
        {

        }

        private void buttonAnswer_Click(object sender, EventArgs e)//переключает на результаты первого диалога Начала
        {
            if(radioButton1.Checked|| radioButton2.Checked|| radioButton3.Checked)
            {
                brave++;
                nosy++;
                clever++;
                strong++;
                label5.Visible = false;
                buttonAnswer.Visible = false;
                label6.Visible = true;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
            }
            else
            {
                clever--;
                nosy--;
                brave--;
                MessageBox.Show("Вы решили промолчать!");
                label5.Visible = false;
                buttonAnswer.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                label6.Visible = true;
            }
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            buttonAnswer2.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAnswer2_Click_1(object sender, EventArgs e)//переключает на 'сброс с лодки'
        {
            if (radioButton4.Checked)
            {
                strong++;
                brave++;
                nosy++;
                famous++;
                famous++;
                buttonAnswer2.Visible = false;
                label6.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
            }
            else if (radioButton5.Checked)
            {
                clever--;
                famous++;
                strong--;
                buttonAnswer2.Visible = false;
                label6.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
            }
            else
            {
                clever--;
                famous++;
                strong--;
                MessageBox.Show("Вы решили промолчать!");
                buttonAnswer2.Visible = false;
                label6.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
            }
            label12.Visible = true;
            radioButton6.Visible = true;
            radioButton7.Visible = true;
            button4.Visible = true;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click_1(object sender, EventArgs e)//последняя кнопка второй главы!
        {

            if (a != 0)
            {
                if (radioButton8.Checked || radioButton9.Checked)
                {
                    nosy++;
                    famous++;
                    brave++;
                    strong++;
                    button3.Visible = false;
                    radioButton8.Visible = false;
                    radioButton9.Visible = false;
                    label15.Visible = false;
                    label16.Visible = true;//конец Начала!
                    button6.Visible = true;//один путь
                }
                else
                {
                    clever--;
                    MessageBox.Show("Вы решили промолчать!");
                    button3.Visible = false;
                    radioButton8.Visible = false;
                    radioButton9.Visible = false;
                    label15.Visible = false;
                    label16.Visible = true;//конец Начала!
                    button6.Visible = true;//один путь
                }
                button3.Visible = false;

            }
            else
            {
                label14.Visible = false;
                button5.Visible = true;//второй путь
                label19.Visible = true;
                button3.Visible = false;
            }

        }



        private void button4_Click(object sender, EventArgs e)//переключает на поход в таверну, первый выбор
        {
            if (radioButton6.Checked)
            {
                a++;
                lucky++;
                brave++;
                nosy++;
                clever++;
                label13.Visible = false;
                label12.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                button3.Visible = true;
                button4.Visible = false;
                label15.Visible = true;
                radioButton8.Visible = true;
                radioButton9.Visible = true;
                button4.Visible = false;


            }
            else if (radioButton7.Checked)
            {
                lucky--;
                brave--;
                strong--;
                clever--;
                nosy--;
                b++;
                label14.Visible = true;//Направляйтесь куда хотите!
                label12.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                button3.Visible = true;
                button4.Visible = false;
            }
            else
            {
                b++;
                MessageBox.Show("Вы решили промолчать!");
                lucky--;
                brave--;
                strong--;
                clever--;
                nosy--;
                label14.Visible = true;
                label12.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                button3.Visible = true;
                button4.Visible = false;

            }
            button3.Visible = true;
            button4.Visible = false;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label17.Visible = true;
            label18.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            if (clever >= 5 || strong >= 5 || brave >= 5 || famous >= 5)
            {
                level++;
            }
            if (clever >= 10 || strong >= 10 || brave >= 10 || famous >= 10)
            {
                level++;
            }
            if (clever >= 15 || strong >= 15 || brave >= 15 || famous >= 15)
            {
                level++;
            }
            if (clever >= 20 || strong >= 20 || brave >= 20 || famous >= 20)
            {
                level++;
            }
            textBox16.Text = strong.ToString();
            textBox15.Text = clever.ToString();
            textBox14.Text = lucky.ToString();
            textBox13.Text = nosy.ToString();
            textBox12.Text = brave.ToString();
            textBox11.Text = famous.ToString();
            textBox10.Text = level.ToString();
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = false;
            textBox16.Enabled = false;
            label16.Visible = false;
            button6.Visible = false;
            groupBox2.Visible = true;
            button7.Visible = true;
            label27.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            button5.Visible = false;
            label17.Visible = true;
            label18.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            if (clever >= 5 && level==1|| strong >= 5 && level==1|| brave >= 5 && level==1|| famous >= 5&&level==1)
            {
                level++;
            }
            if (clever >= 10 && level<=2|| strong >= 10 && level <= 2 || brave >= 10 && level <= 2 || famous >= 10 && level <= 2)
            {
                level++;
            }
            if (clever >= 15&&level<=3 || strong >= 15 && level <= 3 || brave >= 15 && level <= 3 || famous >= 15 && level <= 3)
            {
                level++;
            }
            if (clever >= 20 &&level<=4|| strong >= 20 && level <= 4 || brave >= 20 && level <= 4 || famous >= 20 && level <= 4)
            {
                level++;
            }
            textBox16.Text = strong.ToString();
            textBox15.Text = clever.ToString();
            textBox14.Text = lucky.ToString();
            textBox13.Text = nosy.ToString();
            textBox12.Text = brave.ToString();
            textBox11.Text = famous.ToString();
            textBox10.Text = level.ToString();
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = false;
            textBox16.Enabled = false;
            label19.Visible = false;
            button7.Visible = true;
            label27.Visible = true;


        }

        private void button7_Click(object sender, EventArgs e)//переход в главу Саргот
        {
            a = 0;
            b = 0;
            tabPage12.Enabled = false;
            tabPage13.Visible = true;
            tabPage13.Enabled = true;
            label30.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            button8.Visible = false;
            label28.Visible = true;
            label29.Visible = true;
            textBox17.Visible = true;
            textBox17.Text = days.ToString();
            label30.Visible = true;
            radioButton10.Visible = true;
            radioButton11.Visible = true;
            button8.Visible = true;
            player.Stop();
            player2.Play();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void buttonStart_Click_1(object sender, EventArgs e)//все кнопки старта игры
        {
            
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            labelHello1.Visible = false;
            labelHello2.Visible = false;
            labelHello.Visible = true;
            buttonHello.Visible = true;
            buttonHello1.Visible = false;
            buttonSettings.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            trackBar2.Visible = false;
            tabPage12.Visible = false;
            tabPage12.Enabled = false;
            buttonAnswer.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            buttonAnswer2.Visible = false;
            groupBox1.Visible = false;
            label12.Visible = true;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            button2.Visible = false;
            label15.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            label18.Visible = false;
            button6.Visible = false;
            button5.Visible = false;
            label19.Visible = false;
            groupBox2.Visible = false;
            button7.Visible = false;
            tabPage13.Visible = false;
            tabPage13.Enabled = false;
            label12.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            textBox17.Visible = false;
            label30.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            button8.Visible = false;
            label31.Visible = false;
            radioButton12.Visible = false;
            radioButton13.Visible = false;
            button9.Visible = false;
            label32.Visible = false;
            radioButton14.Visible = false;
            radioButton15.Visible = false;
            button10.Visible = false;
            player.Play();
            label33.Visible = false;
            button11.Visible = false;
            groupBox3.Visible = false;
            tabPage12.Visible = false;
            tabPage12.Enabled = false;
            tabPage14.Visible = false;
            tabPage14.Enabled = false;
            label41.Visible = false;
            label42.Visible = true;
            button13.Visible = true;
            label42.Visible = false;
            label43.Visible = false;
            radioButton16.Visible = false;
            radioButton17.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            label44.Visible = false;
            button15.Visible = false;
            label45.Visible = false;
            label46.Visible = false;
            button16.Visible = false;
            label47.Visible = false;
            button17.Visible = false;
            label48.Visible = false;
            groupBox4.Visible = false;
            tabPage15.Visible = false;
            tabPage15.Enabled = false;
            button18.Visible = false;
            label56.Visible = false;
            radioButton18.Visible = false;
            radioButton19.Visible = false;
            button19.Visible = false;
            label57.Visible = false;
            button20.Visible = false;
            label58.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            buttonStart.Visible = false;
            label59.Visible = false;
            button25.Visible = false;
            label60.Visible = false;
            label61.Visible = false;
            button26.Visible = false;
            label62.Visible = false;
            button27.Visible = false;
            radioButton20.Visible = false;
            radioButton21.Visible = false;
            label63.Visible=false;
            groupBox5.Visible = false;
            button28.Visible = false;
            tabPage16.Enabled = false;
            tabPage16.Visible = false;
            label72.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            label73.Visible = false;
            button31.Visible = false;
            label74.Visible = false;
            button32.Visible = false;
            label71.Visible = false;
            button30.Visible = false;
            label75.Visible = false;
            button33.Visible = false;
            label76.Visible = false;
            button34.Visible = false;
            button35.Visible = false;
            label77.Visible = false;
            label78.Visible = false;
            button36.Visible = false;
            label79.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            label80.Visible=false;
            button39.Visible = false;
            label81.Visible = false;
            label82.Visible = false;
            button40.Visible = false;
            label83.Visible = false;
            button41.Visible = false;
            label84.Visible = false;
            label85.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            label86.Visible = false;
            label87.Visible = false;
            button44.Visible = false;
            label88.Visible = false;
            button45.Visible = false;
            label89.Visible = false;
            button46.Visible = false;
            radioButton22.Visible = false;
            radioButton23.Visible = false;
            label90.Visible = false;
            button47.Visible = false;
            label91.Visible = false;
            progressBar1.Visible = false;
            label92.Visible = false;
            label93.Visible = false;
            button48.Visible = false;
            label94.Visible = false;
            label95.Visible = false;
            button49.Visible = false;
            label96.Visible = false;
            button50.Visible = false;
            label97.Visible = false;
            button51.Visible = false;
            label98.Visible=false;
            label99.Visible = false;
            button53.Visible = false;
            tabPage17.Visible = false;
            tabPage17.Enabled = false;
            label108.Visible = false;
            label109.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button52.Visible = false;
        }
        private void button21_Click(object sender, EventArgs e)
        {
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            labelHello1.Visible = false;
            labelHello2.Visible = false;
            labelHello.Visible = true;
            buttonHello.Visible = true;
            buttonHello1.Visible = false;
            buttonSettings.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            trackBar2.Visible = false;
            tabPage12.Visible = false;
            tabPage12.Enabled = false;
            buttonAnswer.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            buttonAnswer2.Visible = false;
            groupBox1.Visible = false;
            label12.Visible = true;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            button2.Visible = false;
            label15.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            label18.Visible = false;
            button6.Visible = false;
            button5.Visible = false;
            label19.Visible = false;
            groupBox2.Visible = false;
            button7.Visible = false;
            tabPage13.Visible = false;
            tabPage13.Enabled = false;
            label12.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            textBox17.Visible = false;
            label30.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            button8.Visible = false;
            label31.Visible = false;
            radioButton12.Visible = false;
            radioButton13.Visible = false;
            button9.Visible = false;
            label32.Visible = false;
            radioButton14.Visible = false;
            radioButton15.Visible = false;
            button10.Visible = false;
            player.Play();
            label33.Visible = false;
            button11.Visible = false;
            groupBox3.Visible = false;
            tabPage12.Visible = false;
            tabPage12.Enabled = false;
            tabPage14.Visible = false;
            tabPage14.Enabled = false;
            label41.Visible = false;
            label42.Visible = true;
            button13.Visible = true;
            label42.Visible = false;
            label43.Visible = false;

            radioButton16.Visible = false;
            radioButton17.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            label44.Visible = false;
            button15.Visible = false;
            label45.Visible = false;
            label46.Visible = false;
            button16.Visible = false;
            label47.Visible = false;
            button17.Visible = false;
            label48.Visible = false;
            groupBox4.Visible = false;
            tabPage15.Visible = false;
            tabPage15.Enabled = false;
            button18.Visible = false;
            label56.Visible = false;
            radioButton18.Visible = false;
            radioButton19.Visible = false;
            button19.Visible = false;
            label57.Visible = false;
            button20.Visible = false;
            label58.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            buttonStart.Visible = false;
            label59.Visible = false;
            button25.Visible = false;
            label60.Visible = false;
            label61.Visible = false;
            button26.Visible = false;
            label62.Visible = false;
            button27.Visible = false;
            radioButton20.Visible = false;
            radioButton21.Visible = false;
            label63.Visible = false;
            groupBox5.Visible = false;
            button28.Visible = false;
            tabPage16.Enabled = false;
            tabPage16.Visible = false;
            label72.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            label73.Visible = false;
            button31.Visible = false;
            label74.Visible = false;
            button32.Visible = false;
            label71.Visible = false;
            button30.Visible = false;
            label75.Visible = false;
            button33.Visible = false;
            label76.Visible = false;
            button34.Visible = false;
            button35.Visible = false;
            label77.Visible = false;
            label78.Visible = false;
            button36.Visible = false;
            label79.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            label80.Visible = false;
            button39.Visible = false;
            label81.Visible = false;
            label82.Visible = false;
            button40.Visible = false;
            label83.Visible = false;
            button41.Visible = false;
            label84.Visible = false;
            label85.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            label86.Visible = false;
            label87.Visible = false;
            button44.Visible = false;
            label88.Visible = false;
            button45.Visible = false;
            label89.Visible = false;
            button46.Visible = false;
            radioButton22.Visible = false;
            radioButton23.Visible = false;
            label90.Visible = false;
            button47.Visible = false;
            label91.Visible = false;
            progressBar1.Visible = false;
            label92.Visible = false;
            label93.Visible = false;
            button48.Visible = false;
            label94.Visible = false;
            label95.Visible = false;
            button49.Visible = false;
            label96.Visible = false;
            button50.Visible = false;
            label97.Visible = false;
            button51.Visible = false;
            label98.Visible = false;
            label99.Visible = false;
            button53.Visible = false;
            tabPage17.Visible = false;
            tabPage17.Enabled = false;
            label108.Visible = false;
            label109.Visible = false;
            button52.Visible = false;
        }
        private void button22_Click(object sender, EventArgs e)
        {
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            labelHello1.Visible = false;
            labelHello2.Visible = false;
            labelHello.Visible = true;
            buttonHello.Visible = true;
            buttonHello1.Visible = false;
            buttonSettings.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            trackBar2.Visible = false;
            tabPage12.Visible = false;
            tabPage12.Enabled = false;
            buttonAnswer.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            buttonAnswer2.Visible = false;
            groupBox1.Visible = false;
            label12.Visible = true;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            button2.Visible = false;
            label15.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            label18.Visible = false;
            button6.Visible = false;
            button5.Visible = false;
            label19.Visible = false;
            groupBox2.Visible = false;
            button7.Visible = false;
            tabPage13.Visible = false;
            tabPage13.Enabled = false;
            label12.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            textBox17.Visible = false;
            label30.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            button8.Visible = false;
            label31.Visible = false;
            radioButton12.Visible = false;
            radioButton13.Visible = false;
            button9.Visible = false;
            label32.Visible = false;
            radioButton14.Visible = false;
            radioButton15.Visible = false;
            button10.Visible = false;
            player.Play();
            label33.Visible = false;
            button11.Visible = false;
            groupBox3.Visible = false;
            tabPage12.Visible = false;
            tabPage12.Enabled = false;
            tabPage14.Visible = false;
            tabPage14.Enabled = false;
            label41.Visible = false;
            label42.Visible = true;
            button13.Visible = true;
            label42.Visible = false;
            label43.Visible = false;
            radioButton16.Visible = false;
            radioButton17.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            label44.Visible = false;
            button15.Visible = false;
            label45.Visible = false;
            label46.Visible = false;
            button16.Visible = false;
            label47.Visible = false;
            button17.Visible = false;
            label48.Visible = false;
            groupBox4.Visible = false;
            tabPage15.Visible = false;
            tabPage15.Enabled = false;
            button18.Visible = false;
            label56.Visible = false;
            radioButton18.Visible = false;
            radioButton19.Visible = false;
            button19.Visible = false;
            label57.Visible = false;
            button20.Visible = false;
            label58.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            buttonStart.Visible = false;
            label59.Visible = false;
            button25.Visible = false;
            label60.Visible = false;
            label61.Visible = false;
            button26.Visible = false;
            label62.Visible = false;
            button27.Visible = false;
            radioButton20.Visible = false;
            radioButton21.Visible = false;
            label63.Visible = false;
            groupBox5.Visible = false;
            button28.Visible = false;
            tabPage16.Enabled = false;
            tabPage16.Visible = false;
            label72.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            label73.Visible = false;
            button31.Visible = false;
            label74.Visible = false;
            button32.Visible = false;
            label71.Visible = false;
            button30.Visible = false;
            label75.Visible = false;
            button33.Visible = false;
            label76.Visible = false;
            button34.Visible = false;
            button35.Visible = false;
            label77.Visible = false;
            label78.Visible = false;
            button36.Visible = false;
            label79.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            label80.Visible = false;
            button39.Visible = false;
            label81.Visible = false;
            label82.Visible = false;
            button40.Visible = false;
            label83.Visible = false;
            button41.Visible = false;
            label84.Visible = false;
            label85.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            label86.Visible = false;
            label87.Visible = false;
            button44.Visible = false;
            label88.Visible = false;
            button45.Visible = false;
            label89.Visible = false;
            button46.Visible = false;
            radioButton22.Visible = false;
            radioButton23.Visible = false;
            label90.Visible = false;
            button47.Visible = false;
            label91.Visible = false;
            progressBar1.Visible = false;
            label92.Visible = false;
            label93.Visible = false;
            button48.Visible = false;
            label94.Visible = false;
            label95.Visible = false;
            button49.Visible = false;
            label96.Visible = false;
            button50.Visible = false;
            label97.Visible = false;
            button51.Visible = false;
            label98.Visible = false;
            label99.Visible = false;
            button53.Visible = false;
            tabPage17.Visible = false;
            tabPage17.Enabled = false;
            label108.Visible = false;
            label109.Visible = false;
            button52.Visible = false;
        }
        private void button23_Click(object sender, EventArgs e)
        {
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            labelHello1.Visible = false;
            labelHello2.Visible = false;
            labelHello.Visible = true;
            buttonHello.Visible = true;
            buttonHello1.Visible = false;
            buttonSettings.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            trackBar2.Visible = false;
            tabPage12.Visible = false;
            tabPage12.Enabled = false;
            buttonAnswer.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            buttonAnswer2.Visible = false;
            groupBox1.Visible = false;
            label12.Visible = true;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            button2.Visible = false;
            label15.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            label18.Visible = false;
            button6.Visible = false;
            button5.Visible = false;
            label19.Visible = false;
            groupBox2.Visible = false;
            button7.Visible = false;
            tabPage13.Visible = false;
            tabPage13.Enabled = false;
            label12.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            textBox17.Visible = false;
            label30.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            button8.Visible = false;
            label31.Visible = false;
            radioButton12.Visible = false;
            radioButton13.Visible = false;
            button9.Visible = false;
            label32.Visible = false;
            radioButton14.Visible = false;
            radioButton15.Visible = false;
            button10.Visible = false;
            player.Play();
            label33.Visible = false;
            button11.Visible = false;
            groupBox3.Visible = false;
            tabPage12.Visible = false;
            tabPage12.Enabled = false;
            tabPage14.Visible = false;
            tabPage14.Enabled = false;
            label41.Visible = false;
            label42.Visible = true;
            button13.Visible = true;
            label42.Visible = false;
            label43.Visible = false;
            radioButton16.Visible = false;
            radioButton17.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            label44.Visible = false;
            button15.Visible = false;
            label45.Visible = false;
            label46.Visible = false;
            button16.Visible = false;
            label47.Visible = false;
            button17.Visible = false;
            label48.Visible = false;
            groupBox4.Visible = false;
            tabPage15.Visible = false;
            tabPage15.Enabled = false;
            button18.Visible = false;
            label56.Visible = false;
            radioButton18.Visible = false;
            radioButton19.Visible = false;
            button19.Visible = false;
            label57.Visible = false;
            button20.Visible = false;
            label58.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            buttonStart.Visible = false;
            label59.Visible = false;
            button25.Visible = false;
            label60.Visible = false;
            label61.Visible = false;
            button26.Visible = false;
            label62.Visible = false;
            button27.Visible = false;
            radioButton20.Visible = false;
            radioButton21.Visible = false;
            label63.Visible = false;
            groupBox5.Visible = false;
            button28.Visible = false;
            tabPage16.Enabled = false;
            tabPage16.Visible = false;
            label72.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            label73.Visible = false;
            button31.Visible = false;
            label74.Visible = false;
            button32.Visible = false;
            label71.Visible = false;
            button30.Visible = false;
            label75.Visible = false;
            button33.Visible = false;
            label76.Visible = false;
            button34.Visible = false;
            button35.Visible = false;
            label77.Visible = false;
            label78.Visible = false;
            button36.Visible = false;
            label79.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            label80.Visible = false;
            button39.Visible = false;
            label81.Visible = false;
            label82.Visible = false;
            button40.Visible = false;
            label83.Visible = false;
            button41.Visible = false;
            label84.Visible = false;
            label85.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            label86.Visible = false;
            label87.Visible = false;
            button44.Visible = false;
            label88.Visible = false;
            button45.Visible = false;
            label89.Visible = false;
            button46.Visible = false;
            radioButton22.Visible = false;
            radioButton23.Visible = false;
            label90.Visible = false;
            button47.Visible = false;
            label91.Visible = false;
            progressBar1.Visible = false;
            label92.Visible = false;
            label93.Visible = false;
            button48.Visible = false;
            label94.Visible = false;
            label95.Visible = false;
            button49.Visible = false;
            label96.Visible = false;
            button50.Visible = false;
            label97.Visible = false;
            button51.Visible = false;
            label98.Visible = false;
            label99.Visible = false;
            button53.Visible = false;
            tabPage17.Visible = false;
            tabPage17.Enabled = false;
            label108.Visible = false;
            label109.Visible = false;
            button52.Visible = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            labelHello1.Visible = false;
            labelHello2.Visible = false;
            labelHello.Visible = true;
            buttonHello.Visible = true;
            buttonHello1.Visible = false;
            buttonSettings.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            trackBar2.Visible = false;
            tabPage12.Visible = false;
            tabPage12.Enabled = false;
            buttonAnswer.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            buttonAnswer2.Visible = false;
            groupBox1.Visible = false;
            label12.Visible = true;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            button2.Visible = false;
            label15.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            label18.Visible = false;
            button6.Visible = false;
            button5.Visible = false;
            label19.Visible = false;
            groupBox2.Visible = false;
            button7.Visible = false;
            tabPage13.Visible = false;
            tabPage13.Enabled = false;
            label12.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            textBox17.Visible = false;
            label30.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            button8.Visible = false;
            label31.Visible = false;
            radioButton12.Visible = false;
            radioButton13.Visible = false;
            button9.Visible = false;
            label32.Visible = false;
            radioButton14.Visible = false;
            radioButton15.Visible = false;
            button10.Visible = false;
            player.Play();
            label33.Visible = false;
            button11.Visible = false;
            groupBox3.Visible = false;
            tabPage12.Visible = false;
            tabPage12.Enabled = false;
            tabPage14.Visible = false;
            tabPage14.Enabled = false;
            label41.Visible = false;
            label42.Visible = true;
            button13.Visible = true;
            label42.Visible = false;
            label43.Visible = false;
            radioButton16.Visible = false;
            radioButton17.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            label44.Visible = false;
            button15.Visible = false;
            label45.Visible = false;
            label46.Visible = false;
            button16.Visible = false;
            label47.Visible = false;
            button17.Visible = false;
            label48.Visible = false;
            groupBox4.Visible = false;
            tabPage15.Visible = false;
            tabPage15.Enabled = false;
            button18.Visible = false;
            label56.Visible = false;
            radioButton18.Visible = false;
            radioButton19.Visible = false;
            button19.Visible = false;
            label57.Visible = false;
            button20.Visible = false;
            label58.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            buttonStart.Visible = false;
            label59.Visible = false;
            button25.Visible = false;
            label60.Visible = false;
            label61.Visible = false;
            button26.Visible = false;
            label62.Visible = false;
            button27.Visible = false;
            radioButton20.Visible = false;
            radioButton21.Visible = false;
            label63.Visible = false;
            groupBox5.Visible = false;
            button28.Visible = false;
            tabPage16.Enabled = false;
            tabPage16.Visible = false;
            label72.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            label73.Visible = false;
            button31.Visible = false;
            label74.Visible = false;
            button32.Visible = false;
            label71.Visible = false;
            button30.Visible = false;
            label75.Visible = false;
            button33.Visible = false;
            label76.Visible = false;
            button34.Visible = false;
            button35.Visible = false;
            label77.Visible = false;
            label78.Visible = false;
            button36.Visible = false;
            label79.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            label80.Visible = false;
            button39.Visible = false;
            label81.Visible = false;
            label82.Visible = false;
            button40.Visible = false;
            label83.Visible = false;
            button41.Visible = false;
            label84.Visible = false;
            label85.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            label86.Visible = false;
            label87.Visible = false;
            button44.Visible = false;
            label88.Visible = false;
            button45.Visible = false;
            label89.Visible = false;
            button46.Visible = false;
            radioButton22.Visible = false;
            radioButton23.Visible = false;
            label90.Visible = false;
            button47.Visible = false;
            label91.Visible = false;
            progressBar1.Visible = false;
            label92.Visible = false;
            label93.Visible = false;
            button48.Visible = false;
            label94.Visible = false;
            label95.Visible = false;
            button49.Visible = false;
            label96.Visible = false;
            button50.Visible = false;
            label97.Visible = false;
            button51.Visible = false;
            label98.Visible = false;
            label99.Visible = false;
            button53.Visible = false;
            tabPage17.Visible = false;
            tabPage17.Enabled = false;
            label108.Visible = false;
            label109.Visible = false;
            button52.Visible = false;
        }
        private void button55_Click(object sender, EventArgs e)
        {
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            labelHello1.Visible = false;
            labelHello2.Visible = false;
            labelHello.Visible = true;
            buttonHello.Visible = true;
            buttonHello1.Visible = false;
            buttonSettings.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            trackBar2.Visible = false;
            tabPage12.Visible = false;
            tabPage12.Enabled = false;
            buttonAnswer.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            buttonAnswer2.Visible = false;
            groupBox1.Visible = false;
            label12.Visible = true;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            button2.Visible = false;
            label15.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            label18.Visible = false;
            button6.Visible = false;
            button5.Visible = false;
            label19.Visible = false;
            groupBox2.Visible = false;
            button7.Visible = false;
            tabPage13.Visible = false;
            tabPage13.Enabled = false;
            label12.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            textBox17.Visible = false;
            label30.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            button8.Visible = false;
            label31.Visible = false;
            radioButton12.Visible = false;
            radioButton13.Visible = false;
            button9.Visible = false;
            label32.Visible = false;
            radioButton14.Visible = false;
            radioButton15.Visible = false;
            button10.Visible = false;
            player.Play();
            label33.Visible = false;
            button11.Visible = false;
            groupBox3.Visible = false;
            tabPage12.Visible = false;
            tabPage12.Enabled = false;
            tabPage14.Visible = false;
            tabPage14.Enabled = false;
            label41.Visible = false;
            label42.Visible = true;
            button13.Visible = true;
            label42.Visible = false;
            label43.Visible = false;
            radioButton16.Visible = false;
            radioButton17.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            label44.Visible = false;
            button15.Visible = false;
            label45.Visible = false;
            label46.Visible = false;
            button16.Visible = false;
            label47.Visible = false;
            button17.Visible = false;
            label48.Visible = false;
            groupBox4.Visible = false;
            tabPage15.Visible = false;
            tabPage15.Enabled = false;
            button18.Visible = false;
            label56.Visible = false;
            radioButton18.Visible = false;
            radioButton19.Visible = false;
            button19.Visible = false;
            label57.Visible = false;
            button20.Visible = false;
            label58.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            buttonStart.Visible = false;
            label59.Visible = false;
            button25.Visible = false;
            label60.Visible = false;
            label61.Visible = false;
            button26.Visible = false;
            label62.Visible = false;
            button27.Visible = false;
            radioButton20.Visible = false;
            radioButton21.Visible = false;
            label63.Visible = false;
            groupBox5.Visible = false;
            button28.Visible = false;
            tabPage16.Enabled = false;
            tabPage16.Visible = false;
            label72.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            label73.Visible = false;
            button31.Visible = false;
            label74.Visible = false;
            button32.Visible = false;
            label71.Visible = false;
            button30.Visible = false;
            label75.Visible = false;
            button33.Visible = false;
            label76.Visible = false;
            button34.Visible = false;
            button35.Visible = false;
            label77.Visible = false;
            label78.Visible = false;
            button36.Visible = false;
            label79.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            label80.Visible = false;
            button39.Visible = false;
            label81.Visible = false;
            label82.Visible = false;
            button40.Visible = false;
            label83.Visible = false;
            button41.Visible = false;
            label84.Visible = false;
            label85.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            label86.Visible = false;
            label87.Visible = false;
            button44.Visible = false;
            label88.Visible = false;
            button45.Visible = false;
            label89.Visible = false;
            button46.Visible = false;
            radioButton22.Visible = false;
            radioButton23.Visible = false;
            label90.Visible = false;
            button47.Visible = false;
            label91.Visible = false;
            progressBar1.Visible = false;
            label92.Visible = false;
            label93.Visible = false;
            button48.Visible = false;
            label94.Visible = false;
            label95.Visible = false;
            button49.Visible = false;
            label96.Visible = false;
            button50.Visible = false;
            label97.Visible = false;
            button51.Visible = false;
            label98.Visible = false;
            label99.Visible = false;
            button53.Visible = false;
            tabPage17.Visible = false;
            tabPage17.Enabled = false;
            label108.Visible = false;
            label109.Visible = false;
            button52.Visible = false;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            labelHello1.Visible = false;
            labelHello2.Visible = false;
            labelHello.Visible = true;
            buttonHello.Visible = true;
            buttonHello1.Visible = false;
            buttonSettings.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            trackBar2.Visible = false;
            tabPage12.Visible = false;
            tabPage12.Enabled = false;
            buttonAnswer.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            buttonAnswer2.Visible = false;
            groupBox1.Visible = false;
            label12.Visible = true;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            button2.Visible = false;
            label15.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            label18.Visible = false;
            button6.Visible = false;
            button5.Visible = false;
            label19.Visible = false;
            groupBox2.Visible = false;
            button7.Visible = false;
            tabPage13.Visible = false;
            tabPage13.Enabled = false;
            label12.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            textBox17.Visible = false;
            label30.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            button8.Visible = false;
            label31.Visible = false;
            radioButton12.Visible = false;
            radioButton13.Visible = false;
            button9.Visible = false;
            label32.Visible = false;
            radioButton14.Visible = false;
            radioButton15.Visible = false;
            button10.Visible = false;
            player.Play();
            label33.Visible = false;
            button11.Visible = false;
            groupBox3.Visible = false;
            tabPage12.Visible = false;
            tabPage12.Enabled = false;
            tabPage14.Visible = false;
            tabPage14.Enabled = false;
            label41.Visible = false;
            label42.Visible = true;
            button13.Visible = true;
            label42.Visible = false;
            label43.Visible = false;
            radioButton16.Visible = false;
            radioButton17.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            label44.Visible = false;
            button15.Visible = false;
            label45.Visible = false;
            label46.Visible = false;
            button16.Visible = false;
            label47.Visible = false;
            button17.Visible = false;
            label48.Visible = false;
            groupBox4.Visible = false;
            tabPage15.Visible = false;
            tabPage15.Enabled = false;
            button18.Visible = false;
            label56.Visible = false;
            radioButton18.Visible = false;
            radioButton19.Visible = false;
            button19.Visible = false;
            label57.Visible = false;
            button20.Visible = false;
            label58.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            buttonStart.Visible = false;
            label59.Visible = false;
            button25.Visible = false;
            label60.Visible = false;
            label61.Visible = false;
            button26.Visible = false;
            label62.Visible = false;
            button27.Visible = false;
            radioButton20.Visible = false;
            radioButton21.Visible = false;
            label63.Visible = false;
            groupBox5.Visible = false;
            button28.Visible = false;
            tabPage16.Enabled = false;
            tabPage16.Visible = false;
            label72.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            label73.Visible = false;
            button31.Visible = false;
            label74.Visible = false;
            button32.Visible = false;
            label71.Visible = false;
            button30.Visible = false;
            label75.Visible = false;
            button33.Visible = false;
            label76.Visible = false;
            button34.Visible = false;
            button35.Visible = false;
            label77.Visible = false;
            label78.Visible = false;
            button36.Visible = false;
            label79.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            label80.Visible = false;
            button39.Visible = false;
            label81.Visible = false;
            label82.Visible = false;
            button40.Visible = false;
            label83.Visible = false;
            button41.Visible = false;
            label84.Visible = false;
            label85.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            label86.Visible = false;
            label87.Visible = false;
            button44.Visible = false;
            label88.Visible = false;
            button45.Visible = false;
            label89.Visible = false;
            button46.Visible = false;
            radioButton22.Visible = false;
            radioButton23.Visible = false;
            label90.Visible = false;
            button47.Visible = false;
            label91.Visible = false;
            progressBar1.Visible = false;
            label92.Visible = false;
            label93.Visible = false;
            button48.Visible = false;
            label94.Visible = false;
            label95.Visible = false;
            button49.Visible = false;
            label96.Visible = false;
            button50.Visible = false;
            label97.Visible = false;
            button51.Visible = false;
            label98.Visible = false;
            label99.Visible = false;
            button53.Visible = false;
            tabPage17.Visible = false;
            tabPage17.Enabled = false;
            label108.Visible = false;
            label109.Visible = false;
            button52.Visible = false;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            labelHello1.Visible = false;
            labelHello2.Visible = false;
            labelHello.Visible = true;
            buttonHello.Visible = true;
            buttonHello1.Visible = false;
            buttonSettings.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            trackBar2.Visible = false;
            tabPage12.Visible = false;
            tabPage12.Enabled = false;
            buttonAnswer.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            buttonAnswer2.Visible = false;
            groupBox1.Visible = false;
            label12.Visible = true;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            button2.Visible = false;
            label15.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            label18.Visible = false;
            button6.Visible = false;
            button5.Visible = false;
            label19.Visible = false;
            groupBox2.Visible = false;
            button7.Visible = false;
            tabPage13.Visible = false;
            tabPage13.Enabled = false;
            label12.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            textBox17.Visible = false;
            label30.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            button8.Visible = false;
            label31.Visible = false;
            radioButton12.Visible = false;
            radioButton13.Visible = false;
            button9.Visible = false;
            label32.Visible = false;
            radioButton14.Visible = false;
            radioButton15.Visible = false;
            button10.Visible = false;
            player.Play();
            label33.Visible = false;
            button11.Visible = false;
            groupBox3.Visible = false;
            tabPage12.Visible = false;
            tabPage12.Enabled = false;
            tabPage14.Visible = false;
            tabPage14.Enabled = false;
            label41.Visible = false;
            label42.Visible = true;
            button13.Visible = true;
            label42.Visible = false;
            label43.Visible = false;
            radioButton16.Visible = false;
            radioButton17.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            label44.Visible = false;
            button15.Visible = false;
            label45.Visible = false;
            label46.Visible = false;
            button16.Visible = false;
            label47.Visible = false;
            button17.Visible = false;
            label48.Visible = false;
            groupBox4.Visible = false;
            tabPage15.Visible = false;
            tabPage15.Enabled = false;
            button18.Visible = false;
            label56.Visible = false;
            radioButton18.Visible = false;
            radioButton19.Visible = false;
            button19.Visible = false;
            label57.Visible = false;
            button20.Visible = false;
            label58.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            buttonStart.Visible = false;
            label59.Visible = false;
            button25.Visible = false;
            label60.Visible = false;
            label61.Visible = false;
            button26.Visible = false;
            label62.Visible = false;
            button27.Visible = false;
            radioButton20.Visible = false;
            radioButton21.Visible = false;
            label63.Visible = false;
            groupBox5.Visible = false;
            button28.Visible = false;
            tabPage16.Enabled = false;
            tabPage16.Visible = false;
            label72.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            label73.Visible = false;
            button31.Visible = false;
            label74.Visible = false;
            button32.Visible = false;
            label71.Visible = false;
            button30.Visible = false;
            label75.Visible = false;
            button33.Visible = false;
            label76.Visible = false;
            button34.Visible = false;
            button35.Visible = false;
            label77.Visible = false;
            label78.Visible = false;
            button36.Visible = false;
            label79.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            label80.Visible = false;
            button39.Visible = false;
            label81.Visible = false;
            label82.Visible = false;
            button40.Visible = false;
            label83.Visible = false;
            button41.Visible = false;
            label84.Visible = false;
            label85.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            label86.Visible = false;
            label87.Visible = false;
            button44.Visible = false;
            label88.Visible = false;
            button45.Visible = false;
            label89.Visible = false;
            button46.Visible = false;
            radioButton22.Visible = false;
            radioButton23.Visible = false;
            label90.Visible = false;
            button47.Visible = false;
            label91.Visible = false;
            progressBar1.Visible = false;
            label92.Visible = false;
            label93.Visible = false;
            button48.Visible = false;
            label94.Visible = false;
            label95.Visible = false;
            button49.Visible = false;
            label96.Visible = false;
            button50.Visible = false;
            label97.Visible = false;
            button51.Visible = false;
            label98.Visible = false;
            label99.Visible = false;
            button53.Visible = false;
            tabPage17.Visible = false;
            tabPage17.Enabled = false;
            label108.Visible = false;
            label109.Visible = false;
            button52.Visible = false;
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            if(radioButton10.Checked)
            {
                strong++;
                brave++;
                clever++;
                clever++;
                MessageBox.Show("Спасибо " + name + "!\nВот твои деньги\nТы проработал 2 дня, держи свою награду!");
                days = days - 2;
                textBox17.Text = days.ToString();
                radioButton10.Visible = false;
                radioButton11.Visible = false;
                button8.Visible = false;
                label30.Visible = false;
                label31.Visible = true;
                radioButton12.Visible = true;
                radioButton13.Visible = true;
                button9.Visible = true;
            }
            else if(radioButton11.Checked)
            {
                strong++;
                strong++;
                strong++;
                famous++;
                famous++;
                MessageBox.Show("Спасибо " + name + "!\nТы нам очень помог! Обращайся, когда нужна будет помощь!");
                days = days - 4;
                textBox17.Text = days.ToString();
                radioButton10.Visible = false;
                radioButton11.Visible = false;
                button8.Visible = false;
                label30.Visible = false;
                label31.Visible = true;
                radioButton12.Visible = true;
                radioButton13.Visible = true;
                button9.Visible = true;

            }
            else
            {
                clever--;
                nosy--;
                strong--;
                MessageBox.Show("Вы решили пропустить!");
                days = days - 1;
                textBox17.Text = days.ToString();
                radioButton10.Visible = false;
                radioButton11.Visible = false;
                button8.Visible = false;
                label30.Visible = false;
                label31.Visible = true;
                radioButton12.Visible = true;
                radioButton13.Visible = true;
                button9.Visible = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(radioButton12.Checked)
            {
                clever++;
                clever++;
                famous++;
                lucky++;
                lucky++;
                MessageBox.Show("У тебя получилось неплохо импровизировать в свои " + years + ", " + name + "!");
                days = days - 3;
                textBox17.Text = days.ToString();
                label31.Visible = false;
                radioButton12.Visible = false;
                radioButton13.Visible = false;
                button9.Visible = false;
                label32.Visible = true;
                radioButton14.Visible = true;
                radioButton15.Visible = true;
                button10.Visible = true;
            }
            else if(radioButton13.Checked)
            {
                clever++;
                clever++;
                famous++;
                brave++;
                strong++;
                nosy++;
                MessageBox.Show("Зрители восхищались тобой!");
                days = days - 4;
                textBox17.Text = days.ToString();
                label31.Visible = false;
                radioButton12.Visible = false;
                radioButton13.Visible = false;
                button9.Visible = false;
                label32.Visible = true;
                radioButton14.Visible = true;
                radioButton15.Visible = true;
                button10.Visible = true;
            }
            else
            {
                clever--;
                famous--;
                brave--;
                strong--;
                nosy--;
                MessageBox.Show("Вы решили пропустить!");
                days = days - 1;
                textBox17.Text = days.ToString();
                label31.Visible = false;
                radioButton12.Visible = false;
                radioButton13.Visible = false;
                button9.Visible = false;
                label32.Visible = true;
                radioButton14.Visible = true;
                radioButton15.Visible = true;
                button10.Visible = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (radioButton14.Checked)
            {
                famous++;
                clever++;
                brave++;
                strong++;
                MessageBox.Show("Несмотря на страх умереть, вы с лёгкостью доставили письмо!\nИ, похоже, сделали очень правильный выбор,\nтак как вас вызвали в главный замок!\nА так бы не смогли стать таким важным среди простолюдинов!");
                button10.Visible = false;
                radioButton14.Visible = false;
                radioButton15.Visible = false;
                label32.Visible = false;
                textBox17.Visible = false;
                label33.Visible = true;
                button11.Visible = true;
                groupBox3.Visible = true;
                label29.Visible = false;
                if (clever >= 5 && level == 1 || strong >= 5 && level == 1 || brave >= 5 && level == 1 || famous >= 5 && level == 1)
                {
                    level++;
                }
                if (clever >= 10 && level <= 2 || strong >= 10 && level <= 2 || brave >= 10 && level <= 2 || famous >= 10 && level <= 2)
                {
                    level++;
                }
                if (clever >= 15 && level <= 3 || strong >= 15 && level <= 3 || brave >= 15 && level <= 3 || famous >= 15 && level <= 3)
                {
                    level++;
                }
                if (clever >= 20 && level <= 4 || strong >= 20 && level <= 4 || brave >= 20 && level <= 4 || famous >= 20 && level <= 4)
                {
                    level++;
                }
                textBox24.Text = strong.ToString();
                textBox23.Text = clever.ToString();
                textBox22.Text = lucky.ToString();
                textBox21.Text = nosy.ToString();
                textBox20.Text = brave.ToString();
                textBox19.Text = famous.ToString();
                textBox18.Text = level.ToString();
                textBox18.Enabled = false;
                textBox19.Enabled = false;
                textBox20.Enabled = false;
                textBox21.Enabled = false;
                textBox22.Enabled = false;
                textBox23.Enabled = false;
                textBox24.Enabled = false;

            }
            else if(radioButton15.Checked)
            {
                famous--;
                clever--;
                brave--;
                MessageBox.Show("Хмм, похоже вы поступили некорректно!\nЛюди разочарованы в вас! Да ещё и последние дни насмарку!\nВас вызывают в замок!");
                button10.Visible = false;
                radioButton14.Visible = false;
                radioButton15.Visible = false;
                label32.Visible = false;
                textBox17.Visible = false;
                label33.Visible = true;
                button11.Visible = true;
                groupBox3.Visible = true;
                label29.Visible = false;
                if (clever >= 5 && level == 1 || strong >= 5 && level == 1 || brave >= 5 && level == 1 || famous >= 5 && level == 1)
                {
                    level++;
                }
                if (clever >= 10 && level <= 2 || strong >= 10 && level <= 2 || brave >= 10 && level <= 2 || famous >= 10 && level <= 2)
                {
                    level++;
                }
                if (clever >= 15 && level <= 3 || strong >= 15 && level <= 3 || brave >= 15 && level <= 3 || famous >= 15 && level <= 3)
                {
                    level++;
                }
                if (clever >= 20 && level <= 4 || strong >= 20 && level <= 4 || brave >= 20 && level <= 4 || famous >= 20 && level <= 4)
                {
                    level++;
                }
                textBox24.Text = strong.ToString();
                textBox23.Text = clever.ToString();
                textBox22.Text = lucky.ToString();
                textBox21.Text = nosy.ToString();
                textBox20.Text = brave.ToString();
                textBox19.Text = famous.ToString();
                textBox18.Text = level.ToString();
                textBox18.Enabled = false;
                textBox19.Enabled = false;
                textBox20.Enabled = false;
                textBox21.Enabled = false;
                textBox22.Enabled = false;
                textBox23.Enabled = false;
                textBox24.Enabled = false;

            }
            else
            {
                label29.Visible = false;
                clever--;
                famous--;
                brave--;
                MessageBox.Show("Вы решили пропустить!");
                MessageBox.Show("Хмм, похоже вы поступили некорректно!\nЛюди разочарованы в вас! Да ещё и последние дни насмарку!\nВас вызывают в замок!");
                button10.Visible = false;
                radioButton14.Visible = false;
                radioButton15.Visible = false;
                label32.Visible = false;
                textBox17.Visible = false;
                label33.Visible = true;
                button11.Visible = true;
                groupBox3.Visible = true;
                if (clever >= 5 && level == 1 || strong >= 5 && level == 1 || brave >= 5 && level == 1 || famous >= 5 && level == 1)
                {
                    level++;
                }
                if (clever >= 10 && level <= 2 || strong >= 10 && level <= 2 || brave >= 10 && level <= 2 || famous >= 10 && level <= 2)
                {
                    level++;
                }
                if (clever >= 15 && level <= 3 || strong >= 15 && level <= 3 || brave >= 15 && level <= 3 || famous >= 15 && level <= 3)
                {
                    level++;
                }
                if (clever >= 20 && level <= 4 || strong >= 20 && level <= 4 || brave >= 20 && level <= 4 || famous >= 20 && level <= 4)
                {
                    level++;
                }
                textBox24.Text = strong.ToString();
                textBox23.Text = clever.ToString();
                textBox22.Text = lucky.ToString();
                textBox21.Text = nosy.ToString();
                textBox20.Text = brave.ToString();
                textBox19.Text = famous.ToString();
                textBox18.Text = level.ToString();
                textBox18.Enabled = false;
                textBox19.Enabled = false;
                textBox20.Enabled = false;
                textBox21.Enabled = false;
                textBox22.Enabled = false;
                textBox23.Enabled = false;
                textBox24.Enabled = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabPage13.Enabled = false;
            tabPage14.Visible = true;
            tabPage14.Enabled = true;
            label41.Visible = true;
            button12.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Visible = false;
            label41.Visible = false;
            label42.Visible = true;
            button13.Visible = true;
            player2.Stop();
            player3.Play();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            button13.Visible = false;
            label42.Visible = false;
            label43.Visible = true;
            radioButton16.Visible = true;
            radioButton17.Visible = true;
            button14.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked)
            {
                if (level >= 2 || strong >= 5 || famous >= 4 || lucky >= 4)//нападение бандитов
                {
                    b++;
                    strong--;
                    famous++;
                    lucky++;
                    label43.Visible = false;
                    radioButton16.Visible = false;
                    radioButton17.Visible = false;
                    button14.Visible = false;
                }
                else
                {
                    c++;
                    famous--;
                    strong--;
                    lucky--;
                    nosy--;
                    label43.Visible = false;
                    radioButton16.Visible = false;
                    radioButton17.Visible = false;
                    button14.Visible = false;
                    end++;
                }
            }
            else if (radioButton17.Checked)
            {
                if (level >= 2 || strong >= 5 || brave >= 5 || famous >= 4)
                {
                    a++;
                    strong++;
                    brave++;
                    famous++;
                    nosy--;

                    label43.Visible = false;
                    radioButton16.Visible = false;
                    radioButton17.Visible = false;
                    button14.Visible = false;
                }
                else
                {
                    c++;
                    famous--;
                    strong--;
                    lucky--;
                    nosy--;
                    label43.Visible = false;
                    radioButton16.Visible = false;
                    radioButton17.Visible = false;
                    button14.Visible = false;
                    end++;
                }
            }
            else
            {
                c++;
                famous--;
                strong--;
                lucky--;
                nosy--;
                clever--;
                MessageBox.Show("Вы решили стать на месте и не шевелиться!");
                label43.Visible = false;
                radioButton16.Visible = false;
                radioButton17.Visible = false;
                button14.Visible = false;
                end++;
            }
            if(a!=0)
            {
                label44.Visible = true;
                button15.Visible = true;
            }
            else if (b != 0)
            {
                label45.Visible = true;
                button15.Visible = true;

            }
            else
            {
                label46.Visible = true;
                button16.Visible = true;
                
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(a!=0)
            {
                label44.Visible = false;
                button15.Visible = false;
                label47.Visible = true;
                button17.Visible = true;
            }
            else
            {
                label45.Visible = false;
                button15.Visible = false;
                label47.Visible = true;
                button17.Visible = true;

            }
            label47.Visible = true;
        }


        private void button16_Click(object sender, EventArgs e)
        {
            player3.Stop();
            player4.Play();
            tabPage14.Enabled = false;
            label108.Visible = true;
            tabPage17.Enabled = true;
            tabPage17.Visible = true;


        }

        private void button17_Click(object sender, EventArgs e)
        {
            label47.Visible = false;
            button17.Visible = false;
            label48.Visible = true;
            groupBox4.Visible = true;
            if (clever >= 5 && level == 1 || strong >= 5 && level == 1 || brave >= 5 && level == 1 || famous >= 5 && level == 1)
            {
                level++;
            }
            if (clever >= 10 && level <= 2 || strong >= 10 && level <= 2 || brave >= 10 && level <= 2 || famous >= 10 && level <= 2)
            {
                level++;
            }
            if (clever >= 15 && level <= 3 || strong >= 15 && level <= 3 || brave >= 15 && level <= 3 || famous >= 15 && level <= 3)
            {
                level++;
            }
            if (clever >= 20 && level <= 4 || strong >= 20 && level <= 4 || brave >= 20 && level <= 4 || famous >= 20 && level <= 4)
            {
                level++;
            }
            textBox31.Text = strong.ToString();
            textBox30.Text = clever.ToString();
            textBox29.Text = lucky.ToString();
            textBox28.Text = nosy.ToString();
            textBox27.Text = brave.ToString();
            textBox26.Text = famous.ToString();
            textBox25.Text = level.ToString();
            textBox25.Enabled = false;
            textBox26.Enabled = false;
            textBox27.Enabled = false;
            textBox28.Enabled = false;
            textBox29.Enabled = false;
            textBox30.Enabled = false;
            textBox31.Enabled = false;
            button18.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            c = 0;
            tabPage14.Enabled = false;
            label56.Visible = true;
            radioButton18.Visible = true;
            radioButton19.Visible = true;
            button19.Visible = true;
            tabPage15.Visible = true;
            tabPage15.Enabled=true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(radioButton18.Checked)
            {
                clever++;
                famous++;
                nosy++;
              
                a++;
                label57.Visible = true;
                label56.Visible = false;
                radioButton18.Visible = false;
                radioButton19.Visible = false;
                button19.Visible = false;
                button20.Visible = true;
            }
            else if(radioButton19.Checked)
            {
                strong++;
                brave++;
                lucky++;
                b++;
                label58.Visible = true;
                label56.Visible = false;
                radioButton18.Visible = false;
                radioButton19.Visible = false;
                button19.Visible = false;
                button20.Visible = true;
            }
            else
            {
                clever++;
                famous++;
                nosy++;
                a++;
                MessageBox.Show("Вы молчите, всем своим видом показывая, что вы готовы слушать");
                label57.Visible = true;
                label56.Visible = false;
                radioButton18.Visible = false;
                radioButton19.Visible = false;
                button19.Visible = false;
                button20.Visible = true;
            }
        }

        private void tabPage13_Click(object sender, EventArgs e)
        {

        }

        private void tabPage11_Click(object sender, EventArgs e)
        {
            
        }

        private void button20_Click(object sender, EventArgs e)
        {

            if(a!=0)
            {
                label57.Visible = false;
                button20.Visible = false;
                label59.Visible = true;
                button25.Visible = true;
            }
            else
            {
                label58.Visible = false;
                button20.Visible = false;
                label60.Visible = true;
                button25.Visible = true;
            }
        }

        private void label58_Click(object sender, EventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            if(a!=0)
            {
                label59.Visible = false;
                button25.Visible = false;
                label61.Visible = true;
                button26.Visible = true;
            }
            else
            {
                label60.Visible = false;
                button25.Visible = false;
                label61.Visible = true;
                button26.Visible = true;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            label61.Visible = false;
            button26.Visible = false;
            label62.Visible = true;
            button27.Visible = true;
            radioButton20.Visible = true;
            radioButton21.Visible = true;
        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            if(radioButton20.Checked)
            {
                famous++;
                clever++;
                brave++;
                strong++;
                lucky--;

            }
            else if(radioButton21.Checked)
            {
                clever--;
                nosy--;
                famous++;
                strong++;

            }
            else
            {
                clever--;
                nosy--;
                lucky--;
                clever--;
               
                MessageBox.Show("Эээээ, вы ещё не готовы для такого выбора");
            }
            label62.Visible = false;
            button27.Visible = false;
            radioButton20.Visible = false;
            radioButton21.Visible = false;
            label63.Visible = true;
            groupBox5.Visible = true;
            button28.Visible = true;
            if (clever >= 5 && level == 1 || strong >= 5 && level == 1 || brave >= 5 && level == 1 || famous >= 5 && level == 1)
            {
                level++;
            }
            if (clever >= 10 && level <= 2 || strong >= 10 && level <= 2 || brave >= 10 && level <= 2 || famous >= 10 && level <= 2)
            {
                level++;
            }
            if (clever >= 15 && level <= 3 || strong >= 15 && level <= 3 || brave >= 15 && level <= 3 || famous >= 15 && level <= 3)
            {
                level++;
            }
            if (clever >= 20 && level <= 4 || strong >= 20 && level <= 4 || brave >= 20 && level <= 4 || famous >= 20 && level <= 4)
            {
                level++;
            }
            textBox38.Text = strong.ToString();
            textBox37.Text = clever.ToString();
            textBox36.Text = lucky.ToString();
            textBox35.Text = nosy.ToString();
            textBox34.Text = brave.ToString();
            textBox33.Text = famous.ToString();
            textBox32.Text = level.ToString();
            textBox32.Enabled = false;
            textBox33.Enabled = false;
            textBox34.Enabled = false;
            textBox35.Enabled = false;
            textBox36.Enabled = false;
            textBox37.Enabled = false;
            textBox38.Enabled = false;

        }

        private void button28_Click(object sender, EventArgs e)
        {
            tabPage15.Enabled = false;
            tabPage16.Visible = true;
            tabPage16.Enabled = true;
            label71.Visible = true;
            button29.Visible = true;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            label71.Visible = false;
            button29.Visible = false;
            label72.Visible = true;
            button30.Visible = true;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            label72.Visible = false;
            button30.Visible = false;
            label73.Visible = true;
            button31.Visible = true;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            label73.Visible = false;
            button31.Visible = false;
            label74.Visible = true;
            button32.Visible = true;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            label74.Visible = false;
            button32.Visible = false;
            label75.Visible = true;
            button33.Visible = true;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            label75.Visible = false;
            button33.Visible = false;
            label76.Visible = true;
            button34.Visible = true;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            label76.Visible = false;
            button34.Visible = false;
            label77.Visible = true;
            button35.Visible = true;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            label77.Visible = false;
            button35.Visible = false;
            label78.Visible = true;
            button36.Visible = true;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            label78.Visible = false;
            button36.Visible = false;
            label79.Visible = true;
            button37.Visible = true;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            label79.Visible = false;
            button37.Visible = false;
            label80.Visible = true;
            button38.Visible = true;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            label80.Visible = false;
            button38.Visible = false;
            label81.Visible = true;
            button39.Visible = true;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            label81.Visible = false;
            button39.Visible = false;
            label82.Visible = true;
            button40.Visible = true;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            c = 0;
            label82.Visible = false;
            button40.Visible = false;
            if(famous>=9||strong>=8||brave>=8||lucky>=6)//важный выбор 02
            {
                player3.Stop();
                player6.Play();
                famous++;
                brave++;
                strong++;
                a++;
                label83.Visible = true;
                button41.Visible = true;
            }
            else
            {
                player3.Stop();
                player5.Play();
                famous++;
                b++;
                end++;
                end++;
                label84.Visible = true;
                button41.Visible = true;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {

            if(a!=0)
            {

                label83.Visible = false;
                button41.Visible = false;
                label85.Visible = true;
                button42.Visible = true;
            }
            else
            {
                tabPage16.Enabled = false;
                label108.Visible = true;
                tabPage17.Enabled = true;
                tabPage17.Visible = true;
            }
            a =0;
            b = 0;
            c = 0;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            label85.Visible = false;
            button42.Visible = false;
            label86.Visible = true;
            button43.Visible = true;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            label86.Visible = false;
            button43.Visible = false;
            label87.Visible = true;
            button44.Visible = true;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            label87.Visible = false;
            button44.Visible = false;
            label88.Visible = true;
            button45.Visible = true;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            label88.Visible=false;
            button45.Visible = false;
            label89.Visible = true;
            button46.Visible = true;
            radioButton22.Visible = true;
            radioButton23.Visible = true;
        }

        private void button46_Click(object sender, EventArgs e)
        {


            a = 0;
            b = 0;
            c = 0;
            if(radioButton22.Checked)
            {
                clever++;
                strong++;
                brave++;
                nosy++;
                famous++;
                lucky++;
                a++;
                label90.Visible = true;
                button47.Visible = true;
                progressBar1.Visible = true;
                progressBar1.Value = life;
                label92.Visible = true;
            }
            else if (radioButton23.Checked)
            {
                player6.Stop();
                player4.Play();
                brave--;
                famous--;
                clever--;
                b++;
                label91.Visible = true;
                button47.Visible = true;
            }
            else
            {
                player6.Stop();
                player4.Play();
                brave--;
                famous--;
                clever--;
                MessageBox.Show("Из-за нехватки желания, а может быть и смелости, вы решаете остаться на месте, "+name);
                b++;
                label91.Visible = true;
                button47.Visible = true;
            }
            label89.Visible = false;
            button46.Visible = false;
            radioButton22.Visible = false;
            radioButton23.Visible = false;

        }

        private void button47_Click(object sender, EventArgs e)//после главного выбора: разветвления
        {
            if(a!=0)
            {
                label90.Visible = false;
                button47.Visible = false;
                label93.Visible = true;
                button48.Visible = true;
                hit = hit1.Next();
                hit = hit % (30 - 20) + 20;
                life = life - hit;
                progressBar1.Value =life;
            }
            else
            {
                label91.Visible = false;
                button47.Visible = false;
                label94.Visible = true;
                button48.Visible = true;
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if(a!=0)
            {
                label93.Visible = false;
                button48.Visible = false;
                hit = hit1.Next();
                hit = hit % (30-15) + 15;
                life = life - hit;
                progressBar1.Value = life;
                label95.Visible = true;
                button49.Visible = true;

            }
            else
            {
                end++;
                end++;
                end++;
                label108.Visible = true;
                tabPage17.Enabled = true;
                tabPage17.Visible = true;
                tabPage16.Enabled = false;
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            label95.Visible = false;
            button49.Visible = false;
            hit = hit1.Next();
            hit = hit % (32 - 15) + 15;
            life = life - hit;
            progressBar1.Value = life;
            label96.Visible = true;
            button50.Visible = true;
            hit = hit1.Next();
            hit = hit % (32 - 17)+17;
            life = life - hit;
            a = 0;
            b = 0;
            c = 0;
        }

        private void button50_Click(object sender, EventArgs e)
        {

            if(life>0)
            {
                player6.Stop();
                player.Play();
                a++;

                progressBar1.Visible = false;
                label92.Visible = false;
                strong++;
                lucky++;
                label96.Visible = false;
                button50.Visible = false;
                label97.Visible = true;
                button51.Visible = true;

            }
            else
            {
                b++;
                progressBar1.Visible = false;
                label92.Visible = false;
                strong--;
                famous--;
                label96.Visible = false;
                button50.Visible = false;
                label98.Visible = true;
                button51.Visible = true;
                end++;
                end++;
                end++;
                end++;

            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if(a!=0)
            {
                label97.Visible = false;
                label109.Visible = true;
                tabPage17.Enabled = true;
                tabPage17.Visible = true;
                label99.Visible = true;
                button51.Visible = false;
            }
            else
            {
                player6.Stop();
                player5.Play();
                tabPage16.Enabled = false;
                label108.Visible = true;
                tabPage17.Enabled = true;
                tabPage17.Visible = true;
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {

            button51.Visible = false;
            label109.Visible = true;
            tabPage17.Enabled = true;
            tabPage17.Visible = true;
            label99.Visible = false;
            if (clever >= 5 && level == 1 || strong >= 5 && level == 1 || brave >= 5 && level == 1 || famous >= 5 && level == 1)
            {
                level++;
            }
            if (clever >= 10 && level <= 2 || strong >= 10 && level <= 2 || brave >= 10 && level <= 2 || famous >= 10 && level <= 2)
            {
                level++;
            }
            if (clever >= 15 && level <= 3 || strong >= 15 && level <= 3 || brave >= 15 && level <= 3 || famous >= 15 && level <= 3)
            {
                level++;
            }
            if (clever >= 20 && level <= 4 || strong >= 20 && level <= 4 || brave >= 20 && level <= 4 || famous >= 20 && level <= 4)
            {
                level++;
            }
        }

        private void button53_Click(object sender, EventArgs e)//конец
        {
            tabPage16.Enabled = false;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            Application.Exit();//выход
        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label99_Click(object sender, EventArgs e)
        {

        }

        private void button52_Click_1(object sender, EventArgs e)
        {
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            labelHello1.Visible = false;
            labelHello2.Visible = false;
            labelHello.Visible = true;
            buttonHello.Visible = true;
            buttonHello1.Visible = false;
            buttonSettings.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            trackBar2.Visible = false;
            tabPage12.Visible = false;
            tabPage12.Enabled = false;
            buttonAnswer.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            buttonAnswer2.Visible = false;
            groupBox1.Visible = false;
            label12.Visible = true;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            button2.Visible = false;
            label15.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            label18.Visible = false;
            button6.Visible = false;
            button5.Visible = false;
            label19.Visible = false;
            groupBox2.Visible = false;
            button7.Visible = false;
            tabPage13.Visible = false;
            tabPage13.Enabled = false;
            label12.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            textBox17.Visible = false;
            label30.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            button8.Visible = false;
            label31.Visible = false;
            radioButton12.Visible = false;
            radioButton13.Visible = false;
            button9.Visible = false;
            label32.Visible = false;
            radioButton14.Visible = false;
            radioButton15.Visible = false;
            button10.Visible = false;
            player.Play();
            label33.Visible = false;
            button11.Visible = false;
            groupBox3.Visible = false;
            tabPage12.Visible = false;
            tabPage12.Enabled = false;
            tabPage14.Visible = false;
            tabPage14.Enabled = false;
            label41.Visible = false;
            label42.Visible = true;
            button13.Visible = true;
            label42.Visible = false;
            label43.Visible = false;
            radioButton16.Visible = false;
            radioButton17.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            label44.Visible = false;
            button15.Visible = false;
            label45.Visible = false;
            label46.Visible = false;
            button16.Visible = false;
            label47.Visible = false;
            button17.Visible = false;
            label48.Visible = false;
            groupBox4.Visible = false;
            tabPage15.Visible = false;
            tabPage15.Enabled = false;
            button18.Visible = false;
            label56.Visible = false;
            radioButton18.Visible = false;
            radioButton19.Visible = false;
            button19.Visible = false;
            label57.Visible = false;
            button20.Visible = false;
            label58.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            buttonStart.Visible = false;
            label59.Visible = false;
            button25.Visible = false;
            label60.Visible = false;
            label61.Visible = false;
            button26.Visible = false;
            label62.Visible = false;
            button27.Visible = false;
            radioButton20.Visible = false;
            radioButton21.Visible = false;
            label63.Visible = false;
            groupBox5.Visible = false;
            button28.Visible = false;
            tabPage16.Enabled = false;
            tabPage16.Visible = false;
            label72.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            label73.Visible = false;
            button31.Visible = false;
            label74.Visible = false;
            button32.Visible = false;
            label71.Visible = false;
            button30.Visible = false;
            label75.Visible = false;
            button33.Visible = false;
            label76.Visible = false;
            button34.Visible = false;
            button35.Visible = false;
            label77.Visible = false;
            label78.Visible = false;
            button36.Visible = false;
            label79.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            label80.Visible = false;
            button39.Visible = false;
            label81.Visible = false;
            label82.Visible = false;
            button40.Visible = false;
            label83.Visible = false;
            button41.Visible = false;
            label84.Visible = false;
            label85.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            label86.Visible = false;
            label87.Visible = false;
            button44.Visible = false;
            label88.Visible = false;
            button45.Visible = false;
            label89.Visible = false;
            button46.Visible = false;
            radioButton22.Visible = false;
            radioButton23.Visible = false;
            label90.Visible = false;
            button47.Visible = false;
            label91.Visible = false;
            progressBar1.Visible = false;
            label92.Visible = false;
            label93.Visible = false;
            button48.Visible = false;
            label94.Visible = false;
            label95.Visible = false;
            button49.Visible = false;
            label96.Visible = false;
            button50.Visible = false;
            label97.Visible = false;
            button51.Visible = false;
            label98.Visible = false;
            label99.Visible = false;
            button53.Visible = false;
            tabPage17.Visible = false;
            tabPage17.Enabled = false;
            label108.Visible = false;
            label109.Visible = false;
            button52.Visible = false;
        }
    }
}
