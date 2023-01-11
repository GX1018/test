using Project_V_0._0._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_V_0._0._2
{
    public class BaseCamp
    {
        public string campName;
        public string store = "상점";
        public string church = "교회";
        public string guild = "길드";
        public string goToNext = "필드로 이동";
        public string returnToCamp = "돌아가기";
        public string[,] choice;
    }


    public class Town1 : BaseCamp
    {
        Screen screen = new Screen();
        SelectAction selectAction = new SelectAction();

        public Town1()
        {
            this.campName = "마을";

            //this.choice = new string[3, 4];

            //choice[0, 0] = "▶"; choice[0, 1] = "  "; choice[0, 2] = "  "; choice[0, 3] = "  ";
            //choice[2, 0] = store; choice[2, 1] = church; choice[2, 2] = guild; choice[2, 3] = goToNext;
        }

        public void Town1Main()
        {
            screen.town1screen(this);
            selectAction.SelectActionAtTown1Main(this);
        }

        public void InStore()
        {
            screen.StoreScreen(this);
            selectAction.InStore();
        }

        Player player = new Player();
        public void StatusInTown()
        {
            screen.StatusScreen(player);
            Console.ReadLine();

        }

        public void EquipInTown()
        {
            screen.PlayerEquipScreen();
            Console.ReadLine();

        }


        public void InventoryInTown()
        {
            screen.InventoryScreen();
            selectAction.InventorySelect_1(this);
        }

        public void InventoryEquipInTown()
        {
            screen.CurrentEquipment();
            screen.EquipItemScreen();
            selectAction.EquipSelect();
        }

        public void Town1Building()
        {
            screen.Town1building(this);
        }



        public void selectAction_()
        {
            ConsoleKeyInfo keyInfo;
            keyInfo = Console.ReadKey();
            string temp;
            switch (keyInfo.Key)
            {
                case ConsoleKey.DownArrow:
                    if (choice[0, 0] == "▶")
                    {
                        temp = choice[0, 0];
                        choice[0, 0] = choice[0, 1];
                        choice[0, 1] = temp;
                    }
                    else if (choice[0, 1] == "▶")
                    {
                        temp = choice[0, 1];
                        choice[0, 1] = choice[0, 2];
                        choice[0, 2] = temp;
                    }
                    else if (choice[0, 2] == "▶")
                    {
                        temp = choice[0, 2];
                        choice[0, 2] = choice[0, 3];
                        choice[0, 3] = temp;
                    }
                    else
                    {

                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (choice[0, 3] == "▶")
                    {
                        temp = choice[0, 3];
                        choice[0, 3] = choice[0, 2];
                        choice[0, 2] = temp;
                    }
                    else if (choice[0, 2] == "▶")
                    {
                        temp = choice[0, 2];
                        choice[0, 2] = choice[0, 1];
                        choice[0, 1] = temp;
                    }
                    else if (choice[0, 1] == "▶")
                    {
                        temp = choice[0, 1];
                        choice[0, 1] = choice[0, 0];
                        choice[0, 0] = temp;
                    }
                    else
                    {

                    }
                    break;
                case ConsoleKey.Enter:
                    BaseSetting.loopCheck = false;
                    break;
            }
        }
        public class Town2 : Town1
        {
            public Town2()
            {
                this.campName = "도시";
            }
        }


            public void GoNext()
        {
            if (choice[0, 3] == "▶")
            {
                Screen.GoToField();
            }
        }

        
    }


    public class Building
    {
            public string name;

            public string return_town = "돌아간다";
    }

    public class Store : Building
    {
        public Store()
        {
            this.name = "상점";
        }
        public string buy = "구입";
        public string sell = "판매";

    }
}
