using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_Of_Fighting___Magellan_s_Expedition__Remastered_
{
    class WeakPirate:Pirate
    {
        public WeakPirate()
        {
            Name = "Weak Pirate";
            HP = 100;
            Cartridge = 1;
            Bandage = 1;
            AttackSword = 19;
            AttackPistol = 35;
        }
        public WeakPirate(string Name, int HP, int Cartridge, int Bandage,int AttackSword,int AttackPistol):base(Name,HP,Cartridge,Bandage,AttackSword,AttackPistol)
        {

        }
        public override string GetInfo()
        {
            return base.GetInfo();
        }

        public override int AttackWithSword()
        {
            return AttackSword;
        }
        public override int AttackWithPistol()
        {
            return AttackPistol;
        }

        public override void GetDamage(int GetDamage)
        {
            HP -= GetDamage;
        }

    }
}
