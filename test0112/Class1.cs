using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0112
{
    internal class test1
    {
        public void FirstFloor()
        {
            string[,] testArray = new string[10, 10];

            for (int index = 0; index < testArray.GetLength(0); index++)
            {
                for (int index_ = 0; index_ < testArray.GetLength(1); index_++)
                {
                    if (index == 0 || index == testArray.GetLength(0) - 1)
                    {
                        testArray[index_, index] = "■";
                    }
                    else if (index_ == 0 || index_ == testArray.GetLength(1) - 1)
                    {
                        testArray[index_, index] = "■";
                    }
                    else
                    {
                        testArray[index_, index] = "  ";
                    }
                }
            }

            testArray[6, 1] = "■";

            testArray[1, 2] = "◎";
            testArray[2, 2] = "■";
            testArray[3, 2] = "■";
            testArray[4, 2] = "■";
            testArray[6, 2] = "■";
            testArray[7, 2] = "■";



            testArray[2, 9] = "▣";
            testArray[7, 0] = "▣";



            PrintLavi(testArray);
        }

        public void PrintLavi(string[,] arrayName)
        {
            for (int index = 0; index < arrayName.GetLength(0); index++)
            {
                for (int index_ = 0; index_ < arrayName.GetLength(1); index_++)
                {
                    Console.Write(arrayName[index_, index]);
                }
                Console.WriteLine();
            }
        }

    }
}
