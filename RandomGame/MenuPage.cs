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
    public partial class MenuPage : Form
    {
        public Player CurrentPlay { get; set; } //
        public MenuPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text)) // can not be blank
            {
                MessageBox.Show("Please enter name");
            }
            else
            {
                // player information
                Player NewPlayer = new Player()
                {
                    Name = textBox1.Text,
                    AttackPoint = 15,
                    DefensePoint = 5,
                    HP = 100,
                    CurrentExp = 0,
                    Level = 1,
                    
                };
                
                //start a new page
                Map start = new Map();
                //send player information to other 
                start.CurrentPlay = NewPlayer;
                this.Hide();// 
                start.ShowDialog(); // 
                this.Close();//
            }
           
        }
    }
}
