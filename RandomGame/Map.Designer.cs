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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(205, 29);
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
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DefensePoint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AttackPoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HPpoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Map";
            this.Text = "Map";
            this.groupBox1.ResumeLayout(false);
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
    }
}