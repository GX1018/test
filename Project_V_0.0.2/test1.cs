﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project_V_0._0._2
{
    internal class test1
    {
        //public string[,] testArray = new string[10, 10];

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

            testArray[2, 9] = "▣";
            testArray[7, 0] = "▣";






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








































        ///selecAction에서 inventorySelcet//이거를 equipselect case 안에////
    }
}
