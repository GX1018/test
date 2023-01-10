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


            Console.Clear();
            screen.GameStartScreen();

            returnTown://
            screen.enterTown1(town1);
            BaseSetting.returnCheck = true;
            Console.Clear();

            while (BaseSetting.loopCheck)
            {
                town1.Town1Main();
                Console.Clear();
            }
            BaseSetting.loopCheck = true;

            //town1.GoNext();

            fieldmain:

            //보스 클리어 체크용//
            BaseSetting.field1BossClear = false;
            //보스 클리어 체크용//

            firstField.selectAction();

            if (BaseSetting.returnCheck == false)
            {
                goto returnTown;// 마을로 이동
            }

            if(BaseSetting.field1BossClear == false)
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