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
        public bool enemyAlive { get; set; }

        //Store enemy location 
        public int PastLocationX { get; set; }
        public int PastLocationY { get; set; }
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
            EnemyAppear();

            if (CurrentEnemy ==null)
            {
                CurrentEnemy = new Battle()
                {
                    HP = 1,
                    AttackPoint = 1,
                    DefensePoint = 1,
                    Level = 1,
                    Name = "test"
                };
            }

            


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
                
                readyForBattle();
               
            }


            ////check control in the panel
            //// Clear enemy infomration
            //foreach (Control txt in panel1.Controls.Cast<Control>())
            //{
            //    //control that is label + design name have enemy  in panel1 will clear
            //    if (txt is Label && txt.Name.Contains("enemy"))
            //    {
            //        txt.Text = "";
            //    }
            //}



        }
        
        private void readyForBattle()
        {
            BattlePage battlePage = new BattlePage();
            battlePage.CurrentPlay = CurrentPlay;
            battlePage.CurrentEnemy = CurrentEnemy;
            battlePage.PastLocationX = PastLocationX;
            battlePage.PastLocationY = PastLocationY;
            this.Hide();
            battlePage.ShowDialog();
            this.Close();
        }
        #region  Enemy appear
        private void EnemyAppear()
        {
            foreach (Control item in groupBox1.Controls)
            {
                groupBox1.Controls.Remove(item);
            }
            Random randomLocation = new Random();
            int x1;
            int y1;

            Button BT = new Button();
            BT.Size = new Size(110, 34);// Make sure the size is big enough

            // If there are no current enemy, Just show there is an enemy
            //otherwise show enemy HP
            if (enemyAlive ==false)
            {
                BT.Text = "Your enemy";
                x1 = randomLocation.Next(groupBox1.Size.Width - BT.Width);
                y1 = randomLocation.Next(groupBox1.Size.Height - BT.Height);
                PastLocationX = x1;
                PastLocationY = y1;
            }
            else
            {
                BT.Text = CurrentEnemy.Name + "  HP :" + CurrentEnemy.HP;
                x1 = PastLocationX;
                y1 = PastLocationY;
            }

            
           
            BT.Location = new Point(x1, y1);
            BT.Click += button1_Click;
            groupBox1.Controls.Add(BT);
        }
        #endregion


        private void Map_Shown(object sender, EventArgs e)
        {
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


    }
}
