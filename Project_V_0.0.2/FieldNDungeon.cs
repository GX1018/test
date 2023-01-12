using Project_V_0._0._1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static Project_V_0._0._2.FirstField;

namespace Project_V_0._0._2
{
    public class BaseFieldNDungeon
    {
        string search = "탐색한다";
        string return_ = "돌아간다";
        string useItem = "아이템 사용";
        protected string nextCamp = "다음 캠프로";


        public string Search
        {
            get { return search; }
        }
        public string Return_
        {
            get { return return_; }
        }
        public string UseItem
        {
            get { return useItem; }
        }
        public string NextCamp
        {
            get { return nextCamp; }
        }
    }

    class FirstField : BaseFieldNDungeon
    {
        public FirstField()
        {
            string goToDungeon;
            string event1;
            string event2;
            this.nextCamp = "[Camp No.2_NoName]으로 이동";
        }
        

        Battle battle = new Battle();
        Screen screen= new Screen();
        Inventory inventory= new Inventory();

        public void selectAction()
        {
            loop:
            Console.Clear();
            FirstField firstField = new FirstField();
            Console.WriteLine("[FirstFieldName]\n\n\n 1. {0}\n\n 2. {1}\n\n 3. {2}\n\n 4. {3}", firstField.Search, firstField.NextCamp, firstField.Return_, firstField.UseItem) ;

            string inputNum = Console.ReadLine();
            switch (inputNum)
            {
                case "1":
                    Random random = new Random();
                    int dice = random.Next(1, 11);

                    if (dice <= 9)
                    {
                        battle.incount();

                        battle.BattlePhase();

                        goto loop;


                    }
                    else if (dice > 9)
                    {
                        //이벤트
                        battle.incount();

                        battle.BattlePhase();
                        goto loop;

                        //이벤트 작성 후 수정
                    }
                    break;
                case "2":
                    if(BaseSetting.field1BossClear == true)
                    {
                        Console.WriteLine("다음 구역으로 이동합니다.");
                    }
                    else if (BaseSetting.field1BossClear == false)
                    {

                        Console.WriteLine("다음 구역으로 이동하시겠습니까? [Y/N]\n\n[System] 강한 적과 전투를 진행 합니다.");
                        string inputYN = Console.ReadLine();
                        if( inputYN=="Y"|| inputYN == "y")
                        {
                            BaseSetting.monster = 9;
                            battle.BattlePhase();
                        }
                        else if (inputYN == "N" || inputYN == "n")
                        {
                            goto loop;
                        }
                    }
                    break;
                case "3":
                    BaseSetting.returnCheck = false;
                    break;
                case "4":
                    Console.WriteLine("사용하실 아이템을 선택하세요[0~9]\n[10] : 돌아가기");
                    screen.InventoryScreen();
                    int inputUseItem = int.Parse(Console.ReadLine());

                    if (BaseSetting.returnCheck == false)
                    {
                        break;
                    }
                    else
                    {
                        goto loop;
                    }
                default:
                    goto loop;
            }
        }

        Item Item = new Item();
        EtcItem etcItem = new EtcItem();
        public class Monster1_Field1 : Monster
        {
            public Monster1_Field1()
            {
                this.name = "슬라임";

                this.exp = 5;

                this.hp = 20;

                this.attack = 5;

                this.dex = 0;
                this.haveDropItem1 = 1;
                this.dropItem1 = "슬라임의 체액";       //5 EtcItem.etcItem[0]; //


                this.haveDropItem2 = 1;
                //this.dropItem2 = EtcItem.etcItem[1];        //2     //drop nothing 3
                this.dropItem2 = "슬라임의 핵";        //2     //drop nothing 3


            }

                public int diceItem1 = 5;
                public int diceItem2 = 3;

        }
        public class Monster2_Field1 : Monster
        {
            public Monster2_Field1()
            {
                this.name = "늑대";

                this.exp = 7;

                this.hp = 30;

                this.attack = 8;

                this.def = 3;

                this.dex = 0;

                //3
            }
        }

        public class MonsterBoss_Field1 : Monster
        {
            public MonsterBoss_Field1()
            {
                this.name = "FIELD1_BOSS_NONAME";

                this.exp = 100;

                this.hp = 100;

                this.attack = 12;

                this.def = 5;

                this.dex = 0;

                //3
            }
        }

    }
    class Battle
    {
        MonsterBoss_Field1 field1Boss = new MonsterBoss_Field1();
        Player player = new Player();
        Inventory inventory = new Inventory();
        Screen screen = new Screen();

        public void incount()
        {
            Random random = new Random();
            int dice = random.Next(1, 11);
            if (dice <= 7)
            {
                BaseSetting.monster = 1;
            }
            else if (dice > 7)
            {
                BaseSetting.monster = 2;
            }
        }

        public void BattlePhase()
        {
            if (BaseSetting.monster == 1)
            {
                incount1();
            }
            else if (BaseSetting.monster == 2)
            {
                incount2();
            }
            else if (BaseSetting.monster == 9)
            {
                incount9(field1Boss);
            }
        }
        public void incount1()
        {
            Monster1_Field1 slime = new Monster1_Field1();

            Console.WriteLine("{0}을 만났습니다", slime.name);
            bool escapeCheck = true;
            while (player.currentHp > 0 && slime.hp > 0 && escapeCheck == true)
            {

                Console.Clear();
                Screen.InBattle();
                Console.WriteLine("PLAYER TURN");
                Console.WriteLine("PLAYER H.P. : [{0}]\n{1} H.P. : [{2}]", player.currentHp, slime.name, slime.hp);
                Screen.InBattle_1();
                string inputNum = Console.ReadLine();
                switch (inputNum)
                {
                    case "1":
                        slime.hp -= (player.attack - slime.def);
                        break;
                    case "2":
                    //미구현
                    case "3":
                        player.def += player.def;
                        break;
                    case "4":
                        screen.InventoryScreen();
                        Console.WriteLine("사용하실 아이템을 선택하세요[0~9]\n[10] : 돌아가기");
                        int inputUseItem = int.Parse(Console.ReadLine());
                        break;
                    case "5":
                        Random random = new Random();
                        int escape = random.Next(0, player.dex + slime.dex);
                        if (escape < player.dex)
                        {
                            escapeCheck = false;
                            Console.WriteLine("도망 성공");
                            goto run;
                        }
                        break;
                }

                if (slime.hp > 0)
                {
                    Console.WriteLine("{0} TURN", slime.name);
                    if (player.def >= slime.attack)
                    {
                        player.currentHp -= 1;
                    }
                    else if (player.def < slime.attack)
                    {
                        player.currentHp -= (slime.attack - player.def);
                    }
                }
                else if (slime.hp <= 0)
                {
                    player.exp += slime.exp;
                    Console.WriteLine("EXP {0}를 획득했습니다", slime.exp);

                    Random random = new Random();
                    int dropItem = random.Next(10);
                    if (dropItem < slime.diceItem1)
                    {
                        Console.WriteLine("ITEM {0}를 획득했습니다", slime.dropItem1);
                        Console.ReadKey();
                    //
                    itemGain:
                        if (Inventory.itemName.Count < 10)
                        {
                            if (Inventory.itemName.IndexOf(slime.dropItem1) == -1)
                            {
                                inventory.AddNewItem(slime.dropItem1, slime.haveDropItem1);
                                
                                //Inventory.itemName.Add(slime.dropItem1);
                                slime.haveDropItem1 = 1;
                                //Inventory.itemCount.Add(slime.haveDropItem1);
                            }
                            else if (!(Inventory.itemName.IndexOf(slime.dropItem1) == -1))
                            {
                                inventory.AddItemCount(slime.dropItem1, slime.haveDropItem1);
                                //Inventory.itemCount[Inventory.itemName.IndexOf(slime.dropItem1)] += 1;
                                slime.haveDropItem1++;
                            }
                            else { }
                        }
                        else
                        {
                            screen.InventoryScreen();
                            Console.WriteLine("버리실 아이템을 선택하세요");
                            int itemNumber = int.Parse(Console.ReadLine());
                            Inventory.itemName.RemoveAt(itemNumber - 1);
                            Inventory.itemCount.RemoveAt(itemNumber - 1);
                            goto itemGain;
                        }
                        screen.InventoryScreen();

                        Console.ReadKey();
                        //함수로 변환하기
                    }
                    else if (slime.diceItem1 <= dropItem && dropItem < slime.diceItem1 + slime.diceItem2)
                    {
                    itemGain:
                        if (Inventory.itemName.Count < 10)
                        {
                            if (Inventory.itemName.IndexOf(slime.dropItem2) == -1)
                            {
                                Inventory.itemName.Add(slime.dropItem2);
                                Inventory.itemCount.Add(slime.haveDropItem2);
                                Console.WriteLine("ITEM {0}를 획득했습니다", slime.dropItem2);
                            }
                            else if (!(Inventory.itemName.IndexOf(slime.dropItem2) == -1))
                            {
                                Inventory.itemCount[Inventory.itemName.IndexOf(slime.dropItem2)] += 1;
                                slime.haveDropItem2++;
                            }
                            else { }

                            for (int index = 0; index < Inventory.itemName.Count; index++)
                            {
                                Console.WriteLine("{2}. {0}  X {1}", Inventory.itemName[index],
                                    Inventory.itemCount[index], index + 1);
                            }

                            Console.ReadKey();
                        }
                        else
                        {
                            screen.InventoryScreen();
                            Console.WriteLine("버리실 아이템을 선택하세요");
                            int itemNumber = int.Parse(Console.ReadLine());
                            Inventory.itemName.RemoveAt(itemNumber - 1);
                            Inventory.itemCount.RemoveAt(itemNumber - 1);
                            goto itemGain;
                        }
                    }
                    else
                    {
                        Console.ReadKey();
                    }


                }


                if (inputNum == "3")
                {
                    player.def = player.def / 2;
                }
            run:;
                escapeCheck = true;
            }
        }

        public void incount2()
        {
            Monster2_Field1 wolf = new Monster2_Field1();
            Console.WriteLine("{0}을 만났습니다", wolf.name);
            bool escapeCheck = true;
            while (player.currentHp > 0 && wolf.hp > 0 && escapeCheck == true)
            {
                Console.Clear();
                Screen.InBattle();
                Console.WriteLine("PLAYER TURN");
                Console.WriteLine("PLAYER H.P. : [{0}]\n{1} H.P. : [{2}]", player.currentHp, wolf.name, wolf.hp);
                Screen.InBattle_1();
                string inputNum = Console.ReadLine();
                switch (inputNum)
                {
                    case "1":
                        wolf.hp -= (player.attack - wolf.def);
                        break;
                    case "2":
                    //미구현
                    case "3":
                        player.def += player.def;
                        break;
                    case "4":
                        screen.InventoryScreen();
                        Console.WriteLine("사용하실 아이템을 선택하세요[0~9]\n[10] : 돌아가기");
                        int inputUseItem = int.Parse(Console.ReadLine());
                        break;
                    case "5":
                        Random random = new Random();
                        int escape = random.Next(0, player.dex + wolf.dex);
                        if (escape < player.dex)
                        {
                            escapeCheck = false;
                            Console.WriteLine("도망 성공");
                            goto run;
                        }
                        break;
                }

                if (wolf.hp > 0)
                {
                    Console.WriteLine("{0} TURN", wolf.name);
                    if (player.def >= wolf.attack)
                    {
                        player.currentHp -= 1;
                    }
                    else if (player.def < wolf.attack)
                    {
                        player.currentHp -= (wolf.attack - player.def);
                    }
                }
                else if (wolf.hp <= 0)
                {
                    player.exp += wolf.exp;
                    Console.WriteLine("EXP {0}를 획득했습니다", wolf.exp);
                }


                if (inputNum == "3")
                {
                    player.def = player.def / 2;
                }
                escapeCheck = true;
            run:;

            }
        }


        public void incount9(MonsterBoss_Field1 field1Boss)
        {
            Console.WriteLine("{0}을 만났습니다", field1Boss.name);
            bool escapeCheck = true;
            while (player.currentHp > 0 && field1Boss.hp > 0 && escapeCheck == true)
            {
                Console.Clear();
                Screen.InBattle();
                Console.WriteLine("PLAYER TURN");
                Console.WriteLine("PLAYER H.P. : [{0}]\n{1} H.P. : [{2}]", player.currentHp, field1Boss.name, field1Boss.hp);
                Screen.InBattle_1();
                string inputNum = Console.ReadLine();
                switch (inputNum)
                {
                    case "1":
                        field1Boss.hp -= (player.attack - field1Boss.def);
                        break;
                    case "2":
                    //미구현
                    case "3":
                        player.def += player.def;
                        break;
                    case "4":
                        screen.InventoryScreen();
                        Console.WriteLine("사용하실 아이템을 선택하세요[0~9]\n[10] : 돌아가기");
                        int inputUseItem = int.Parse(Console.ReadLine());
                        break;
                    case "5":
                        Random random = new Random();
                        int escape = random.Next(0, player.dex + field1Boss.dex);
                        if (escape < player.dex)
                        {
                            escapeCheck = false;
                            Console.WriteLine("도망 성공");
                            goto run;
                        }
                        break;
                }

                if (field1Boss.hp > 0)
                {
                    Console.WriteLine("{0} TURN", field1Boss.name);
                    if (player.def >= field1Boss.attack)
                    {
                        player.currentHp -= 1;
                    }
                    else if (player.def < field1Boss.attack)
                    {
                        player.currentHp -= (field1Boss.attack - player.def);
                    }
                }
                else if (field1Boss.hp <= 0)
                {
                    player.exp += field1Boss.exp;
                    Console.WriteLine("EXP {0}를 획득했습니다", field1Boss.exp);
                    BaseSetting.field1BossClear = true;
                }

                if (inputNum == "3")
                {
                    player.def = player.def / 2;
                }
                escapeCheck = true;
            run:;

            }
        }

        public void ItemRoot(Monster1_Field1 slime)
        {
            Random random = new Random();
            int dropItem = random.Next(10);
            if (dropItem < slime.diceItem1)
            {

            }
        }

    }
}
