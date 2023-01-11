using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_V_0._0._2
{
    public class Item
    {
        public string name;
        public int value;
    }

    public class EtcItem : Item
    {
            
    }

    public class EtcItemNo1 : EtcItem
    {
        public EtcItemNo1()
        {
            this.name = "슬라임의 체액";
            this.value = 8;
        }
    }
    public class EtcItemNo2 : EtcItem
    {
        public EtcItemNo2()
        {
            this.name = "슬라임의 핵";
            this.value = 12;
        }
    }
    public class EtcItemNo3 : EtcItem
    {
        public EtcItemNo3()
        {
            this.name = "늑대의 송곳니";
            this.value = 15;
        }
    }
    public class EtcItemNo4 : EtcItem
    {
        public EtcItemNo4()
        {
            this.name = "늑대 가죽";
            this.value = 15;
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
