using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_V_0._0._2
{
    internal class Screen
    {
        Player player_ = new Player();
        Town1 town1 = new Town1();
        FirstField firstField = new FirstField();

        public void Title()
        {
            Console.WriteLine("GAME TITLE");

            Console.WriteLine("PRESS ENTER");

            Console.ReadKey();
        }

        public void GameStartScreen()
        {
            Console.WriteLine("[GAME START]\n[스킵하시려면 아무 키나 누르세요]");

            Task.Delay(1000).Wait();
            Console.WriteLine("스토리 설명1");//delay 한줄씩 출력
            Task.Delay(1000).Wait();
            Console.WriteLine("스토리 설명2");//delay 한줄씩 출력
            Task.Delay(1000).Wait();
            Console.WriteLine("스토리 설명3");//delay 한줄씩 출력
            Task.Delay(1000).Wait();

            Console.WriteLine("PRESS ANY KEY");
            Console.ReadKey();//스킵기능 미구현
        }

        public void town1screen(Town1 town1)
        {
            Console.WriteLine(town1.campName);
            Console.WriteLine();
            for (int y = 0; y < town1.choice.GetLength(1); y++)
            {
                for (int x = 0; x < town1.choice.GetLength(0); x++)
                {
                    Console.Write(town1.choice[x, y]);
                }
                Console.WriteLine();
            }
        }

        public static void GoToField()
        {
            Console.WriteLine();

            Task.Delay(1000).Wait();
            Console.WriteLine("[Field1Name]");//delay 한줄씩 출력
            Task.Delay(1000).Wait();
            Console.Clear();
        }

        public void FirstField()
        {
            Console.WriteLine("[FirstFieldName]\n\n\n 1. {0}\n\n 2. {1}", firstField.Search, firstField.Return_) ;
        }
    }
}