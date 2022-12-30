﻿namespace Trex_Endless_Runner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Trex = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-10, 487);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(897, 89);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Trex
            // 
            this.Trex.Image = global::Trex_Endless_Runner.Properties.Resources.running;
            this.Trex.Location = new System.Drawing.Point(135, 444);
            this.Trex.Name = "Trex";
            this.Trex.Size = new System.Drawing.Size(40, 43);
            this.Trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Trex.TabIndex = 2;
            this.Trex.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Trex_Endless_Runner.Properties.Resources.obstacle_1;
            this.pictureBox3.Location = new System.Drawing.Point(555, 444);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "obstacle";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Trex_Endless_Runner.Properties.Resources.obstacle_2;
            this.pictureBox4.Location = new System.Drawing.Point(844, 454);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "obstacle";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtScore.Location = new System.Drawing.Point(57, 33);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(161, 38);
            this.txtScore.TabIndex = 3;
            this.txtScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 22;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameEventTimer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(886, 576);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Trex);
            this.Name = "Form1";
            this.Tag = "obstacle";
            this.Text = "T Rex Endless Runner Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox Trex;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}