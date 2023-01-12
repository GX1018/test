using Project_V_0._0._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
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

        public void SelectActionAtTown1Main(Town1 town1, Player player, UseItem useItem)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    town1.InStore();
                    break;
                case "2":
                    Console.Clear();
                    town1.InChurch(player);
                    break;
                case "3":
                    Console.Clear();
                    town1.InGuild();
                    break;
                case "4":
                    BaseSetting.loopCheck = false;
                    break;
                case "8":
                    town1.StatusInTown(player);
                    break;
                case "9":
                    town1.EquipInTown();
                    break;
                case "0":
                    town1.InventoryInTown(player, useItem);
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

        //일단 helmet
        Inventory inventory= new Inventory();
        public void InventorySelect(Player player, int input)
        {
            int inputIndex = int.Parse(Console.ReadLine());
            switch (inputIndex)
            {
                case 0:
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
                    Player.EquipItemSlot.equipItemSlot[input-1] = Inventory.itemName[inputIndex];
                    //
                    if (!(EquipItem.name.IndexOf(Inventory.itemName[inputIndex -1]) == -1) && 0<=EquipItem.type[EquipItem.name.IndexOf(Inventory.itemName[inputIndex -1])]
                        && EquipItem.type[EquipItem.name.IndexOf(Inventory.itemName[inputIndex -1])] < 4)
                    {
                        for(int index = 0; index < Player.EquipItemSlot.equipItemSlot.Length; index++)
                        {

                            if(EquipItem.type[EquipItem.name.IndexOf(Inventory.itemName[inputIndex - 1])] == index)
                            {
                                Player.EquipItemSlot.equipItemSlot[input - 1] = Inventory.itemName[inputIndex - 1];
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


        public void InventorySelect_1(Town1 town1, Player player ,UseItem useItem)
        {
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.Clear();
                    town1.InventoryEquipInTown();
                    break;
                case 2:
                    Console.Clear();
                    town1.InventoryUseItemInTown(useItem, player);
                    break;


                    //case 2:
                    //case 3:

            }
        }

        public void EquipSelect()
        {
            Screen screen = new Screen();
            int input = int.Parse(Console.ReadLine());


            screen.HaveEquipmet(input);
            EquipSelect_1(input);
            Console.ReadLine();


            //switch (input)
            //{
            //    case 1:// 1 =>helmet
            //        screen.HaveEquipmet(input);
            //        EquipSelect_1(input);
            //        Console.ReadLine();
            //        break;
            //        //case 2:
            //        //case 3:

            //}
        }

        public void EquipSelect_1(int itemType)
        {
            int inventoryIndex = int.Parse(Console.ReadLine());
            string temp;

            if(Player.EquipItemSlot.equipItemSlot[itemType - 1] == null)
            {
                Player.EquipItemSlot.equipItemSlot[itemType - 1] = Inventory.itemName[inventoryIndex];
                Inventory.itemName.RemoveAt(inventoryIndex);
                Inventory.itemCount.RemoveAt(inventoryIndex);

                //장비 스테이터스 변동 적용
            }
            else
            {
                temp = Player.EquipItemSlot.equipItemSlot[itemType-1];
                Player.EquipItemSlot.equipItemSlot[itemType-1] = Inventory.itemName[inventoryIndex];
                Inventory.itemName[inventoryIndex] = temp;
                //장비 스테이터스 변동 적용

            }



        }

            public void UseItemSelect(UseItem useItem, Player player)
        {
            int input = int.Parse(Console.ReadLine());
            if (input == 10)
            {
                BaseSetting.loopCheck = false;
            }
            else
            {
                useItem.ItemEffect(UseItem.name.IndexOf(Inventory.itemName[input]), player);
                Inventory.itemCount[input]--;
                if (Inventory.itemCount[input] == 0)
                {
                    Inventory.itemName.RemoveAt(input);
                    Inventory.itemCount.RemoveAt(input);
                }
            }
        }




            //


            public void InStore()
        {
            Console.ReadKey();
        }

        public void InChurch(Player player)
        {
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.Clear();
                    

                    Console.WriteLine("***PRAY***");
                    Console.WriteLine("체력이 모두 회복되었습니다.");
                    player.currentHp = player.maxHp;

                    Console.ReadKey();
                    break;

                case 2:

                    break;

                default:
                    BaseSetting.correctInput = false;
                    break;
            }
        }


        public void InGuild()
        {
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.Clear();

                    Console.ReadKey();
                    break;

                case 2:

                    break;

                default:
                    BaseSetting.correctInput = false;
                    break;
            }
        }



        public void SelectActionTown1Building()
        {

        }
    }
}
