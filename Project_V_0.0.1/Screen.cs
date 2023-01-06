using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_V_0._0._1
{
    public class Screen
    {
        public void sizeCheck()
        {
            for(int height = 0; height < StaticClass.screenSize.GetLength(0); height++)
            {
                for(int width = 0; width < StaticClass.screenSize.GetLength(1); width++)
                {
                    if(width == 0||width == StaticClass.screenSize.GetLength(1)-1)
                    {
                        StaticClass.screenSize[height, width] = "││";
                    }
                    else if (height == 0 || height == StaticClass.screenSize.GetLength(0) - 1 )
                    {
                        StaticClass.screenSize[height, width] = "━━";
                    }
                    else
                    {
                        StaticClass.screenSize[height, width] = "  ";
                    }
                }
            }
        }

        public static void PrintScreen()
        {
            for (int height = 0; height < StaticClass.screenSize.GetLength(0); height++)
            {
                for (int width = 0; width < StaticClass.screenSize.GetLength(1); width++)
                {
                    Console.Write(StaticClass.screenSize[height, width]);
                }
                Console.WriteLine();
            }
        }

        public void TitleGameName()
        {
            for (int height = 5; height < StaticClass.screenSize.GetLength(0)-20; height++)
            {
                for (int width = 10; width < StaticClass.screenSize.GetLength(1)-10; width++)
                {
                    StaticClass.screenSize[height, width] = "□";
                }
            }
        }
        public void TitlePressButton()
        {
            for (int height = 27; height < StaticClass.screenSize.GetLength(0) - 8; height++)
            {
                for (int width = 30; width < StaticClass.screenSize.GetLength(1) - 30; width++)
                {
                    StaticClass.screenSize[height, width] = "□";
                }
            }
        }

        public void TitlePressButton_1()
        {
            for (int height = 27; height < StaticClass.screenSize.GetLength(0) - 8; height++)
            {
                for (int width = 30; width < StaticClass.screenSize.GetLength(1) - 30; width++)
                {
                    StaticClass.screenSize[height, width] = "  ";
                }
            }
        }
    }
}
