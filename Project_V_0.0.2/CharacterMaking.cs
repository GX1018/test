using Project_V_0._0._1;
using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
