namespace TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pbOne = new PictureBox();
            pbTwo = new PictureBox();
            pbThree = new PictureBox();
            pbFour = new PictureBox();
            pbFive = new PictureBox();
            pbSix = new PictureBox();
            pbSeven = new PictureBox();
            pbEight = new PictureBox();
            pbNine = new PictureBox();
            btnRestart = new Button();
            label3 = new Label();
            lbWinner = new Label();
            lbPlayer = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbThree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSeven).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNine).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 30F);
            label1.Location = new Point(355, -14);
            label1.Name = "label1";
            label1.Size = new Size(320, 67);
            label1.TabIndex = 0;
            label1.Text = "Tic Tac Toe ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(462, 43);
            label2.Name = "label2";
            label2.Size = new Size(75, 31);
            label2.TabIndex = 1;
            label2.Text = "Game";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(77, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pbOne
            // 
            pbOne.ErrorImage = null;
            pbOne.Image = Properties.Resources.Q;
            pbOne.Location = new Point(356, 121);
            pbOne.Name = "pbOne";
            pbOne.Size = new Size(63, 61);
            pbOne.SizeMode = PictureBoxSizeMode.Zoom;
            pbOne.TabIndex = 3;
            pbOne.TabStop = false;
            pbOne.Click += Box_Click;
            // 
            // pbTwo
            // 
            pbTwo.ErrorImage = null;
            pbTwo.Image = Properties.Resources.Q;
            pbTwo.Location = new Point(467, 122);
            pbTwo.Name = "pbTwo";
            pbTwo.Size = new Size(63, 61);
            pbTwo.SizeMode = PictureBoxSizeMode.Zoom;
            pbTwo.TabIndex = 4;
            pbTwo.TabStop = false;
            pbTwo.Click += Box_Click;
            // 
            // pbThree
            // 
            pbThree.ErrorImage = null;
            pbThree.Image = Properties.Resources.Q;
            pbThree.Location = new Point(578, 121);
            pbThree.Name = "pbThree";
            pbThree.Size = new Size(63, 61);
            pbThree.SizeMode = PictureBoxSizeMode.Zoom;
            pbThree.TabIndex = 5;
            pbThree.TabStop = false;
            pbThree.Click += Box_Click;
            // 
            // pbFour
            // 
            pbFour.ErrorImage = null;
            pbFour.Image = Properties.Resources.Q;
            pbFour.Location = new Point(356, 222);
            pbFour.Name = "pbFour";
            pbFour.Size = new Size(63, 61);
            pbFour.SizeMode = PictureBoxSizeMode.Zoom;
            pbFour.TabIndex = 6;
            pbFour.TabStop = false;
            pbFour.Click += Box_Click;
            // 
            // pbFive
            // 
            pbFive.ErrorImage = null;
            pbFive.Image = Properties.Resources.Q;
            pbFive.Location = new Point(467, 224);
            pbFive.Name = "pbFive";
            pbFive.Size = new Size(63, 61);
            pbFive.SizeMode = PictureBoxSizeMode.Zoom;
            pbFive.TabIndex = 7;
            pbFive.TabStop = false;
            pbFive.Click += Box_Click;
            // 
            // pbSix
            // 
            pbSix.ErrorImage = null;
            pbSix.Image = Properties.Resources.Q;
            pbSix.Location = new Point(578, 225);
            pbSix.Name = "pbSix";
            pbSix.Size = new Size(63, 61);
            pbSix.SizeMode = PictureBoxSizeMode.Zoom;
            pbSix.TabIndex = 8;
            pbSix.TabStop = false;
            pbSix.Click += Box_Click;
            // 
            // pbSeven
            // 
            pbSeven.ErrorImage = null;
            pbSeven.Image = Properties.Resources.Q;
            pbSeven.Location = new Point(356, 321);
            pbSeven.Name = "pbSeven";
            pbSeven.Size = new Size(63, 61);
            pbSeven.SizeMode = PictureBoxSizeMode.Zoom;
            pbSeven.TabIndex = 9;
            pbSeven.TabStop = false;
            pbSeven.Click += Box_Click;
            // 
            // pbEight
            // 
            pbEight.ErrorImage = null;
            pbEight.Image = Properties.Resources.Q;
            pbEight.Location = new Point(467, 320);
            pbEight.Name = "pbEight";
            pbEight.Size = new Size(63, 61);
            pbEight.SizeMode = PictureBoxSizeMode.Zoom;
            pbEight.TabIndex = 10;
            pbEight.TabStop = false;
            pbEight.Click += Box_Click;
            // 
            // pbNine
            // 
            pbNine.ErrorImage = null;
            pbNine.Image = Properties.Resources.Q;
            pbNine.Location = new Point(578, 321);
            pbNine.Name = "pbNine";
            pbNine.Size = new Size(63, 61);
            pbNine.SizeMode = PictureBoxSizeMode.Zoom;
            pbNine.TabIndex = 11;
            pbNine.TabStop = false;
            pbNine.Click += Box_Click;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = SystemColors.ActiveCaptionText;
            btnRestart.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.ForeColor = SystemColors.ButtonFace;
            btnRestart.Location = new Point(86, 464);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(132, 49);
            btnRestart.TabIndex = 12;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(97, 160);
            label3.Name = "label3";
            label3.Size = new Size(88, 46);
            label3.TabIndex = 13;
            label3.Text = "Turn";
            // 
            // lbWinner
            // 
            lbWinner.AutoSize = true;
            lbWinner.BackColor = Color.Transparent;
            lbWinner.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbWinner.ForeColor = SystemColors.ActiveCaptionText;
            lbWinner.Location = new Point(59, 274);
            lbWinner.Name = "lbWinner";
            lbWinner.Size = new Size(167, 46);
            lbWinner.TabIndex = 14;
            lbWinner.Text = "Progress";
            // 
            // lbPlayer
            // 
            lbPlayer.AutoSize = true;
            lbPlayer.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPlayer.Location = new Point(59, 201);
            lbPlayer.Name = "lbPlayer";
            lbPlayer.Size = new Size(175, 54);
            lbPlayer.TabIndex = 15;
            lbPlayer.Text = "Player 1";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(530, 522);
            label4.Name = "label4";
            label4.Size = new Size(185, 33);
            label4.TabIndex = 16;
            label4.Text = "By: Ahmed Osman";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 564);
            Controls.Add(label4);
            Controls.Add(lbPlayer);
            Controls.Add(lbWinner);
            Controls.Add(label3);
            Controls.Add(btnRestart);
            Controls.Add(pbNine);
            Controls.Add(pbEight);
            Controls.Add(pbSeven);
            Controls.Add(pbSix);
            Controls.Add(pbFive);
            Controls.Add(pbFour);
            Controls.Add(pbThree);
            Controls.Add(pbTwo);
            Controls.Add(pbOne);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbThree).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFour).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFive).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSix).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSeven).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pbOne;
        private PictureBox pbTwo;
        private PictureBox pbThree;
        private PictureBox pbFour;
        private PictureBox pbFive;
        private PictureBox pbSix;
        private PictureBox pbSeven;
        private PictureBox pbEight;
        private PictureBox pbNine;
        private Button btnRestart;
        private Label label3;
        private Label lbWinner;
        private Label lbPlayer;
        private Label label4;
    }
}
