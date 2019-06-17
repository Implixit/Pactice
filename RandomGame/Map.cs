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
        public Battle CurrentEnemy;
        bool enemyAlive;
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
            int Enemyhp;

            Random random = new Random();
            if (enemyAlive == true)
            {
                Enemyhp = BattleFunction();
            }
            else
            {
                //create a new enemy
                Battle Calucation = new Battle()
                {
                    Name = "Name " + random.Next(0, 10),
                    AttackPoint = random.Next(1, 20),
                    DefensePoint = random.Next(1, 20),
                    HP = random.Next(20, 25)
                };
                CurrentEnemy = Calucation;
                Enemyhp = BattleFunction();
            }
            if (Enemyhp <= 0)
            {
                MessageBox.Show("Enemy Die!");
                //check control in the panel
                // Clear enemy infomration
                foreach (Control txt in panel1.Controls.Cast<Control>())
                {
                    //control that is label + design name have enemy  in panel1 will clear
                    if (txt is Label && txt.Name.Contains("enemy"))
                    {
                        txt.Text = "";
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Enemy still have HP!");
                // enemy still have HP
                enemyAlive = true;
            }
            
            

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
                if (damage <= 0)
                {
                    damage = 0;
                }
                hp = player.HP - damage;
            }
            else
            {
                //plyaer attack enemy
                damage = player.AttackPoint - battle.DefensePoint;
                if (damage <= 0)
                {
                    damage = 0;
                }
                hp = battle.HP - damage;               
            }
            if (hp <=0)
            {
                hp = 0;
            }                        
            //key is damage, value is hp
            return new KeyValuePair<int, int>(damage, hp);
        }
        private int BattleFunction()
        {
            // Show information about enemy 
            enemyName.Text = CurrentEnemy.Name;
            enemyAttack.Text = CurrentEnemy.AttackPoint.ToString();
            enemyDefense.Text = CurrentEnemy.DefensePoint.ToString();
            enemyHP.Text = CurrentEnemy.HP.ToString();

            //Side = true  mean enemy attack player
            var result = BattleCalculation(CurrentEnemy, CurrentPlay, true);

            MessageBox.Show("You get " + result.Key + " Damage");
            CurrentPlay.HP = result.Value;
            HPpoint.Text = CurrentPlay.HP.ToString();

            // player attack enemy
            result = BattleCalculation(CurrentEnemy, CurrentPlay, false);
            MessageBox.Show("You deal " + result.Key + " Damage");
            CurrentEnemy.HP = result.Value;
            enemyHP.Text = CurrentEnemy.HP.ToString();
            //return enemy HP
            return CurrentEnemy.HP;
        }

    }
}
