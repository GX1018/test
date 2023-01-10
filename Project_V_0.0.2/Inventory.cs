using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_V_0._0._2
{
    public class Inventory
    {
        public static List<string> itemName = new List<string>();//10칸

        public static List<int> itemCount= new List<int>();

        public void AddNewItem(string item, int cnt)
        {
            itemName.Add(item);
            itemCount.Add(cnt);
        }

        public void AddItemCount(string item, int cnt)
        {
            itemCount[itemName.IndexOf(item)] += 1;
        }
    }
}
