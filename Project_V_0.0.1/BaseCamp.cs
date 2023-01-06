using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_V_0._0._1
{
    internal class BaseCamp
    {
        public void SelectAction()
        {
            StaticClass.screenSize[5, 5] = "다음 행동을 선택하세요";

            StaticClass.screenSize[10, 8] = "1. 상점으로 이동";

            StaticClass.screenSize[12, 8] = "2. 성당으로 이동";

            StaticClass.screenSize[14, 8] = "3. 길드로 이동";

            StaticClass.screenSize[16, 8] = "4. 필드로 나간다";


            StaticClass.screenSize[10, 6] = "▶";
            Screen.PrintScreen();

        }
    }
}
