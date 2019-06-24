﻿using RandomGame.Model;
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
        public bool enemyAlive { get; set; }

        //store location for enemy 
        public int PastLocationX { get; set; }
        public int PastLocationY { get; set; }
        int Enemyhp;


        public BattlePage()
        {
            InitializeComponent();
        }

        private void BattlePage_Load(object sender, EventArgs e)
        {
            //player information
            HpPoint.Text = CurrentPlay.HP.ToString();
            AttackPoint.Text = CurrentPlay.AttackPoint.ToString();
            DefensePoint.Text = CurrentPlay.DefensePoint.ToString();

            //Enemy information
            enemyLevel.Text = CurrentEnemy.Level.ToString();
            enemyName.Text = CurrentEnemy.Name.ToString();
            enemyHP.Text = CurrentEnemy.HP.ToString();
            enemyAttack.Text = CurrentEnemy.AttackPoint.ToString();
            enemyDefense.Text = CurrentEnemy.DefensePoint.ToString();


            Enemyhp = CurrentEnemy.HP;

        }


        private void BattlePage_Shown(object sender, EventArgs e)
        {


            Enemyhp = BattleFunction(CurrentEnemy, CurrentPlay);
            if (Enemyhp <= 0 )
            {
                MessageBox.Show("Enemy die");
                ExpCalucation(CurrentEnemy, CurrentPlay);
                enemyAlive = false;

            }
            else
            {
                enemyAlive = true;
                MessageBox.Show("Enemy still have HP!");
            }            
            // enemy still have HP            
            CurrentEnemy.HP = Enemyhp;           
            BackToMap();

        }
        

        #region Return to the MAP
        private void BackToMap()
        {
            
            Map MapPage = new Map();
            MapPage.CurrentPlay = CurrentPlay;
            MapPage.CurrentEnemy = CurrentEnemy;
            MapPage.enemyAlive = enemyAlive;
            MapPage.PastLocationX = PastLocationX;
            MapPage.PastLocationY = PastLocationY;
            this.Hide();
            MapPage.ShowDialog();
            this.Close();
        }
        #endregion

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
