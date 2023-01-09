using Project_V_0._0._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Project_V_0._0._2
{
    internal class CharacterMaking
    {
        public void Selectjob()
        {
            Console.Clear();
            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine();
            Console.WriteLine(" 1. FIGHTER");
            Console.WriteLine(" 2. MAGE");
            Console.WriteLine(" 3. ROUGE");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    BaseSetting.fighter = true;
                    break;
                case "2":
                    BaseSetting.mage = true;
                    break;
                case "3":
                    BaseSetting.rogue = true;
                    break;
            }
        }
        public void ConfirmedJobSelect(Player player)
        {
            
            Console.WriteLine("선택하신 직업 : {0}", player.job);

            Console.WriteLine();
            
            Console.WriteLine("hp {0}\nmp {1}\nstr {2}\nint {3}\ndex {4}", player.maxHp, player.mp, player.str, player.int_, player.dex);
            Console.WriteLine("attack {0}\ndef {1}", player.attack, player.def);

            Console.WriteLine("\n결정 하시겠습니까? [Y/N]");
            string input = Console.ReadLine();

            if (input == "Y"|| input == "y")
            {
                BaseSetting.loopCheck = false;
            }
            else if (input == "N"|| input == "n")
            {
                BaseSetting.fighter = false;
                BaseSetting.mage = false;
                BaseSetting.rogue = false;

                player.JobStatusReset();
            }
        }

    }
}
