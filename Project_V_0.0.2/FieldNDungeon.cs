using Project_V_0._0._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_V_0._0._2
{
    public class BaseFieldNDungeon
    {
        string search = "탐색한다";
        string return_ = "돌아간다";

        public string Search
        {
            get { return search; }
            set { search = value; }
        }
        public string Return_
        {
            get { return return_; }
            set { return_ = value; }
        }
    }

    class FirstField : BaseFieldNDungeon
    {
        string goToDungeon;
        string event1;
        string event2;
    }

    class Monster1_Field1 : MonsterStatus
    {
        public Monster1_Field1()
        {
            this.name = "슬라임";

            this.exp = 5;

            this.hp = 20;

            this.attack = 5;

        }
    }

    class Battle
    {

    }
}
