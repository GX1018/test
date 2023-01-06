using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Project_V_0._0._1
{
    public class Player : Status
    {
        
        public Player()
        {
            this.lev = 1;
            this.exp = 0;

            this.hp = 50;
            this.mp = 20;

            this.str= 5;
            this.int_= 5;
            this.dex= 5;
        }
        public void JobStatusApply()
        {
            if (StaticClass.screenSize[10, 6] == "▶")
            {
                this.hp += 10;

                this.str += 2;

                StaticClass.fighter = true;
            }
            else if (StaticClass.screenSize[12, 6] == "▶")
            {
                this.mp += 10;

                this.int_ += 2;
                StaticClass.mage = true;
            }
            else if (StaticClass.screenSize[14, 6] == "▶")
            {
                this.hp += 5;
                this.mp += 5;

                this.dex += 2;
                StaticClass.rogue = true;
            }
        }

        public void levelup()
        {
            if (StaticClass.fighter == true)
            {
                if (this.lev == 1)                  //for문으로 재구성 int lev=1 ~ 30   //exp array 0~
                {
                    if (this.exp > 30)
                    {
                        this.lev++;
                        this.exp -= 30;

                        this.hp += 8;
                        this.mp += 2;

                        this.str += 2;
                        this.int_ += 1;
                        this.dex += 1;
                    }
                }
            }
            else if (StaticClass.mage == true)
            {
                if (this.lev == 1)                  //for문으로 재구성 int lev=1 ~ 30   //exp array 0~
                {
                    if (this.exp > 30)
                    {
                        this.lev++;
                        this.exp -= 30;

                        this.hp += 2;
                        this.mp += 8;

                        this.str += 1;
                        this.int_ += 2;
                        this.dex += 1;
                    }
                }
            }
            if (StaticClass.rogue == true)
            {
                if (this.lev == 1)                  //for문으로 재구성 int lev=1 ~ 30   //exp array 0~
                {
                    if (this.exp > 30)
                    {
                        this.lev++;
                        this.exp -= 30;

                        this.hp += 7;
                        this.mp += 3;

                        this.str += 1;
                        this.int_ += 2;
                        this.dex += 1;
                    }
                }
            }
        }
    }
}
