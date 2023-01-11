using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Project_V_0._0._2.Player;
using static System.Formats.Asn1.AsnWriter;

namespace Project_V_0._0._2
{
    internal class Screen
    {
        //Town1 town1 = new Town1();

        public void Title()
        {
            Console.WriteLine("GAME TITLE");

            Console.WriteLine("PRESS ENTER");

            Console.ReadKey();
        }

        public void SelectJobScreen()
        {
            Console.Clear();
            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine();
            Console.WriteLine(" 1. FIGHTER");
            Console.WriteLine(" 2. MAGE");
            Console.WriteLine(" 3. ROUGE");
        }

        public void ConfirmedJobSelectScreen(Player player)
        {
            Console.WriteLine("선택하신 직업 : {0}", player.job);
            Console.WriteLine();
            Console.WriteLine("hp {0}\nmp {1}\nstr {2}\nint {3}\ndex {4}", player.maxHp, player.mp, player.str, player.int_, player.dex);
            Console.WriteLine("attack {0}\ndef {1}", player.attack, player.def);
            Console.WriteLine("\n결정 하시겠습니까? [Y/N]");
        }

        public void GameStartScreen()
        {
            Console.WriteLine("[GAME START]\n[스킵하시려면 아무 키나 누르세요]");

            Task.Delay(1000).Wait();
            Console.WriteLine("스토리 설명1");//delay 한줄씩 출력
            Task.Delay(1000).Wait();
            Console.WriteLine("스토리 설명2");//delay 한줄씩 출력
            Task.Delay(1000).Wait();
            Console.WriteLine("스토리 설명3");//delay 한줄씩 출력
            Task.Delay(1000).Wait();

            Console.WriteLine("PRESS ANY KEY");
            Console.ReadKey();//스킵기능 미구현
        }

        public void enterTown1(Town1 town1)
        {
            Console.Clear();
            Task.Delay(1000).Wait();
            Console.WriteLine(town1.campName);
            Task.Delay(1000).Wait();
            Console.Clear();
        }
        

        public void town1screen(Town1 town1)
        {
            Console.WriteLine(town1.campName);
            Console.WriteLine();
            //
            Console.WriteLine("1. 상점");
            Console.WriteLine("2. 교회");
            Console.WriteLine("3. 길드");
            Console.WriteLine("4. 필드");
            
            Console.WriteLine("8. 스테이터스");//
            Console.WriteLine("9. 장비");
            Console.WriteLine("0. 인벤토리");       
            //

            //
            //for (int y = 0; y < town1.choice.GetLength(1); y++)
            //{
            //    for (int x = 0; x < town1.choice.GetLength(0); x++)
            //    {
            //        Console.Write(town1.choice[x, y]);
            //    }
            //    Console.WriteLine();
            //}
        }


        public static void GoToField()
        {
            Console.WriteLine();

            Task.Delay(1000).Wait();
            Console.WriteLine("[Field1Name]");//delay 한줄씩 출력
            Task.Delay(1000).Wait();
            Console.Clear();
        }



        public static void InBattle()
        {
            Console.WriteLine("IMAGE"/*이미지 출력*/);
            Console.WriteLine("IMAGE"/*이미지 출력*/);
            Console.WriteLine("IMAGE"/*이미지 출력*/);
            Console.WriteLine("IMAGE"/*이미지 출력*/);
        }
        public static void InBattle_1()
        { 
            Console.WriteLine("1. ATTACK");
            Console.WriteLine("2. SKILL");
            Console.WriteLine("3. DEFENCE");
            Console.WriteLine("4. ITEM");
            Console.WriteLine("5. RUN");
        }
        //Inventory inventory = new Inventory();

        //기본 인벤토리 -> 입력 추가
        public void InventoryScreen()
        {

            for (int index = 0; index < Inventory.itemName.Count; index++)
            {
                //Console.WriteLine("{2}. {0}  X {1}", Inventory.itemName[index],
                //    Inventory.itemCount[index], index + 1);       수정전
                Console.WriteLine(" {0}  X {1}", Inventory.itemName[index], Inventory.itemCount[index]);
            }
            Console.WriteLine("─────────────────────────────────");
            Console.WriteLine("─────────────────────────────────");
            Console.WriteLine(" 1 . 장비하기");
            Console.WriteLine(" 2 . 아이템 사용");
            Console.WriteLine(" 0 . 돌아가기");
        }

        public void CurrentEquipment()
        {
            Console.WriteLine("장착 중인 장비");
            
            for (int index = 0; index< Player.EquipItemSlot.equipItemSlot.Length; index++)
            {
                if (!(Player.EquipItemSlot.equipItemSlot[index] == null))
                {
                    Console.WriteLine(Player.EquipItemSlot.equipItemSlot[index]);
                }
                else if(Player.EquipItemSlot.equipItemSlot[index] == null)
                {
                    Console.WriteLine("NO ITEM");
                }
            }
        }
        
        
        public void EquipItemScreen()
        {
            Console.WriteLine(" 1 . 투구");
            Console.WriteLine(" 2 . 갑옷");
            Console.WriteLine(" 3 . 무기/방패");
            Console.WriteLine(" 4 . 장신구");
            Console.WriteLine(" 0. 돌아가기");
        }

        //
        //EquipItemscreen
        //
        //

        EquipItem equipItem = new EquipItem();
        public void HaveEquipmet(int input)
        {
            Console.Clear();
            Console.WriteLine("보유 중인 장비");

            //인벤토리 index0~보유index 
            for (int index = 0; index < Inventory.itemName.Count; index++)
            {
                if (!(EquipItem.name.IndexOf(Inventory.itemName[index]) == -1) && EquipItem.type[EquipItem.name.IndexOf(Inventory.itemName[index])] == input-1)
                {
                    Console.WriteLine("{0}. {1}", index, Inventory.itemName[index]);
                    // inventory itemName[index] >> 0번째 인덱스 -> 0. 아이템 네임// 8번째 인덱스 ->8. 아이템 네임/// 차후 출력되는 index 입력<<<
                }
            }
        }



        public void Town1building(Town1 town1)
        {
            if (town1.choice[0, 0] == "▶")
            {
                Console.Clear();
                StoreScreen(town1);
                Console.ReadLine();
            }
            else if (town1.choice[0, 1] == "▶")
            {
                //ChurchScreen();
            }
            else if (town1.choice[0, 2] == "▶")
            {
                //GuildScreen();
            }
            else if(town1.choice[0, 3] == "▶")
            {
                town1.GoNext();
            }
        }


        public void StoreScreen(Town1 town1)
        {
            Console.WriteLine("[ {0} ]", town1.store);
            Console.WriteLine();
            Console.WriteLine(" 1. 구입");
            Console.WriteLine(" 2. 판매");
            Console.WriteLine(" 3. 돌아간다");
        }
        public void PlayerEquipScreen()
        {
            Console.WriteLine(Player.EquipItemSlot.equipItemSlot[0]);
            
            //for(int index = 0; index < EquipItemSlot.equipItemSlot.Length; index++)
            //{
            //    Console.WriteLine("{0}. {1}", index+1, EquipItemSlot.equipItemSlot[index]);
            //}
        }


        public void StatusScreen(Player player)
        {
            Console.WriteLine("[PLAYER STATUS]\n\n");
            
            Console.WriteLine($"JOB : {player.job}\n"); 
            Console.WriteLine($"LEVEL : {player.lev}\n");
            Console.WriteLine($"EXP : {player.exp}\n");

            Console.WriteLine($"HP/MAX HP : {player.currentHp}/{player.maxHp}\n");
            Console.WriteLine($"MP : {player.mp}\n");

            Console.WriteLine($"STR : {player.str}\n");
            Console.WriteLine($"INT : {player.int_}\n");
            Console.WriteLine($"DEX : {player.dex}\n");


            Console.WriteLine($"=====================\n");
            Console.WriteLine($"ATT : {player.attack}\n");
            Console.WriteLine($"M.ATT : {player.mattack}\n");
            Console.WriteLine($"DEF : {player.def}\n");
            Console.WriteLine($"M.DEF : {player.m_def}\n");


        }

    }
}