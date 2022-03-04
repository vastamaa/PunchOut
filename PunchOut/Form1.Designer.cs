
namespace PunchOut
{
    partial class window
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
            this.enemyLife = new System.Windows.Forms.ProgressBar();
            this.playerLife = new System.Windows.Forms.ProgressBar();
            this.enemyBoxer = new System.Windows.Forms.PictureBox();
            this.playerBoxer = new System.Windows.Forms.PictureBox();
            this.enemyTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.enemyBoxer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBoxer)).BeginInit();
            this.SuspendLayout();
            // 
            // enemyLife
            // 
            this.enemyLife.Location = new System.Drawing.Point(12, 44);
            this.enemyLife.Name = "enemyLife";
            this.enemyLife.Size = new System.Drawing.Size(300, 25);
            this.enemyLife.TabIndex = 0;
            // 
            // playerLife
            // 
            this.playerLife.Location = new System.Drawing.Point(515, 44);
            this.playerLife.Name = "playerLife";
            this.playerLife.Size = new System.Drawing.Size(300, 25);
            this.playerLife.TabIndex = 1;
            // 
            // enemyBoxer
            // 
            this.enemyBoxer.BackColor = System.Drawing.Color.Transparent;
            this.enemyBoxer.Image = global::PunchOut.Properties.Resources.tr_stand;
            this.enemyBoxer.Location = new System.Drawing.Point(309, 217);
            this.enemyBoxer.Name = "enemyBoxer";
            this.enemyBoxer.Size = new System.Drawing.Size(77, 185);
            this.enemyBoxer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemyBoxer.TabIndex = 2;
            this.enemyBoxer.TabStop = false;
            // 
            // playerBoxer
            // 
            this.playerBoxer.BackColor = System.Drawing.Color.Transparent;
            this.playerBoxer.Image = global::PunchOut.Properties.Resources.player_stand;
            this.playerBoxer.Location = new System.Drawing.Point(392, 388);
            this.playerBoxer.Name = "playerBoxer";
            this.playerBoxer.Size = new System.Drawing.Size(61, 153);
            this.playerBoxer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playerBoxer.TabIndex = 3;
            this.playerBoxer.TabStop = false;
            // 
            // enemyTimer
            // 
            this.enemyTimer.Enabled = true;
            this.enemyTimer.Interval = 1000;
            this.enemyTimer.Tick += new System.EventHandler(this.EnemyPunchEvent);
            // 
            // enemyMove
            // 
            this.enemyMove.Enabled = true;
            this.enemyMove.Interval = 20;
            this.enemyMove.Tick += new System.EventHandler(this.EnemyMoveEvent);
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PunchOut.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 565);
            this.Controls.Add(this.playerBoxer);
            this.Controls.Add(this.enemyBoxer);
            this.Controls.Add(this.playerLife);
            this.Controls.Add(this.enemyLife);
            this.Name = "window";
            this.Text = "Vaskó Tamás\' Punch Out";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.enemyBoxer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBoxer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar enemyLife;
        private System.Windows.Forms.ProgressBar playerLife;
        private System.Windows.Forms.PictureBox enemyBoxer;
        private System.Windows.Forms.PictureBox playerBoxer;
        private System.Windows.Forms.Timer enemyTimer;
        private System.Windows.Forms.Timer enemyMove;
    }
}

