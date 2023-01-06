using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Project_V_0._0._1
{
    internal class CharacterMaking
    {
        Player player = new Player();

        public void Selectjob()
        {
            StaticClass.screenSize[5, 5] = "직업을 선택하세요";

            StaticClass.screenSize[10, 8] = "1. FIGHTER";
            StaticClass.screenSize[12, 8] = "2. MAGE";
            StaticClass.screenSize[14, 8] = "3. ROGUE";


            StaticClass.screenSize[10, 6] = "▶";
            Screen.PrintScreen();

        }

        public void Selectjob2() 
        {
            string temp;
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.DownArrow:
                    if(StaticClass.screenSize[10, 6]== "▶")
                    {
                        temp = StaticClass.screenSize[10, 6];
                        StaticClass.screenSize[10, 6] = StaticClass.screenSize[12, 6];
                        StaticClass.screenSize[12, 6] = temp;

                    }
                    else if (StaticClass.screenSize[12, 6] == "▶")
                    {
                        temp = StaticClass.screenSize[12, 6];
                        StaticClass.screenSize[12, 6] = StaticClass.screenSize[14, 6];
                        StaticClass.screenSize[14, 6] = temp;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (StaticClass.screenSize[12, 6] == "▶")
                    {
                        temp = StaticClass.screenSize[12, 6];
                        StaticClass.screenSize[12, 6] = StaticClass.screenSize[10, 6];
                        StaticClass.screenSize[10, 6] = temp;
                    }
                    else if (StaticClass.screenSize[14, 6] == "▶")
                    {
                        temp = StaticClass.screenSize[14, 6];
                        StaticClass.screenSize[14, 6] = StaticClass.screenSize[12, 6];
                        StaticClass.screenSize[12, 6] = temp;
                    }
                    break;
                case ConsoleKey.Enter:
                    StaticClass.checkSelectJob = false;
                    break;
            }
            Console.Clear();
            Screen.PrintScreen();
        }

        public void SelectJob3()
        {
            while (StaticClass.checkSelectJob)
            {
                Selectjob2();
            }
        }

    }
}
