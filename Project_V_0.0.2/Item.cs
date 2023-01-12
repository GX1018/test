using Project_V_0._0._1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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


    public class UseItem
    {
        public static List<string> name = new List<string>();
        public static List<string> text = new List<string>();
        public static List<int> value = new List<int>();
        public static List<int> effect = new List<int>();
        public UseItem()
        {
            name.Add("Hp 회복 물약");
            text.Add("최대 HP의 25%를 회복한다.");
            value.Add(20);
            effect.Add(0);

            name.Add("Mp 회복 물약");
            text.Add("최대 MP의 50%를 회복한다.");
            value.Add(30);
            effect.Add(1);

            name.Add("귀환의 깃털");
            text.Add("마지막으로 방문한 마을로 돌아간다.");
            value.Add(100);
            effect.Add(9);
        }


        public void ItemEffect(int effect, Player player)
        {
            if(effect == 0)
            {
                player.currentHp += player.maxHp * 1 / 4;
                if (player.currentHp > player.maxHp)
                {
                    player.currentHp = player.maxHp;
                }
            }

            else if (effect == 1)
            {
                player.currentMp += player.maxMp * 1 / 2;
                if (player.currentMp > player.maxMp)
                {
                    player.currentMp = player.maxMp;
                }
            }

            else if (effect == 9)
            {
                BaseSetting.returnCheck = false;
            }
        }
    }







}
