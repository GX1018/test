namespace test0111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory= new Inventory();
            EquipItem equipItem = new EquipItem();

            Console.WriteLine(EquipItem.name[0]);
            
            //인벤토리에 아이템 추가
            inventory.AddNewItem(EquipItem.name[0], 1);

            //인벤토리 아이템 확인
            Console.WriteLine("1. 인벤토리 아이템 확인 : {0}", Inventory.itemName[0]);

            //장착전 장비 슬롯 확인
            Console.WriteLine("2. 장착전 장비 슬롯 확인 : {0}", EquipItemSlot.equipItemSlot[0]);

            //아이템 장착
            EquipItemSlot.equipItemSlot[0] = Inventory.itemName[0];

            //장착후 슬록 확인
            Console.WriteLine("3. 장착후 장비 슬롯 확인 : {0}",EquipItemSlot.equipItemSlot[0]);

            //장착한 아이템 인벤토리에서 제거
            inventory.RemoveItem(EquipItem.name[0]);

            //인벤토리 창 확인
            Console.WriteLine("4. 장착한 아이템 제거됬는지 확인 : {0}", Inventory.itemName[0]);




        }
    }
}