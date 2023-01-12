using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_V_0._0._1
{
    public static class BaseSetting
    {
        public static bool checkSelectJob = true;

        public static bool fighter = false;
        public static bool mage = false;
        public static bool rogue = false;

        public static bool loopCheck = true;
        public static bool returnCheck = true;
        public static int monster;

        public static bool firstFieldEndCheck = false;

        public static bool field1BossClear = false;

        public static bool correctInput = true;

    }

    public class Status
    {
        public string job;
        
        public int lev;
        public int exp;

        public int maxHp;
        public int currentHp;

        public int maxMp;
        public int currentMp;

        public int str;
        public int int_;
        public int dex;

        public int gold;

        public int attack;
        public int mattack;

        public int def;
        public int m_def;
    }

    public class Monster
    {
        public string name;

        public int exp;

        public int hp;

        public int dex;

        public int attack;
        public int mattack;
        public int def;
        public int mdef;

        public string dropItem1;
        public int haveDropItem1;
        public string dropItem2;
        public int haveDropItem2;
        public string dropItem3;
        public int haveDropItem3;
        public string dropItem4;
        public int haveDropItem4;

    }


    //
    public class SelectOption
    {
        public string inputNum = Console.ReadLine();

        public void XX()
        {
            switch (inputNum)
            {
                case "1":
                    break;
            }
        }
    }
    //
}
