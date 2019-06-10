using RandomGame.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomGame
{
    public partial class Map : Form
    {
        public Player CurrentPlay { get; set; } 
        public Map()
        {      
            InitializeComponent();           
        }
        private void Map_Load(object sender, EventArgs e)
        {
            //information in the page 
            HPpoint.Text = CurrentPlay.HP.ToString();
            AttackPoint.Text = CurrentPlay.AttackPoint.ToString();
            DefensePoint.Text = CurrentPlay.DefensePoint.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random random = new Random();
            Battle Calucation = new Battle()
            {
                Name = "Name" + random.Next(0, 10),
                AttackPoint = random.Next(1, 80),
                DefensePoint = random.Next(1, 20),
                HP = random.Next(20, 100)
            };
            var result = BattleCalculation(Calucation);

            MessageBox.Show("You get " + result.Key + " Damage");
            CurrentPlay.HP = result.Value;
            HPpoint.Text = CurrentPlay.HP.ToString();
        }
        private KeyValuePair<int,int> BattleCalculation(Battle battle)
        {
            int hp;
            int damage;
            damage = battle.AttackPoint - CurrentPlay.DefensePoint;
            hp = CurrentPlay.HP - damage;
            //key is damage, value is hp
            return new KeyValuePair<int, int>(damage,hp);
        }

        
    }
}
