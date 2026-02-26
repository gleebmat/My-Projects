using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_Of_Fighting___Magellan_s_Expedition__Remastered_
{
    class Pirate
    {       
        public string Name { get; set; }
        public int HP { get; set; }
        public int Cartridge { get; set; }
        public int Bandage { get; set; }
        public int AttackSword { get; set; }
        public int AttackPistol { get; set; }
        public Pirate()
        {
            Name = "Pirate";
            HP = 100;
            Cartridge = 1;
            Bandage = 2;
            AttackSword = 15;
            AttackPistol = 40;
        }
        public Pirate(string Name,int HP,int Cartridge,int Bandage,int AttackSword,int AttackPistol)
        {
            this.Name = Name;
            this.HP = HP;
            this.Cartridge = Cartridge;
            this.Bandage = Bandage;
            this.AttackSword = AttackSword;
            this.AttackPistol = AttackPistol;
        }
        public virtual string GetInfo()
        {
            return "Name: "+Name + " " + HP +" HP "+ "Amount of cartridges :"+Cartridge+" " +" Amount of bandages: " + Bandage+" "+"Attack with a sword: "+AttackSword+" "+"Attack with a pistol: "+AttackPistol;
        }
        public virtual int AttackWithSword()
        {
            return AttackSword;
        }
        public virtual int AttackWithPistol()
        {
            return AttackPistol;
        }

        public virtual void GetDamage(int GetDamage)
        {
            HP -= GetDamage;
        }
    }
}
