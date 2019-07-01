using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGame.Model
{
    public class Player
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int AttackPoint { get; set; }
        public int DefensePoint { get; set; }
        public int CurrentExp { get; set; }
        public int Level { get; set; }
        public int ExpNeeded
        {
            get
            {
                return Level * 10;
            }



        }
        public int PotionAmount { get; set; }
    }
}