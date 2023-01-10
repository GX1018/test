using Project_V_0._0._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Project_V_0._0._2
{
    internal class CharacterMaking
    {
        Screen screen = new Screen();
        SelectAction selectAction = new SelectAction();
        public void Selectjob()
        {
            uncorrectInput:
            BaseSetting.correctInput = true;

            screen.SelectJobScreen();
            selectAction.SelectJob();
            if(BaseSetting.correctInput == false)
            {
                goto uncorrectInput;
            }

        }
        public void ConfirmedJobSelect(Player player)
        {
            screen.ConfirmedJobSelectScreen(player);
            selectAction.ConfirmedJobSelect(player);
        }

    }
}
