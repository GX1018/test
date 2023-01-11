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
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "8":
                    town1.StatusInTown();
                    break;
                case "9":
                    town1.EquipInTown();
                    break;
                case "0":
                    town1.InventoryInTown();
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


        //EquipItem equipItem= new EquipItem();


        //이거를 equipselect case 안에////
        Inventory inventory= new Inventory();
        public void InventorySelect(Player player)
        {
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    if (!(EquipItem.name.IndexOf(Inventory.itemName[input-1]) == -1) && 0<=EquipItem.type[EquipItem.name.IndexOf(Inventory.itemName[input-1])]
                        && EquipItem.type[EquipItem.name.IndexOf(Inventory.itemName[input-1])] < 4)
                    {
                        for(int index = 0; index < Player.EquipItemSlot.equipItemSlot.Length; index++)
                        {

                            if(EquipItem.type[EquipItem.name.IndexOf(Inventory.itemName[input - 1])] == index)
                            {
                                Player.EquipItemSlot.equipItemSlot[index] = Inventory.itemName[input - 1];
                                //inventory.RemoveItem(Inventory.itemName[input - 1]);
                                player.EquipmentStatusApply();//test
                            }
                        }
                    }
                    break;
                default: 
                    break;
            }
        }


        public void InventorySelect_1(Town1 town1)
        {
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.Clear();
                    town1.InventoryEquipInTown();
                    break;


                //case 2:
                //case 3:

            }
        }

        public void EquipSelect()
        {
            Screen screen = new Screen();
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    screen.HaveEquipmet(1);

                    Console.ReadLine();
                    break;
                    //case 2:
                    //case 3:

            }
        }

        




        //


        public void InStore()
        {
            Console.ReadKey();
        }



        public void SelectActionTown1Building()
        {

        }
    }
}
