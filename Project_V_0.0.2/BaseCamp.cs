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
        public string[,] choice;
    }

    public class Town1 : BaseCamp
    {
        public Town1()
        {
            this.campName = "마을";

            this.choice = new string[3, 4];

            choice[0, 0] = "▶"; choice[0, 1] = "  "; choice[0, 2] = "  "; choice[0, 3] = "  ";
            choice[2, 0] = store; choice[2, 1] = church; choice[2, 2] = guild; choice[2, 3] = goToNext;
        }

        public void selectAction()
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

        public void GoNext()
        {
            if (choice[0, 3] == "▶")
            {
                Screen.GoToField();
            }
        }
    }
}
