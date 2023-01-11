using Project_V_0._0._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project_V_0._0._2
{
    public class Player : Status
    {

        public Player()
        {
            this.job = "";
            
            this.lev = 1;
            this.exp = 0;

            this.maxHp = 50;
            this.currentHp = maxHp;
            this.mp = 20;

            this.str = 5;
            this.int_ = 5;
            this.dex = 5;

            this.attack = this.str + dex/2;
            this.mattack = this.int_;

            this.def = this.str/2;
            this.m_def = this.int_;
        }

        //public class Equipment
        //{
        //    string[] equipment = new string[5];

        //}

        public void JobStatusApply()
        {
            if (BaseSetting.fighter == true)
            {
                this.job = "FIGHTER";

                this.maxHp += 10;

                this.str += 2;

            }
            else if (BaseSetting.mage == true)
            {
                this.job = "MAGE";

                this.mp += 10;

                this.int_ += 2;
            }
            else if (BaseSetting.rogue == true)
            {
                this.job = "ROGUE";

                this.maxHp += 5;
                this.mp += 5;

                this.dex += 2;
            }
        }
        public void JobStatusReset()
        {
            this.job = "";

            this.lev = 1;
            this.exp = 0;

            this.maxHp = 50;
            this.mp = 20;

            this.str = 5;
            this.int_ = 5;
            this.dex = 5;
        }


        public void EquipmentStatusApply()
        {
            EquipItem equipItem = new EquipItem();
            
            for (int index = 0; index < EquipItemSlot.equipItemSlot.Length; index++)
            {
                if (!(Player.EquipItemSlot.equipItemSlot[index] == null))
                {
                    this.attack += EquipItem.attack[EquipItem.name.IndexOf(Player.EquipItemSlot.equipItemSlot[index])];
                    this.mattack += EquipItem.mattack[EquipItem.name.IndexOf(Player.EquipItemSlot.equipItemSlot[index])];
                    this.def += EquipItem.def[EquipItem.name.IndexOf(Player.EquipItemSlot.equipItemSlot[index])];
                    this.m_def += EquipItem.mdef[EquipItem.name.IndexOf(Player.EquipItemSlot.equipItemSlot[index])];
                    this.dex += EquipItem.dex[EquipItem.name.IndexOf(Player.EquipItemSlot.equipItemSlot[index])];
                }
            }
        }

        

        public static class EquipItemSlot
        {
            public static string[] equipItemSlot = new string[5];

            

            
            //입력//변수 < itemtype체크 ex>bool itemtypeHead = true;?//
            //입력값 == index0f


        }
    }
}
