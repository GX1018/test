using Project_V_0._0._1;
using System.Numerics;

namespace Project_V_0._0._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //test//
            //EquipItem equipItem= new EquipItem();
            //Inventory inventory= new Inventory();

            //Console.WriteLine(EquipItem.name[0]);
            //inventory.AddNewItem(EquipItem.name[0], 1);

            //Console.WriteLine(Inventory.itemName[0]);

            //int input =int.Parse(Console.ReadLine());
            //Player.EquipItemSlot.equipItemSlot[input] = Inventory.itemName[input];

            //Console.WriteLine("장착 슬롯 {0}", Player.EquipItemSlot.equipItemSlot[0]);
            //test//


            Screen screen = new Screen();
            CharacterMaking characterMaking = new CharacterMaking();
            Player player = new Player();
            UseItem useItem = new UseItem();

            Inventory inventory = new Inventory();//test
            EquipItem equipItem = new EquipItem();//test

            Town1 town1 = new Town1();
            Town1.Town2 town2 = new Town1.Town2();

            FirstField firstField = new FirstField();

            screen.Title();

            while (BaseSetting.loopCheck)
            {
                characterMaking.Selectjob();
                player.JobStatusApply();

                Console.Clear();
                characterMaking.ConfirmedJobSelect(player);
            }
            BaseSetting.loopCheck = true;


            //test//
            inventory.AddNewItem(EquipItem.name[0], 1);
            inventory.AddNewItem(EquipItem.name[1], 1);
            inventory.AddNewItem(EquipItem.name[2], 1);

            inventory.AddNewItem(UseItem.name[0], 3);

            player.currentHp = 1;
            player.currentMp = 1;
            //test//

            Console.Clear();
            screen.GameStartScreen();

        returnTown://
            screen.enterTown1(town1);
            BaseSetting.returnCheck = true;
            Console.Clear();

            while (BaseSetting.loopCheck)
            {
                town1.Town1Main(player, useItem);
                Console.Clear();
            }
            BaseSetting.loopCheck = true;

        //town1.GoNext();

        fieldmain:

            //보스 클리어 체크용//
            BaseSetting.field1BossClear = false;
            //보스 클리어 체크용//


            Screen.GoToField();
            firstField.selectAction();

            if (BaseSetting.returnCheck == false)
            {
                goto returnTown;// 마을로 이동
            }

            if (BaseSetting.field1BossClear == false)
            {
                goto fieldmain;
            }


        returnTown2:
            screen.enterTown1(town2);
            BaseSetting.returnCheck = true;
            Console.Clear();
            screen.town1screen(town2);

            while (BaseSetting.loopCheck)
            {
                //town2.selectAction();
                Console.Clear();
                screen.town1screen(town2);
            }
            BaseSetting.loopCheck = true;

            Console.Clear();

            town2.GoNext();


        }
    }
}