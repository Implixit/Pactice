namespace RandomGame
{
    partial class Map
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HPpoint = new System.Windows.Forms.Label();
            this.AttackPoint = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DefensePoint = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.enemyName = new System.Windows.Forms.Label();
            this.enemyHP = new System.Windows.Forms.Label();
            this.enemyAttack = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.enemyDefense = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.enemyLevel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(115, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "HP";
            // 
            // HPpoint
            // 
            this.HPpoint.AutoSize = true;
            this.HPpoint.Location = new System.Drawing.Point(112, 385);
            this.HPpoint.Name = "HPpoint";
            this.HPpoint.Size = new System.Drawing.Size(45, 13);
            this.HPpoint.TabIndex = 2;
            this.HPpoint.Text = "HPpoint";
            // 
            // AttackPoint
            // 
            this.AttackPoint.AutoSize = true;
            this.AttackPoint.Location = new System.Drawing.Point(273, 385);
            this.AttackPoint.Name = "AttackPoint";
            this.AttackPoint.Size = new System.Drawing.Size(62, 13);
            this.AttackPoint.TabIndex = 4;
            this.AttackPoint.Text = "AttackPoint";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Attack";
            // 
            // DefensePoint
            // 
            this.DefensePoint.AutoSize = true;
            this.DefensePoint.Location = new System.Drawing.Point(502, 385);
            this.DefensePoint.Name = "DefensePoint";
            this.DefensePoint.Size = new System.Drawing.Size(71, 13);
            this.DefensePoint.TabIndex = 6;
            this.DefensePoint.Text = "DefensePoint";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Defense";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "enemy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(613, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(641, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Attack Point";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(705, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Defense Point";
            // 
            // enemyName
            // 
            this.enemyName.AutoSize = true;
            this.enemyName.Location = new System.Drawing.Point(38, 0);
            this.enemyName.Name = "enemyName";
            this.enemyName.Size = new System.Drawing.Size(10, 13);
            this.enemyName.TabIndex = 4;
            this.enemyName.Text = " ";
            // 
            // enemyHP
            // 
            this.enemyHP.AutoSize = true;
            this.enemyHP.Location = new System.Drawing.Point(82, 0);
            this.enemyHP.Name = "enemyHP";
            this.enemyHP.Size = new System.Drawing.Size(10, 13);
            this.enemyHP.TabIndex = 5;
            this.enemyHP.Text = " ";
            // 
            // enemyAttack
            // 
            this.enemyAttack.AutoSize = true;
            this.enemyAttack.Location = new System.Drawing.Point(124, 0);
            this.enemyAttack.Name = "enemyAttack";
            this.enemyAttack.Size = new System.Drawing.Size(10, 13);
            this.enemyAttack.TabIndex = 6;
            this.enemyAttack.Text = " ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.enemyLevel);
            this.panel1.Controls.Add(this.enemyDefense);
            this.panel1.Controls.Add(this.enemyAttack);
            this.panel1.Controls.Add(this.enemyHP);
            this.panel1.Controls.Add(this.enemyName);
            this.panel1.Location = new System.Drawing.Point(531, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 107);
            this.panel1.TabIndex = 8;
            // 
            // enemyDefense
            // 
            this.enemyDefense.AutoSize = true;
            this.enemyDefense.Location = new System.Drawing.Point(174, 0);
            this.enemyDefense.Name = "enemyDefense";
            this.enemyDefense.Size = new System.Drawing.Size(10, 13);
            this.enemyDefense.TabIndex = 7;
            this.enemyDefense.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(528, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Level";
            // 
            // enemyLevel
            // 
            this.enemyLevel.AutoSize = true;
            this.enemyLevel.Location = new System.Drawing.Point(3, 0);
            this.enemyLevel.Name = "enemyLevel";
            this.enemyLevel.Size = new System.Drawing.Size(10, 13);
            this.enemyLevel.TabIndex = 8;
            this.enemyLevel.Text = " ";
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DefensePoint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AttackPoint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HPpoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "Map";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Map_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HPpoint;
        private System.Windows.Forms.Label AttackPoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DefensePoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label enemyHP;
        private System.Windows.Forms.Label enemyAttack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label enemyDefense;
        private System.Windows.Forms.Label enemyName;
        private System.Windows.Forms.Label enemyLevel;
        private System.Windows.Forms.Label label8;
    }
}