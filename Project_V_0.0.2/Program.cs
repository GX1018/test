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

            screen.Title();
            characterMaking.Selectjob();
            player.JobStatusApply();

            Console.Clear();
            Console.WriteLine("hp {0}\nmp {1}\nstr {2}\nint {3}\ndex {4}", player.hp, player.mp, player.str, player.int_, player.dex);

        }
    }
}