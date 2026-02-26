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


    public partial class Form8 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player3 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player4 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player5 = new System.Media.SoundPlayer();





        int EHP = 100;
        int HP = 100;
        WeakPirate wp = new WeakPirate();
        MediumPirate mp = new MediumPirate();
        StrongPirate sp = new StrongPirate();
        Random r1 = new Random();
        int a;
        Random Go = new Random();
        int Go1;
        int YourCartridge = DataStorage.Cartridge;
        int YourBandage = DataStorage.Bandage;
        Random AmountOfSkipDamage = new Random();
        int AmountOfSkipDamage1;
        public Form8()
        {
            InitializeComponent();
            player.SoundLocation = @"Cartridge.wav";
            player1.SoundLocation = @"Bandage.wav";
            player2.SoundLocation = @"Sword.wav";
            player3.SoundLocation = @"Victory.wav";
            player4.SoundLocation = @"Fail.wav";
            player5.SoundLocation = @"Drink.wav";




            

        }

        private void TheEventLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Image.FromFile(DataStorage.EnemyModel);
            pictureBox1.BackgroundImage=Image.FromFile(DataStorage.PlayerModel);
            //if (DataStorage.TypeOfPirate == "Weak Pirate")
            //{
            //    EnemyCartridge = wp.Cartridge;

            //}
            //else if (DataStorage.TypeOfPirate == "Medium Pirate")
            //{

            //    EnemyCartridge = mp.Cartridge;

            //}
            //else if (DataStorage.TypeOfPirate == "Strong Pirate")
            //{
            //    EnemyCartridge = sp.Cartridge;

            //}
            label3.Text = DataStorage.EnemyName;
            label2.Text = DataStorage.Name;

            wp.HP = EHP;
            mp.HP = EHP;
            sp.HP = EHP;
            progressBar1.Value = 100;
            progressBar2.Value = 100;
            if(DataStorage.TypeOfPirate=="Weak Pirate")
            {
                TheEventLog.Items.Add("Enemy Weak Pirate was successfully created!");
                TheEventLog.Items.Add(wp.GetInfo());

            }
            else if(DataStorage.TypeOfPirate=="Medium Pirate")
            {
                
                TheEventLog.Items.Add("Enemy Medium Pirate was successfully created!");
                TheEventLog.Items.Add(mp.GetInfo());

            }
            else if(DataStorage.TypeOfPirate=="Strong Pirate")
            {
                
                TheEventLog.Items.Add("Enemy Strong Pirate was successfully created!");
                TheEventLog.Items.Add(sp.GetInfo());
            }





            TheEventLog.Items.Add("The Battle has started!");
            MessageBox.Show("Your turn!");
            button1.Enabled = false;
            button2.Enabled = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            player2.Play();
            a = r1.Next();
            a = a % (23 - 10) + 10;
            if (DataStorage.TypeOfPirate == "Weak Pirate")
            {
                wp.GetDamage(a);
                TheEventLog.Items.Add("You hit the opponent with a sword! Your attack: " + a);
                TheEventLog.Items.Add(wp.GetInfo());
                EHP = progressBar2.Value - a;
                if(EHP<=0)
                {
                    player3.Play();
                    progressBar2.Value = 0;
                    MessageBox.Show("You won!");
                    Hide();
                    Form5 f5 = new Form5();
                    f5.ShowDialog();
                    Close();
                    player5.Play();
                }
                else
                {
                    progressBar2.Value = progressBar2.Value - a;
                    MessageBox.Show("Your opponent's turn!");
                    TheEventLog.Items.Add("The enemy is aiming you..........");
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button1.Enabled = true;
                    button2.Enabled = true;
                }
                if(DataStorage.ApplyBandages==true)
                {
                    if(wp.Bandage>0)
                    {
                        if (wp.HP < 40)
                        {
                            player1.Play();
                            TheEventLog.Items.Add("Enemy is healing!....");
                            wp.HP = 100;
                            progressBar2.Value = HP;
                            wp.Bandage--;
                        }
                    }

                }


            }
            else if (DataStorage.TypeOfPirate == "Medium Pirate")
            {

                mp.GetDamage(a);
                TheEventLog.Items.Add("You hit the opponent with a sword! Your attack: " + a);
                TheEventLog.Items.Add(mp.GetInfo());
                EHP = progressBar2.Value - a;
                if (EHP <= 0)
                {
                    player3.Play();
                    progressBar2.Value = 0;
                    MessageBox.Show("You won!");
                    Hide();
                    Form5 f5 = new Form5();
                    f5.ShowDialog();
                    Close();
                    player5.Play();
                }
                else
                {
                    progressBar2.Value = progressBar2.Value - a;
                    MessageBox.Show("Your opponent's turn!");
                    TheEventLog.Items.Add("The enemy is aiming you..........");
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button1.Enabled = true;
                    button2.Enabled = true;
                }
                if (DataStorage.ApplyBandages == true)
                {
                    if (mp.Bandage > 0)
                    {
                        if (mp.HP < 40)
                        {
                            player1.Play();
                            TheEventLog.Items.Add("Enemy is healing!....");
                            mp.HP = 100;
                            progressBar2.Value = HP;
                            mp.Bandage--;
                        }
                    }

                }
            }
            else if (DataStorage.TypeOfPirate == "Strong Pirate")
            {
                sp.GetDamage(a);
                TheEventLog.Items.Add("You hit the opponent with a sword! Your attack: " + a);
                TheEventLog.Items.Add(sp.GetInfo());
                EHP = progressBar2.Value - a;
                if (EHP <= 0)
                {
                    player3.Play();
                    progressBar2.Value = 0;
                    MessageBox.Show("You won!");
                    Hide();
                    Form5 f5 = new Form5();
                    f5.ShowDialog();
                    Close();
                    player5.Play();
                }
                else
                {
                    progressBar2.Value = progressBar2.Value - a;
                    MessageBox.Show("Your opponent's turn!");
                    TheEventLog.Items.Add("The enemy is aiming you..........");
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button1.Enabled = true;
                    button2.Enabled = true;
                }
                if (DataStorage.ApplyBandages == true)
                {
                    if (sp.Bandage > 0)
                    {
                        if (sp.HP < 40)
                        {
                            player1.Play();
                            TheEventLog.Items.Add("Enemy is healing!....");
                            sp.HP = 100;
                            progressBar2.Value = HP;
                            sp.Bandage--;
                        }
                    }

                }
            }








        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(YourCartridge>0)
            {
                player.Play();
                YourCartridge--;

                a = r1.Next();
                a = a % (35 - 16) + 16;
                if (DataStorage.TypeOfPirate == "Weak Pirate")
                {
                    wp.GetDamage(a);
                    TheEventLog.Items.Add("You hit the opponent with a pistol! Your attack: " + a);
                    TheEventLog.Items.Add(wp.GetInfo());
                    EHP = progressBar2.Value - a;
                    if (EHP <= 0)
                    {
                        player3.Play();
                        progressBar2.Value = 0;
                        MessageBox.Show("You won!");
                        Hide();
                        Form5 f5 = new Form5();
                        f5.ShowDialog();
                        Close();
                        player5.Play();
                    }
                    else
                    {
                        progressBar2.Value = progressBar2.Value - a;
                        MessageBox.Show("Your opponent's turn!");
                        TheEventLog.Items.Add("The enemy is aiming you..........");
                        button3.Enabled = false;
                        button4.Enabled = false;
                        button1.Enabled = true;
                        button2.Enabled = true;
                    }
                    if (DataStorage.ApplyBandages == true)
                    {
                        if (wp.Bandage > 0)
                        {
                            if (wp.HP < 40)
                            {
                                player1.Play();
                                TheEventLog.Items.Add("Enemy is healing!....");
                                wp.HP = 100;
                                progressBar2.Value = HP;
                                wp.Bandage--;
                            }
                        }

                    }

                }
                else if (DataStorage.TypeOfPirate == "Medium Pirate")
                {

                    mp.GetDamage(a);
                    TheEventLog.Items.Add("You hit the opponent with a pistol! Your attack: " + a);
                    TheEventLog.Items.Add(mp.GetInfo());
                    EHP = progressBar2.Value - a;
                    if (EHP <= 0)
                    {
                        player3.Play();
                        progressBar2.Value = 0;
                        MessageBox.Show("You won!");
                        Hide();
                        Form5 f5 = new Form5();
                        f5.ShowDialog();
                        Close();
                        player5.Play();
                    }
                    else
                    {
                        progressBar2.Value = progressBar2.Value - a;
                        MessageBox.Show("Your opponent's turn!");
                        TheEventLog.Items.Add("The enemy is aiming you..........");
                        button3.Enabled = false;
                        button4.Enabled = false;
                        button1.Enabled = true;
                        button2.Enabled = true;
                    }
                    if (DataStorage.ApplyBandages == true)
                    {
                        if (mp.Bandage > 0)
                        {
                            if (mp.HP < 40)
                            {
                                player1.Play();
                                TheEventLog.Items.Add("Enemy is healing!....");
                                mp.HP = 100;
                                progressBar2.Value = HP;
                                mp.Bandage--;
                            }
                        }

                    }
                }
                else if (DataStorage.TypeOfPirate == "Strong Pirate")
                {
                    sp.GetDamage(a);
                    TheEventLog.Items.Add("You hit the opponent with a pistol! Your attack: " + a);
                    TheEventLog.Items.Add(sp.GetInfo());
                    EHP = progressBar2.Value - a;
                    if (EHP <= 0)
                    {
                        player3.Play();
                        progressBar2.Value = 0;
                        MessageBox.Show("You won!");
                        Hide();
                        Form5 f5 = new Form5();
                        f5.ShowDialog();
                        Close();
                        player5.Play();
                    }
                    else
                    {
                        progressBar2.Value = progressBar2.Value - a;
                        MessageBox.Show("Your opponent's turn!");
                        TheEventLog.Items.Add("The enemy is aiming you..........");
                        button3.Enabled = false;
                        button4.Enabled = false;
                        button1.Enabled = true;
                        button2.Enabled = true;
                    }
                    if (DataStorage.ApplyBandages == true)
                    {
                        if (sp.Bandage > 0)
                        {
                            if (sp.HP < 40)
                            {
                                player1.Play();
                                TheEventLog.Items.Add("Enemy is healing!....");
                                sp.HP = 100;
                                progressBar2.Value = HP;
                                sp.Bandage--;
                            }
                        }

                    }
                }
            }







        }

        private void button1_Click(object sender, EventArgs e)//Right
        {
            try
            {
                if (DataStorage.TypeOfPirate == "Weak Pirate")
                {

                    if (wp.Cartridge > 0)
                    {
                        player.Play();
                        wp.Cartridge--;
                        Go1 = Go.Next();
                        Go1 = Go1 % (5 - 1) + 1;
                        if (Go1 == 1)//Player went wrong way!
                        {
                            TheEventLog.Items.Add("Enemy has shot! And player went wrong way! Enemy's attack: " + wp.AttackWithPistol());
                            TheEventLog.Items.Add(wp.GetInfo());
                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - wp.AttackWithPistol();
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }



                        }
                        else if (Go1 == 2)//Player went correctly but saved not much HP
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (7 - 1) + 1;
                            TheEventLog.Items.Add("Enemy has shot! But player went correct way! However, he has saved not much HP. Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + wp.AttackWithPistol());
                            TheEventLog.Items.Add(wp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (wp.AttackWithPistol() - AmountOfSkipDamage1);
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else if (Go1 == 3)//PLayer went correctly and saved quite much health!
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (20 - 1) + 1;
                            TheEventLog.Items.Add("Enemy has shot! But player went correct way and has saved quite much HP! Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + wp.AttackWithPistol());
                            TheEventLog.Items.Add(wp.GetInfo());


                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (wp.AttackWithPistol() - AmountOfSkipDamage1);
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }


                        }
                        else//Player went absolutely correctly!!!
                        {
                            TheEventLog.Items.Add("Enemy has shot, but Player went absolutely correctly! He saved all his HP!!!");
                            button1.Enabled = false;
                            button2.Enabled = false;
                            button3.Enabled = true;
                            button4.Enabled = true;
                            MessageBox.Show("Your turn!");
                        }
                    }
                    else
                    {
                        player2.Play();

                        Go1 = Go.Next();
                        Go1 = Go1 % (5 - 1) + 1;
                        if (Go1 == 1)//Player went wrong way!
                        {
                            TheEventLog.Items.Add("Enemy uses his saber! And player went wrong way! Enemy's attack: " + wp.AttackWithSword());
                            TheEventLog.Items.Add(wp.GetInfo());
                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - wp.AttackWithSword();
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else if (Go1 == 2)//Player went correctly but saved not much HP
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (7 - 1) + 1;
                            TheEventLog.Items.Add("Enemy uses his saber! But player went correct way! However, he has saved not much HP. Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + wp.AttackWithSword());
                            TheEventLog.Items.Add(wp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (wp.AttackWithSword() - AmountOfSkipDamage1);
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }



                        }
                        else if (Go1 == 3)//PLayer went correctly and saved quite much health!
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (20 - 1) + 1;
                            TheEventLog.Items.Add("Enemy uses his saber! But player went correct way and has saved quite much HP! Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + wp.AttackWithSword());
                            TheEventLog.Items.Add(wp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (wp.AttackWithSword() - AmountOfSkipDamage1);
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }



                        }
                        else//Player went absolutely correctly!!!
                        {
                            TheEventLog.Items.Add("Enemy uses his saber, but Player went absolutely correctly! He saved all his HP!!!");
                            button1.Enabled = false;
                            button2.Enabled = false;
                            button3.Enabled = true;
                            button4.Enabled = true;
                            MessageBox.Show("Your turn!");
                        }

                    }
                }
                if (DataStorage.TypeOfPirate == "Medium Pirate")
                {
                    if (mp.Cartridge > 0)
                    {
                        player.Play();
                        mp.Cartridge--;
                        Go1 = Go.Next();
                        Go1 = Go1 % (5 - 1) + 1;
                        if (Go1 == 1)//Player went wrong way!
                        {
                            TheEventLog.Items.Add("Enemy has shot! And player went wrong way! Enemy's attack: " + mp.AttackWithPistol());
                            TheEventLog.Items.Add(mp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - mp.AttackWithPistol();
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else if (Go1 == 2)//Player went correctly but saved not much HP
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (7 - 1) + 1;
                            TheEventLog.Items.Add("Enemy has shot! But player went correct way! However, he has saved not much HP. Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + mp.AttackWithPistol());
                            TheEventLog.Items.Add(mp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (mp.AttackWithPistol() - AmountOfSkipDamage1);
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else if (Go1 == 3)//PLayer went correctly and saved quite much health!
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (20 - 1) + 1;
                            TheEventLog.Items.Add("Enemy has shot! But player went correct way and has saved quite much HP! Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + mp.AttackWithPistol());
                            TheEventLog.Items.Add(mp.GetInfo());

                            if (EHP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (mp.AttackWithPistol() - AmountOfSkipDamage1);
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else//Player went absolutely correctly!!!
                        {
                            TheEventLog.Items.Add("Enemy has shot, but Player went absolutely correctly! He saved all his HP!!!");
                            TheEventLog.Items.Add(mp.GetInfo());
                            button1.Enabled = false;
                            button2.Enabled = false;
                            button3.Enabled = true;
                            button4.Enabled = true;
                            MessageBox.Show("Your turn!");
                        }
                    }
                    else
                    {
                        player2.Play();
                        Go1 = Go.Next();
                        Go1 = Go1 % (5 - 1) + 1;
                        if (Go1 == 1)//Player went wrong way!
                        {
                            TheEventLog.Items.Add("Enemy uses his saber! And player went wrong way! Enemy's attack: " + mp.AttackWithSword());
                            TheEventLog.Items.Add(mp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - mp.AttackWithSword();
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else if (Go1 == 2)//Player went correctly but saved not much HP
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (7 - 1) + 1;
                            TheEventLog.Items.Add("Enemy uses his saber! But player went correct way! However, he has saved not much HP. Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + mp.AttackWithSword());
                            TheEventLog.Items.Add(mp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (mp.AttackWithSword() - AmountOfSkipDamage1);
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else if (Go1 == 3)//PLayer went correctly and saved quite much health!
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (20 - 1) + 1;
                            TheEventLog.Items.Add("Enemy uses his saber! But player went correct way and has saved quite much HP! Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + mp.AttackWithSword());
                            TheEventLog.Items.Add(mp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (mp.AttackWithSword() - AmountOfSkipDamage1);
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else//Player went absolutely correctly!!!
                        {
                            TheEventLog.Items.Add("Enemy uses his saber, but Player went absolutely correctly! He saved all his HP!!!");
                            TheEventLog.Items.Add(mp.GetInfo());
                            button1.Enabled = false;
                            button2.Enabled = false;
                            button3.Enabled = true;
                            button4.Enabled = true;
                            MessageBox.Show("Your turn!");
                        }

                    }
                }
                if (DataStorage.TypeOfPirate == "Strong Pirate")
                {
                    if (sp.Cartridge > 0)
                    {
                        player.Play();
                        sp.Cartridge--;
                        Go1 = Go.Next();
                        Go1 = Go1 % (5 - 1) + 1;
                        if (Go1 == 1)//Player went wrong way!
                        {
                            TheEventLog.Items.Add("Enemy has shot! And player went wrong way! Enemy's attack: " + sp.AttackWithPistol());
                            TheEventLog.Items.Add(sp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - sp.AttackWithPistol();
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else if (Go1 == 2)//Player went correctly but saved not much HP
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (7 - 1) + 1;
                            TheEventLog.Items.Add("Enemy has shot! But player went correct way! However, he has saved not much HP. Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + sp.AttackWithPistol());
                            TheEventLog.Items.Add(sp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (sp.AttackWithPistol() - AmountOfSkipDamage1);

                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else if (Go1 == 3)//PLayer went correctly and saved quite much health!
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (20 - 1) + 1;
                            TheEventLog.Items.Add("Enemy has shot! But player went correct way and has saved quite much HP! Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + sp.AttackWithPistol());
                            TheEventLog.Items.Add(sp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (sp.AttackWithPistol() - AmountOfSkipDamage1);

                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else//Player went absolutely correctly!!!
                        {
                            TheEventLog.Items.Add("Enemy has shot, but Player went absolutely correctly! He saved all his HP!!!");
                            TheEventLog.Items.Add(sp.GetInfo());
                            button1.Enabled = false;
                            button2.Enabled = false;
                            button3.Enabled = true;
                            button4.Enabled = true;
                            MessageBox.Show("Your turn!");
                        }
                    }
                    else
                    {
                        player2.Play();
                        Go1 = Go.Next();
                        Go1 = Go1 % (5 - 1) + 1;
                        if (Go1 == 1)//Player went wrong way!
                        {
                            TheEventLog.Items.Add("Enemy uses his saber! And player went wrong way! Enemy's attack: " + sp.AttackWithSword());
                            TheEventLog.Items.Add(sp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - sp.AttackWithSword();
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else if (Go1 == 2)//Player went correctly but saved not much HP
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (7 - 1) + 1;
                            TheEventLog.Items.Add("Enemy uses his saber! But player went correct way! However, he has saved not much HP. Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + sp.AttackWithSword());
                            TheEventLog.Items.Add(sp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (sp.AttackWithSword() - AmountOfSkipDamage1);
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else if (Go1 == 3)//PLayer went correctly and saved quite much health!
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (20 - 1) + 1;
                            TheEventLog.Items.Add("Enemy uses his saber! But player went correct way and has saved quite much HP! Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + sp.AttackWithSword());
                            TheEventLog.Items.Add(sp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (sp.AttackWithSword() - AmountOfSkipDamage1);
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else//Player went absolutely correctly!!!
                        {
                            TheEventLog.Items.Add("Enemy uses his saber, but Player went absolutely correctly! He saved all his HP!!!");
                            TheEventLog.Items.Add(sp.GetInfo());
                            button1.Enabled = false;
                            button2.Enabled = false;
                            button3.Enabled = true;
                            button4.Enabled = true;
                            MessageBox.Show("Your turn!");

                        }

                    }
                }
            }
            catch(Exception ex)
            {
                player4.Play();
                progressBar1.Value = 0;
                MessageBox.Show("Enemy won!");
                Hide();
                Form5 f5 = new Form5();
                f5.ShowDialog();
                Close();
                player5.Play();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (DataStorage.TypeOfPirate == "Weak Pirate")
                {

                    if (wp.Cartridge > 0)
                    {
                        player.Play();
                        wp.Cartridge--;
                        Go1 = Go.Next();
                        Go1 = Go1 % (5 - 1) + 1;
                        if (Go1 == 1)//Player went wrong way!
                        {
                            TheEventLog.Items.Add("Enemy has shot! And player went wrong way! Enemy's attack: " + wp.AttackWithPistol());
                            TheEventLog.Items.Add(wp.GetInfo());
                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - wp.AttackWithPistol();
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }



                        }
                        else if (Go1 == 2)//Player went correctly but saved not much HP
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (7 - 1) + 1;
                            TheEventLog.Items.Add("Enemy has shot! But player went correct way! However, he has saved not much HP. Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + wp.AttackWithPistol());
                            TheEventLog.Items.Add(wp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (wp.AttackWithPistol() - AmountOfSkipDamage1);
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else if (Go1 == 3)//PLayer went correctly and saved quite much health!
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (20 - 1) + 1;
                            TheEventLog.Items.Add("Enemy has shot! But player went correct way and has saved quite much HP! Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + wp.AttackWithPistol());
                            TheEventLog.Items.Add(wp.GetInfo());


                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (wp.AttackWithPistol() - AmountOfSkipDamage1);
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }


                        }
                        else//Player went absolutely correctly!!!
                        {
                            TheEventLog.Items.Add("Enemy has shot, but Player went absolutely correctly! He saved all his HP!!!");
                            button1.Enabled = false;
                            button2.Enabled = false;
                            button3.Enabled = true;
                            button4.Enabled = true;
                            MessageBox.Show("Your turn!");
                        }
                    }
                    else
                    {
                        player2.Play();

                        Go1 = Go.Next();
                        Go1 = Go1 % (5 - 1) + 1;
                        if (Go1 == 1)//Player went wrong way!
                        {
                            TheEventLog.Items.Add("Enemy uses his saber! And player went wrong way! Enemy's attack: " + wp.AttackWithSword());
                            TheEventLog.Items.Add(wp.GetInfo());
                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - wp.AttackWithSword();
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else if (Go1 == 2)//Player went correctly but saved not much HP
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (7 - 1) + 1;
                            TheEventLog.Items.Add("Enemy uses his saber! But player went correct way! However, he has saved not much HP. Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + wp.AttackWithSword());
                            TheEventLog.Items.Add(wp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (wp.AttackWithSword() - AmountOfSkipDamage1);
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }



                        }
                        else if (Go1 == 3)//PLayer went correctly and saved quite much health!
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (20 - 1) + 1;
                            TheEventLog.Items.Add("Enemy uses his saber! But player went correct way and has saved quite much HP! Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + wp.AttackWithSword());
                            TheEventLog.Items.Add(wp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (wp.AttackWithSword() - AmountOfSkipDamage1);
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }



                        }
                        else//Player went absolutely correctly!!!
                        {
                            TheEventLog.Items.Add("Enemy uses his saber, but Player went absolutely correctly! He saved all his HP!!!");
                            button1.Enabled = false;
                            button2.Enabled = false;
                            button3.Enabled = true;
                            button4.Enabled = true;
                            MessageBox.Show("Your turn!");
                        }

                    }
                }
                if (DataStorage.TypeOfPirate == "Medium Pirate")
                {
                    if (mp.Cartridge > 0)
                    {
                        player.Play();
                        mp.Cartridge--;
                        Go1 = Go.Next();
                        Go1 = Go1 % (5 - 1) + 1;
                        if (Go1 == 1)//Player went wrong way!
                        {
                            TheEventLog.Items.Add("Enemy has shot! And player went wrong way! Enemy's attack: " + mp.AttackWithPistol());
                            TheEventLog.Items.Add(mp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - mp.AttackWithPistol();
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else if (Go1 == 2)//Player went correctly but saved not much HP
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (7 - 1) + 1;
                            TheEventLog.Items.Add("Enemy has shot! But player went correct way! However, he has saved not much HP. Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + mp.AttackWithPistol());
                            TheEventLog.Items.Add(mp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (mp.AttackWithPistol() - AmountOfSkipDamage1);
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else if (Go1 == 3)//PLayer went correctly and saved quite much health!
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (20 - 1) + 1;
                            TheEventLog.Items.Add("Enemy has shot! But player went correct way and has saved quite much HP! Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + mp.AttackWithPistol());
                            TheEventLog.Items.Add(mp.GetInfo());

                            if (EHP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (mp.AttackWithPistol() - AmountOfSkipDamage1);
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else//Player went absolutely correctly!!!
                        {
                            TheEventLog.Items.Add("Enemy has shot, but Player went absolutely correctly! He saved all his HP!!!");
                            TheEventLog.Items.Add(mp.GetInfo());
                            button1.Enabled = false;
                            button2.Enabled = false;
                            button3.Enabled = true;
                            button4.Enabled = true;
                            MessageBox.Show("Your turn!");
                        }
                    }
                    else
                    {
                        player2.Play();
                        Go1 = Go.Next();
                        Go1 = Go1 % (5 - 1) + 1;
                        if (Go1 == 1)//Player went wrong way!
                        {
                            TheEventLog.Items.Add("Enemy uses his saber! And player went wrong way! Enemy's attack: " + mp.AttackWithSword());
                            TheEventLog.Items.Add(mp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - mp.AttackWithSword();
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else if (Go1 == 2)//Player went correctly but saved not much HP
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (7 - 1) + 1;
                            TheEventLog.Items.Add("Enemy uses his saber! But player went correct way! However, he has saved not much HP. Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + mp.AttackWithSword());
                            TheEventLog.Items.Add(mp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (mp.AttackWithSword() - AmountOfSkipDamage1);
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else if (Go1 == 3)//PLayer went correctly and saved quite much health!
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (20 - 1) + 1;
                            TheEventLog.Items.Add("Enemy uses his saber! But player went correct way and has saved quite much HP! Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + mp.AttackWithSword());
                            TheEventLog.Items.Add(mp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (mp.AttackWithSword() - AmountOfSkipDamage1);
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else//Player went absolutely correctly!!!
                        {
                            TheEventLog.Items.Add("Enemy uses his saber, but Player went absolutely correctly! He saved all his HP!!!");
                            TheEventLog.Items.Add(mp.GetInfo());
                            button1.Enabled = false;
                            button2.Enabled = false;
                            button3.Enabled = true;
                            button4.Enabled = true;
                            MessageBox.Show("Your turn!");
                        }

                    }
                }
                if (DataStorage.TypeOfPirate == "Strong Pirate")
                {
                    if (sp.Cartridge > 0)
                    {
                        player.Play();
                        sp.Cartridge--;
                        Go1 = Go.Next();
                        Go1 = Go1 % (5 - 1) + 1;
                        if (Go1 == 1)//Player went wrong way!
                        {
                            TheEventLog.Items.Add("Enemy has shot! And player went wrong way! Enemy's attack: " + sp.AttackWithPistol());
                            TheEventLog.Items.Add(sp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - sp.AttackWithPistol();
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else if (Go1 == 2)//Player went correctly but saved not much HP
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (7 - 1) + 1;
                            TheEventLog.Items.Add("Enemy has shot! But player went correct way! However, he has saved not much HP. Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + sp.AttackWithPistol());
                            TheEventLog.Items.Add(sp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (sp.AttackWithPistol() - AmountOfSkipDamage1);

                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else if (Go1 == 3)//PLayer went correctly and saved quite much health!
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (20 - 1) + 1;
                            TheEventLog.Items.Add("Enemy has shot! But player went correct way and has saved quite much HP! Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + sp.AttackWithPistol());
                            TheEventLog.Items.Add(sp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (sp.AttackWithPistol() - AmountOfSkipDamage1);

                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else//Player went absolutely correctly!!!
                        {
                            TheEventLog.Items.Add("Enemy has shot, but Player went absolutely correctly! He saved all his HP!!!");
                            TheEventLog.Items.Add(sp.GetInfo());
                            button1.Enabled = false;
                            button2.Enabled = false;
                            button3.Enabled = true;
                            button4.Enabled = true;
                            MessageBox.Show("Your turn!");
                        }
                    }
                    else
                    {
                        player2.Play();
                        Go1 = Go.Next();
                        Go1 = Go1 % (5 - 1) + 1;
                        if (Go1 == 1)//Player went wrong way!
                        {
                            TheEventLog.Items.Add("Enemy uses his saber! And player went wrong way! Enemy's attack: " + sp.AttackWithSword());
                            TheEventLog.Items.Add(sp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - sp.AttackWithSword();
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else if (Go1 == 2)//Player went correctly but saved not much HP
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (7 - 1) + 1;
                            TheEventLog.Items.Add("Enemy uses his saber! But player went correct way! However, he has saved not much HP. Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + sp.AttackWithSword());
                            TheEventLog.Items.Add(sp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (sp.AttackWithSword() - AmountOfSkipDamage1);
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else if (Go1 == 3)//PLayer went correctly and saved quite much health!
                        {
                            AmountOfSkipDamage1 = AmountOfSkipDamage.Next();
                            AmountOfSkipDamage1 = AmountOfSkipDamage1 % (20 - 1) + 1;
                            TheEventLog.Items.Add("Enemy uses his saber! But player went correct way and has saved quite much HP! Player has saved " + AmountOfSkipDamage1 + " HP. Enemy's attack:" + sp.AttackWithSword());
                            TheEventLog.Items.Add(sp.GetInfo());

                            if (HP <= 0)
                            {
                                player4.Play();
                                progressBar1.Value = 0;
                                MessageBox.Show(DataStorage.EnemyName + " won!");
                                Hide();
                                Form5 f5 = new Form5();
                                f5.ShowDialog();
                                Close();
                            }
                            else
                            {
                                progressBar1.Value = progressBar1.Value - (sp.AttackWithSword() - AmountOfSkipDamage1);
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                MessageBox.Show("Your turn!");
                            }




                        }
                        else//Player went absolutely correctly!!!
                        {
                            TheEventLog.Items.Add("Enemy uses his saber, but Player went absolutely correctly! He saved all his HP!!!");
                            TheEventLog.Items.Add(sp.GetInfo());
                            button1.Enabled = false;
                            button2.Enabled = false;
                            button3.Enabled = true;
                            button4.Enabled = true;
                            MessageBox.Show("Your turn!");

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                player4.Play();
                progressBar1.Value = 0;
                MessageBox.Show("Enemy won!");
                Hide();
                Form5 f5 = new Form5();
                f5.ShowDialog();
                Close();
                player5.Play();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(DataStorage.ApplyBandages==true)
            {
                if (YourBandage > 0)
                {
                    player1.Play();
                    TheEventLog.Items.Add("You healed yourself!");
                    progressBar1.Value = 100;
                    HP = 100;
                    YourBandage--;

                }
            }

        }
    }
}
