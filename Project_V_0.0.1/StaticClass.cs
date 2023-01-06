using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_V_0._0._1
{
    public static class StaticClass
    {
        public static string[,] screenSize = new string[40, 80];
        public static bool checkSelectJob = true;

        public static bool fighter = false;
        public static bool mage = false;
        public static bool rogue = false;
    }

    public class Status
    {
        public int lev;
        public int exp;

        public int hp;
        public int mp;

        public int str;
        public int int_;
        public int dex;

        public int gold;
    }

}
