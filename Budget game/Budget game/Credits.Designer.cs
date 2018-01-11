namespace Budget_game
{
    partial class Credits
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
            this.lblhindrekhan = new System.Windows.Forms.Label();
            this.lblkaursamuel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblhindrekhan
            // 
            this.lblhindrekhan.AutoSize = true;
            this.lblhindrekhan.Location = new System.Drawing.Point(12, 9);
            this.lblhindrekhan.Name = "lblhindrekhan";
            this.lblhindrekhan.Size = new System.Drawing.Size(236, 26);
            this.lblhindrekhan.TabIndex = 0;
            this.lblhindrekhan.Text = "hindrekhan - terrain generation, turret placement,\r\nstore, enemy AI";
            // 
            // lblkaursamuel
            // 
            this.lblkaursamuel.AutoSize = true;
            this.lblkaursamuel.Location = new System.Drawing.Point(12, 113);
            this.lblkaursamuel.Name = "lblkaursamuel";
            this.lblkaursamuel.Size = new System.Drawing.Size(252, 13);
            this.lblkaursamuel.TabIndex = 1;
            this.lblkaursamuel.Text = "Kaur - turrets, 2 sprites, monster HP, Game Designer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "JaanJah - all sprites exept 2, game´s UI";
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblkaursamuel);
            this.Controls.Add(this.lblhindrekhan);
            this.Name = "Credits";
            this.Text = "Credits";
            this.Load += new System.EventHandler(this.Credits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhindrekhan;
        private System.Windows.Forms.Label lblkaursamuel;
        private System.Windows.Forms.Label label3;
    }
}