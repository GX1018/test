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

            this.hp = 50;
            this.mp = 20;

            this.str = 5;
            this.int_ = 5;
            this.dex = 5;

            int attack = this.str + (int)0.5 * dex;
            int mattack = this.int_;

            int def = (int)0.5 * this.str;
            int m_def = this.int_;
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

                this.hp += 10;

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

                this.hp += 5;
                this.mp += 5;

                this.dex += 2;
            }
        }
        public void JobStatusReset()
        {
            this.job = "";

            this.lev = 1;
            this.exp = 0;

            this.hp = 50;
            this.mp = 20;

            this.str = 5;
            this.int_ = 5;
            this.dex = 5;
        }
    }
}
