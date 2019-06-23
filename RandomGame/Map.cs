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
        public Battle CurrentEnemy { get; set; }
        bool enemyAlive { get; set; }
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
            if (enemyAlive == true)
            {
                readyForBattle();
            }
            else
            {

                //create a new enemy
                Battle Calucation = new Battle()
                {
                    Level = random.Next(CurrentPlay.Level, CurrentPlay.Level + 5),
                    Name = "Name " + random.Next(1, 10),
                    AttackPoint = random.Next(1, 20),
                    DefensePoint = random.Next(1, 10),
                    HP = random.Next(20, 25),

                };
                CurrentEnemy = Calucation;
                NewEnemy();
                readyForBattle();
               
            }
            
            //Player lost of their Hp
            if (CurrentPlay.HP <= 0)
            {
                MessageBox.Show("Your Hp is 0. \n You LOST!");

                MenuPage MainPage = new MenuPage();
                this.Hide();
                MainPage.ShowDialog();
                this.Close();
            }

            


        }
        
        private void readyForBattle()
        {
            BattlePage battlePage = new BattlePage();
            battlePage.CurrentPlay = CurrentPlay;
            battlePage.CurrentEnemy = CurrentEnemy;
            this.Hide();
            battlePage.ShowDialog();
            this.Close();
        }
        #region new Enemy
        private void NewEnemy()
        {
            foreach (Control item in groupBox1.Controls)
            {
                groupBox1.Controls.Remove(item);
            }
            Random randomLocation = new Random();
            int x1;
            int y1;
            x1 = randomLocation.Next(groupBox1.Width);
            y1 = randomLocation.Next(groupBox1.Height);
            Button BT = new Button()
            {
                Location = new Point(x1, y1),
                Text = "Your enemy"                
            };
            BT.Click += button1_Click;
            groupBox1.Controls.Add(BT);
        }
        #endregion
    }
}
