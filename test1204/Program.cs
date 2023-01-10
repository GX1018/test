using System;

namespace test1204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory= new Inventory();
            Class2 class2 = new Class2();

            class2.test1(inventory);
            class2.test2(inventory);

            foreach(string item in inventory.itemName)
            {
                Console.WriteLine(item);
            }

            Inventory inventory1 = new Inventory();
            foreach (string item in inventory1.itemName)
            {
                Console.WriteLine(item);
            }
        }
    }
}