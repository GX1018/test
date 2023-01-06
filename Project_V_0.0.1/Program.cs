using System;
using System.Threading.Tasks;

namespace Project_V_0._0._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen();
            CharacterMaking characterMaking = new CharacterMaking();
            Player player = new Player();
            BaseCamp baseCamp = new BaseCamp();


            screen.sizeCheck();
            screen.TitleGameName();
            
            Thread.Sleep(500);
            screen.TitlePressButton_1();
            Screen.PrintScreen();
            Thread.Sleep(500);
            Console.Clear();                        //나중에 blank적용
            
            screen.TitlePressButton();
            Screen.PrintScreen();
            //Thread.Sleep(500);
            
            Console.ReadKey();
            Console.Clear();

            screen.sizeCheck();
            characterMaking.Selectjob();
            characterMaking.SelectJob3();
            Console.Clear();

            player.JobStatusApply();
            Console.WriteLine("hp {0}\nmp {1}\nstr {2}\nint {3}\ndex {4}", player.hp, player.mp, player.str, player.int_, player.dex);
            Console.ReadKey();

            screen.sizeCheck();
            baseCamp.SelectAction();




            //뼈대만 남기고 잡스러운 것들 삭제



        }
    }
}