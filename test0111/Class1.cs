using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0111
{
    public class Inventory
    {
        public static List<string> itemName = new List<string>();//10칸

        public static List<int> itemCount = new List<int>();



        public void AddNewItem(string item, int cnt)
        {
            itemName.Add(item);
            itemCount.Add(cnt);
        }

        public void AddItemCount(string item)
        {
            itemCount[itemName.IndexOf(item)] += 1;
        }

        public void RemoveItem(string item) 
        {
            itemName.RemoveAt(itemName.IndexOf(item));
            itemCount.RemoveAt(itemName.IndexOf(item));
        }
    }



    public class EquipItem
    {
        public static List<string> name = new List<string>();
        public static List<int> value = new List<int>();
        public static List<int> type = new List<int>();
        public static List<int> attack = new List<int>();
        public static List<int> mattack = new List<int>();
        public static List<int> def = new List<int>();
        public static List<int> mdef = new List<int>();
        public static List<int> dex = new List<int>();

        public EquipItem()
        {
            //list 0  item1

            name.Add("가죽 후드");
            value.Add(10);
            type.Add(0);
            attack.Add(0);
            mattack.Add(0);
            def.Add(3);
            mdef.Add(0);
            dex.Add(1);

            name.Add("가죽 조끼");
            value.Add(12);
            type.Add(1);
            attack.Add(0);
            mattack.Add(0);
            def.Add(4);
            mdef.Add(0);
            dex.Add(1);

            name.Add("낡은 검");
            value.Add(12);
            type.Add(2);
            attack.Add(3);
            mattack.Add(0);
            def.Add(0);
            mdef.Add(0);
            dex.Add(0);
        }
    }
}
