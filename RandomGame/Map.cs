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
            //enemy attack player
            Battle Calucation = new Battle()
            {
                Name = "Name" + random.Next(0, 10),
                AttackPoint = random.Next(1, 20),
                DefensePoint = random.Next(1, 20),
                HP = random.Next(20, 100)
            };
            //Side = true  mean enemy attack player
            var result = BattleCalculation(Calucation, CurrentPlay, true);

            MessageBox.Show("You get " + result.Key + " Damage");
            CurrentPlay.HP = result.Value;
            HPpoint.Text = CurrentPlay.HP.ToString();
            // player attack enemy
            result = BattleCalculation(Calucation, CurrentPlay, false);
            MessageBox.Show("You deal " + result.Key + " Damage");


        }
        private KeyValuePair<int, int> BattleCalculation(Battle battle, Player player, bool Side)
        // true = enemy attack player   false = player -> enemy
        {
            int hp;
            int damage;
            if (Side)//side == true
            {
                //enemy attack player
                damage = battle.AttackPoint - player.DefensePoint;
                hp = player.HP - damage;
            }
            else
            {
                //plyaer attack enemy
                damage = player.AttackPoint - battle.DefensePoint;
                hp = battle.HP = damage;
            }
            //key is damage, value is hp
            return new KeyValuePair<int, int>(damage, hp);



        }


    }
}
