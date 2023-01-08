using Project_V_0._0._1;
using System.Numerics;

namespace Project_V_0._0._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen();
            CharacterMaking characterMaking = new CharacterMaking();
            Player player= new Player();

            Town1 town1 = new Town1();

            screen.Title();

            while (BaseSetting.loopCheck)
            {
                characterMaking.Selectjob();
                player.JobStatusApply();

                Console.Clear();
                characterMaking.ConfirmedJobSelect(player);
            }
            BaseSetting.loopCheck = true;


            Console.Clear();
            screen.GameStartScreen();
            
            Console.Clear();
            screen.town1screen(town1);

            while (BaseSetting.loopCheck)
            {
                town1.selectAction();
                Console.Clear();
                screen.town1screen(town1);
            }
            BaseSetting.loopCheck = true;

            Console.Clear();

            town1.GoNext();

            screen.FirstField();



            Console.ReadKey();
        }
    }
}