using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGame.Model
{
    public class Battle
    {
        public int ID { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public int HP { get; set; }
        public int AttackPoint { get; set; }
        public int DefensePoint { get; set; }
        
        public int Exp
        {
            get
            {
                Random r = new Random();
                double Exp = r.Next(1,Level) * 5;

                return Convert.ToInt32(Exp);// Round the Exp
            }
        }
    }
}
