﻿namespace Budget_game
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblEnemiesLeftName = new System.Windows.Forms.Label();
            this.lblHitpoints = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblEnemiesLeft = new System.Windows.Forms.Label();
            this.lblLevelName = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblShopName = new System.Windows.Forms.Label();
            this.StoreTurret1Price = new System.Windows.Forms.Label();
            this.StoreTurret2Price = new System.Windows.Forms.Label();
            this.StoreTurret3Price = new System.Windows.Forms.Label();
            this.StoreTurret4Price = new System.Windows.Forms.Label();
            this.lblUpgradesName1 = new System.Windows.Forms.Label();
            this.lblUpgradesName2 = new System.Windows.Forms.Label();
            this.lblUpgradesName3 = new System.Windows.Forms.Label();
            this.lblUpgradesName4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StoreTurret4 = new System.Windows.Forms.PictureBox();
            this.StoreTurret3 = new System.Windows.Forms.PictureBox();
            this.StoreTurret2 = new System.Windows.Forms.PictureBox();
            this.StoreTurret1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpgradeTower1 = new System.Windows.Forms.Button();
            this.btnUpgradeTower2 = new System.Windows.Forms.Button();
            this.btnUpgradeTower3 = new System.Windows.Forms.Button();
            this.btnUpgradeTower4 = new System.Windows.Forms.Button();
            this.btnCredits = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BoughtTurret = new Budget_game.Turrets(0);
            ((System.ComponentModel.ISupportInitialize)(this.StoreTurret4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreTurret3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreTurret2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreTurret1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoughtTurret)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblEnemiesLeftName
            // 
            this.lblEnemiesLeftName.AutoSize = true;
            this.lblEnemiesLeftName.Location = new System.Drawing.Point(1040, 153);
            this.lblEnemiesLeftName.Name = "lblEnemiesLeftName";
            this.lblEnemiesLeftName.Size = new System.Drawing.Size(67, 13);
            this.lblEnemiesLeftName.TabIndex = 3;
            this.lblEnemiesLeftName.Text = "Enemies left:";
            // 
            // lblHitpoints
            // 
            this.lblHitpoints.AutoSize = true;
            this.lblHitpoints.Location = new System.Drawing.Point(1119, 78);
            this.lblHitpoints.Name = "lblHitpoints";
            this.lblHitpoints.Size = new System.Drawing.Size(156, 13);
            this.lblHitpoints.TabIndex = 4;
            this.lblHitpoints.Text = "only here to find the label easier";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(1119, 116);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(156, 13);
            this.lblGold.TabIndex = 5;
            this.lblGold.Text = "only here to find the label easier";
            // 
            // lblEnemiesLeft
            // 
            this.lblEnemiesLeft.AutoSize = true;
            this.lblEnemiesLeft.Location = new System.Drawing.Point(1119, 153);
            this.lblEnemiesLeft.Name = "lblEnemiesLeft";
            this.lblEnemiesLeft.Size = new System.Drawing.Size(156, 13);
            this.lblEnemiesLeft.TabIndex = 6;
            this.lblEnemiesLeft.Text = "only here to find the label easier";
            // 
            // lblLevelName
            // 
            this.lblLevelName.AutoSize = true;
            this.lblLevelName.Location = new System.Drawing.Point(1040, 179);
            this.lblLevelName.Name = "lblLevelName";
            this.lblLevelName.Size = new System.Drawing.Size(36, 13);
            this.lblLevelName.TabIndex = 7;
            this.lblLevelName.Text = "Level:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(1119, 179);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(156, 13);
            this.lblLevel.TabIndex = 8;
            this.lblLevel.Text = "only here to find the label easier";
            // 
            // lblShopName
            // 
            this.lblShopName.AutoSize = true;
            this.lblShopName.Location = new System.Drawing.Point(23, 527);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(35, 13);
            this.lblShopName.TabIndex = 9;
            this.lblShopName.Text = "Shop:";
            // 
            // StoreTurret1Price
            // 
            this.StoreTurret1Price.AutoSize = true;
            this.StoreTurret1Price.Location = new System.Drawing.Point(73, 562);
            this.StoreTurret1Price.Name = "StoreTurret1Price";
            this.StoreTurret1Price.Size = new System.Drawing.Size(40, 13);
            this.StoreTurret1Price.TabIndex = 14;
            this.StoreTurret1Price.Text = "200 gp";
            // 
            // StoreTurret2Price
            // 
            this.StoreTurret2Price.AutoSize = true;
            this.StoreTurret2Price.Location = new System.Drawing.Point(294, 562);
            this.StoreTurret2Price.Name = "StoreTurret2Price";
            this.StoreTurret2Price.Size = new System.Drawing.Size(40, 13);
            this.StoreTurret2Price.TabIndex = 15;
            this.StoreTurret2Price.Text = "300 gp";
            // 
            // StoreTurret3Price
            // 
            this.StoreTurret3Price.AutoSize = true;
            this.StoreTurret3Price.Location = new System.Drawing.Point(506, 562);
            this.StoreTurret3Price.Name = "StoreTurret3Price";
            this.StoreTurret3Price.Size = new System.Drawing.Size(40, 13);
            this.StoreTurret3Price.TabIndex = 16;
            this.StoreTurret3Price.Text = "500 gp";
            // 
            // StoreTurret4Price
            // 
            this.StoreTurret4Price.AutoSize = true;
            this.StoreTurret4Price.Location = new System.Drawing.Point(708, 567);
            this.StoreTurret4Price.Name = "StoreTurret4Price";
            this.StoreTurret4Price.Size = new System.Drawing.Size(40, 13);
            this.StoreTurret4Price.TabIndex = 17;
            this.StoreTurret4Price.Text = "900 gp";
            // 
            // lblUpgradesName1
            // 
            this.lblUpgradesName1.AutoSize = true;
            this.lblUpgradesName1.Location = new System.Drawing.Point(41, 575);
            this.lblUpgradesName1.Name = "lblUpgradesName1";
            this.lblUpgradesName1.Size = new System.Drawing.Size(56, 13);
            this.lblUpgradesName1.TabIndex = 18;
            this.lblUpgradesName1.Text = "Upgrades:";
            // 
            // lblUpgradesName2
            // 
            this.lblUpgradesName2.AutoSize = true;
            this.lblUpgradesName2.Location = new System.Drawing.Point(275, 575);
            this.lblUpgradesName2.Name = "lblUpgradesName2";
            this.lblUpgradesName2.Size = new System.Drawing.Size(56, 13);
            this.lblUpgradesName2.TabIndex = 19;
            this.lblUpgradesName2.Text = "Upgrades:";
            // 
            // lblUpgradesName3
            // 
            this.lblUpgradesName3.AutoSize = true;
            this.lblUpgradesName3.Location = new System.Drawing.Point(485, 575);
            this.lblUpgradesName3.Name = "lblUpgradesName3";
            this.lblUpgradesName3.Size = new System.Drawing.Size(56, 13);
            this.lblUpgradesName3.TabIndex = 20;
            this.lblUpgradesName3.Text = "Upgrades:";
            // 
            // lblUpgradesName4
            // 
            this.lblUpgradesName4.AutoSize = true;
            this.lblUpgradesName4.Location = new System.Drawing.Point(687, 580);
            this.lblUpgradesName4.Name = "lblUpgradesName4";
            this.lblUpgradesName4.Size = new System.Drawing.Size(56, 13);
            this.lblUpgradesName4.TabIndex = 21;
            this.lblUpgradesName4.Text = "Upgrades:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1078, 207);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 27;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(1119, 40);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(28, 13);
            this.lblTimer.TabIndex = 28;
            this.lblTimer.Text = "0:00";
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.lblGameOver.Location = new System.Drawing.Point(1048, 489);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(0, 51);
            this.lblGameOver.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 575);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Damage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Damage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Shooting speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(749, 580);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Range";
            // 
            // StoreTurret4
            // 
            this.StoreTurret4.Image = ((System.Drawing.Image)(resources.GetObject("StoreTurret4.Image")));
            this.StoreTurret4.Location = new System.Drawing.Point(711, 532);
            this.StoreTurret4.Name = "StoreTurret4";
            this.StoreTurret4.Size = new System.Drawing.Size(32, 32);
            this.StoreTurret4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.StoreTurret4.TabIndex = 13;
            this.StoreTurret4.TabStop = false;
            this.StoreTurret4.Click += new System.EventHandler(this.StoreTurret4_Click);
            // 
            // StoreTurret3
            // 
            this.StoreTurret3.Image = global::Budget_game.Properties.Resources.Tower3;
            this.StoreTurret3.Location = new System.Drawing.Point(509, 527);
            this.StoreTurret3.Name = "StoreTurret3";
            this.StoreTurret3.Size = new System.Drawing.Size(32, 32);
            this.StoreTurret3.TabIndex = 12;
            this.StoreTurret3.TabStop = false;
            this.StoreTurret3.Click += new System.EventHandler(this.StoreTurret3_Click);
            // 
            // StoreTurret2
            // 
            this.StoreTurret2.Image = global::Budget_game.Properties.Resources.tower2;
            this.StoreTurret2.Location = new System.Drawing.Point(297, 527);
            this.StoreTurret2.Name = "StoreTurret2";
            this.StoreTurret2.Size = new System.Drawing.Size(32, 32);
            this.StoreTurret2.TabIndex = 11;
            this.StoreTurret2.TabStop = false;
            this.StoreTurret2.Click += new System.EventHandler(this.StoreTurret2_Click);
            // 
            // StoreTurret1
            // 
            this.StoreTurret1.Image = global::Budget_game.Properties.Resources.Tower1;
            this.StoreTurret1.Location = new System.Drawing.Point(76, 527);
            this.StoreTurret1.Name = "StoreTurret1";
            this.StoreTurret1.Size = new System.Drawing.Size(32, 32);
            this.StoreTurret1.TabIndex = 10;
            this.StoreTurret1.TabStop = false;
            this.StoreTurret1.Click += new System.EventHandler(this.StoreTurret1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1043, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 546);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Bomb Tower";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Laser Tower";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 550);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Mortal Tower";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(749, 551);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Sniper Tower";
            // 
            // btnUpgradeTower1
            // 
            this.btnUpgradeTower1.Location = new System.Drawing.Point(44, 607);
            this.btnUpgradeTower1.Name = "btnUpgradeTower1";
            this.btnUpgradeTower1.Size = new System.Drawing.Size(106, 42);
            this.btnUpgradeTower1.TabIndex = 43;
            this.btnUpgradeTower1.Text = "Tier 1 Upgrade 500gp";
            this.btnUpgradeTower1.UseVisualStyleBackColor = true;
            this.btnUpgradeTower1.Click += new System.EventHandler(this.btnUpgradeTower1_Click);
            // 
            // btnUpgradeTower2
            // 
            this.btnUpgradeTower2.Location = new System.Drawing.Point(278, 607);
            this.btnUpgradeTower2.Name = "btnUpgradeTower2";
            this.btnUpgradeTower2.Size = new System.Drawing.Size(106, 42);
            this.btnUpgradeTower2.TabIndex = 44;
            this.btnUpgradeTower2.Text = "Tier 1 Upgrade 850gp";
            this.btnUpgradeTower2.UseVisualStyleBackColor = true;
            this.btnUpgradeTower2.Click += new System.EventHandler(this.btnUpgradeTower2_Click);
            // 
            // btnUpgradeTower3
            // 
            this.btnUpgradeTower3.Location = new System.Drawing.Point(488, 607);
            this.btnUpgradeTower3.Name = "btnUpgradeTower3";
            this.btnUpgradeTower3.Size = new System.Drawing.Size(106, 42);
            this.btnUpgradeTower3.TabIndex = 45;
            this.btnUpgradeTower3.Text = "Tier 1 Upgrade 1200gp";
            this.btnUpgradeTower3.UseVisualStyleBackColor = true;
            this.btnUpgradeTower3.Click += new System.EventHandler(this.btnUpgradeTower3_Click);
            // 
            // btnUpgradeTower4
            // 
            this.btnUpgradeTower4.Location = new System.Drawing.Point(690, 612);
            this.btnUpgradeTower4.Name = "btnUpgradeTower4";
            this.btnUpgradeTower4.Size = new System.Drawing.Size(106, 42);
            this.btnUpgradeTower4.TabIndex = 46;
            this.btnUpgradeTower4.Text = "Tier 1 Upgrade 2250gp";
            this.btnUpgradeTower4.UseVisualStyleBackColor = true;
            this.btnUpgradeTower4.Click += new System.EventHandler(this.btnUpgradeTower4_Click);
            // 
            // btnCredits
            // 
            this.btnCredits.Location = new System.Drawing.Point(1231, 646);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(75, 23);
            this.btnCredits.TabIndex = 34;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = true;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1044, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(917, 546);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1043, 107);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // BoughtTurret
            // 
            this.BoughtTurret.Location = new System.Drawing.Point(1243, 207);
            this.BoughtTurret.Name = "BoughtTurret";
            this.BoughtTurret.Size = new System.Drawing.Size(32, 32);
            this.BoughtTurret.TabIndex = 31;
            this.BoughtTurret.TabStop = false;
            this.BoughtTurret.Click += new System.EventHandler(this.BoughtTurret_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1318, 681);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpgradeTower4);
            this.Controls.Add(this.btnUpgradeTower3);
            this.Controls.Add(this.btnUpgradeTower2);
            this.Controls.Add(this.btnUpgradeTower1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.BoughtTurret);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblUpgradesName4);
            this.Controls.Add(this.lblUpgradesName3);
            this.Controls.Add(this.lblUpgradesName2);
            this.Controls.Add(this.lblUpgradesName1);
            this.Controls.Add(this.StoreTurret4Price);
            this.Controls.Add(this.StoreTurret3Price);
            this.Controls.Add(this.StoreTurret2Price);
            this.Controls.Add(this.StoreTurret1Price);
            this.Controls.Add(this.StoreTurret4);
            this.Controls.Add(this.StoreTurret3);
            this.Controls.Add(this.StoreTurret2);
            this.Controls.Add(this.StoreTurret1);
            this.Controls.Add(this.lblShopName);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblLevelName);
            this.Controls.Add(this.lblEnemiesLeft);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHitpoints);
            this.Controls.Add(this.lblEnemiesLeftName);
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StoreTurret4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreTurret3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreTurret2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreTurret1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoughtTurret)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblEnemiesLeftName;
        private System.Windows.Forms.Label lblHitpoints;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblEnemiesLeft;
        private System.Windows.Forms.Label lblLevelName;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.PictureBox StoreTurret1;
        private System.Windows.Forms.PictureBox StoreTurret2;
        private System.Windows.Forms.PictureBox StoreTurret3;
        private System.Windows.Forms.PictureBox StoreTurret4;
        private System.Windows.Forms.Label StoreTurret1Price;
        private System.Windows.Forms.Label StoreTurret2Price;
        private System.Windows.Forms.Label StoreTurret3Price;
        private System.Windows.Forms.Label StoreTurret4Price;
        private System.Windows.Forms.Label lblUpgradesName1;
        private System.Windows.Forms.Label lblUpgradesName2;
        private System.Windows.Forms.Label lblUpgradesName3;
        private System.Windows.Forms.Label lblUpgradesName4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblGameOver;
        private Budget_game.Turrets BoughtTurret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpgradeTower1;
        private System.Windows.Forms.Button btnUpgradeTower2;
        private System.Windows.Forms.Button btnUpgradeTower3;
        private System.Windows.Forms.Button btnUpgradeTower4;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

