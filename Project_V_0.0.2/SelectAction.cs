using Project_V_0._0._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Project_V_0._0._2.Town1;

namespace Project_V_0._0._2
{
    public class SelectAction
    {
        public void SelectJob()
        {
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
                default:
                    BaseSetting.correctInput = false;
                    break;
            }
        }

        public void ConfirmedJobSelect(Player player)
        {
            string input = Console.ReadLine();

            if (input == "Y" || input == "y")
            {
                BaseSetting.loopCheck = false;
            }
            else if (input == "N" || input == "n")
            {
                BaseSetting.fighter = false;
                BaseSetting.mage = false;
                BaseSetting.rogue = false;

                player.JobStatusReset();
            }
        }

        public void SelectActionAtTown1Main(Town1 town1)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    town1.InStore();
                    break;
                case "2":
                    BaseSetting.mage = true;
                    break;
                case "3":
                    BaseSetting.rogue = true;
                    break;
                default:
                    BaseSetting.correctInput = false;
                    break;
            }


            //ConsoleKeyInfo keyInfo;
            //keyInfo = Console.ReadKey();
            //string temp;
            //switch (keyInfo.Key)
            //{
            //    case ConsoleKey.DownArrow:
            //        if (town1.choice[0, 0] == "▶")
            //        {
            //            temp = town1.choice[0, 0];
            //            town1.choice[0, 0] = town1.choice[0, 1];
            //            town1.choice[0, 1] = temp;
            //        }
            //        else if (town1.choice[0, 1] == "▶")
            //        {
            //            temp = town1.choice[0, 1];
            //            town1.choice[0, 1] = town1.choice[0, 2];
            //            town1.choice[0, 2] = temp;
            //        }
            //        else if (town1.choice[0, 2] == "▶")
            //        {
            //            temp = town1.choice[0, 2];
            //            town1.choice[0, 2] = town1.choice[0, 3];
            //            town1.choice[0, 3] = temp;
            //        }
            //        else
            //        {

            //        }
            //        break;
            //    case ConsoleKey.UpArrow:
            //        if (town1.choice[0, 3] == "▶")
            //        {
            //            temp = town1.choice[0, 3];
            //            town1.choice[0, 3] = town1.choice[0, 2];
            //            town1.choice[0, 2] = temp;
            //        }
            //        else if (town1.choice[0, 2] == "▶")
            //        {
            //            temp = town1.choice[0, 2];
            //            town1.choice[0, 2] = town1.choice[0, 1];
            //            town1.choice[0, 1] = temp;
            //        }
            //        else if (town1.choice[0, 1] == "▶")
            //        {
            //            temp = town1.choice[0, 1];
            //            town1.choice[0, 1] = town1.choice[0, 0];
            //            town1.choice[0, 0] = temp;
            //        }
            //        else
            //        {

            //        }
            //        break;
            //    case ConsoleKey.Enter:
            //        BaseSetting.loopCheck = false;
            //        break;
            //}
        }

        public void InStore()
        {
            Console.ReadKey();
        }



        public void SelectActionTown1Building()
        {

        }
    }
}
