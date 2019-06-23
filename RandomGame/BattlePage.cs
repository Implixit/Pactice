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
    public partial class BattlePage : Form
    {
        public Player CurrentPlay { get; set; }
        public Battle CurrentEnemy { get; set; }
        bool enemyAlive { get; set; }


        public BattlePage()
        {
            InitializeComponent();
        }

        private void BattlePage_Load(object sender, EventArgs e)
        {
            int Enemyhp = CurrentEnemy.HP;
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
                ExpCalucation(CurrentEnemy, CurrentPlay);
                enemyAlive = false;
                
            }
            else
            {
                MessageBox.Show("Enemy still have HP!");

                // enemy still have HP
                enemyAlive = true;
            }
        }
        #region Battle Calculation
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
            if (hp <= 0)
            {
                hp = 0;
            }
            //key is damage, value is hp
            return new KeyValuePair<int, int>(damage, hp);
        }
        #endregion
        #region Battle Result
        private int BattleFunction(Battle battle, Player player)
        {
            // Show information about enemy 
            enemyLevel.Text = battle.Level.ToString();
            enemyName.Text = battle.Name;
            enemyAttack.Text = battle.AttackPoint.ToString();
            enemyDefense.Text = battle.DefensePoint.ToString();
            enemyHP.Text = battle.HP.ToString();

            //Side = true  mean enemy attack player
            var result = BattleCalculation(battle, player, true);

            MessageBox.Show("You get " + result.Key + " Damage");
            player.HP = result.Value;
            HpPoint.Text = player.HP.ToString();

            // player attack enemy
            result = BattleCalculation(battle, player, false);
            MessageBox.Show("You deal " + result.Key + " Damage");
            battle.HP = result.Value;
            enemyHP.Text = battle.HP.ToString();

            //renew information for both enemy and player
            CurrentEnemy = battle;
            CurrentPlay = player;
            //return enemy HP
            return battle.HP;
        }
        #endregion
        #region Exp Calucation
        private void ExpCalucation(Battle battle, Player player)
        {

            //Add exp to player
            player.CurrentExp += battle.Exp;
            MessageBox.Show("You get: " + battle.Exp + " Exp");
            // Current Exp is meet exp needed than Level Up and set current exp to 0
            if (player.CurrentExp >= player.ExpNeeded)
            {
                player.Level += 1;
                player.CurrentExp = 0;
                MessageBox.Show("Level UP!\n Level :" + player.Level);
            }
            CurrentPlay.CurrentExp = player.CurrentExp;
        }
        #endregion
    }
}
