using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1204
{
    public class Class2
    {
        public void test1(Inventory inventory)
        {
            inventory.itemName.Add("item1");
            inventory.itemCount.Add(1);
        }

        public void test2(Inventory inventory)
        {
            inventory.itemName.Add("item2");
            inventory.itemCount.Add(2);

        }
    }
}
