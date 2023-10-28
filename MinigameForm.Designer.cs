namespace Tournament_Tracker
{
    partial class MinigameForm
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
            lblWelcome = new Label();
            pbTitleImage = new PictureBox();
            lblTitle = new Label();
            lblTeam1Name = new Label();
            lblTeam2Name = new Label();
            lbTeam1Players = new ListBox();
            lbTeam2Players = new ListBox();
            btnAutoPlay = new Button();
            btnPlay = new Button();
            lblPlayers1 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            lblCurrentPlayers = new Label();
            pbCoinCurrent = new PictureBox();
            pbCoinCrown = new PictureBox();
            pbCoinStar = new PictureBox();
            lblWinner = new Label();
            btnContinue = new Button();
            ((System.ComponentModel.ISupportInitialize)pbTitleImage).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCoinCurrent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCoinCrown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCoinStar).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.ForeColor = SystemColors.ControlDarkDark;
            lblWelcome.Location = new Point(99, 108);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(586, 42);
            lblWelcome.TabIndex = 13;
            lblWelcome.Text = "Time to play Coin Flip! Click the Play button to have players face off in 1v1 contests.\r\nThe first team to beat all opposing players wins!\r\n";
            // 
            // pbTitleImage
            // 
            pbTitleImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbTitleImage.Image = Properties.Resources.toss;
            pbTitleImage.Location = new Point(279, 12);
            pbTitleImage.Name = "pbTitleImage";
            pbTitleImage.Size = new Size(75, 75);
            pbTitleImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTitleImage.TabIndex = 12;
            pbTitleImage.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(360, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(146, 45);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Coin Flip";
            // 
            // lblTeam1Name
            // 
            lblTeam1Name.AutoSize = true;
            lblTeam1Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTeam1Name.Location = new Point(99, 177);
            lblTeam1Name.Name = "lblTeam1Name";
            lblTeam1Name.Size = new Size(59, 21);
            lblTeam1Name.TabIndex = 14;
            lblTeam1Name.Text = "Team 1";
            // 
            // lblTeam2Name
            // 
            lblTeam2Name.AutoSize = true;
            lblTeam2Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTeam2Name.Location = new Point(99, 382);
            lblTeam2Name.Name = "lblTeam2Name";
            lblTeam2Name.Size = new Size(59, 21);
            lblTeam2Name.TabIndex = 15;
            lblTeam2Name.Text = "Team 2";
            // 
            // lbTeam1Players
            // 
            lbTeam1Players.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbTeam1Players.FormattingEnabled = true;
            lbTeam1Players.ItemHeight = 15;
            lbTeam1Players.Location = new Point(99, 216);
            lbTeam1Players.Name = "lbTeam1Players";
            lbTeam1Players.Size = new Size(200, 109);
            lbTeam1Players.TabIndex = 16;
            // 
            // lbTeam2Players
            // 
            lbTeam2Players.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbTeam2Players.FormattingEnabled = true;
            lbTeam2Players.ItemHeight = 15;
            lbTeam2Players.Location = new Point(99, 421);
            lbTeam2Players.Name = "lbTeam2Players";
            lbTeam2Players.Size = new Size(200, 109);
            lbTeam2Players.TabIndex = 17;
            // 
            // btnAutoPlay
            // 
            btnAutoPlay.BackColor = Color.LightCoral;
            btnAutoPlay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAutoPlay.Location = new Point(502, 500);
            btnAutoPlay.Name = "btnAutoPlay";
            btnAutoPlay.Size = new Size(75, 30);
            btnAutoPlay.TabIndex = 28;
            btnAutoPlay.Text = "Auto-Play";
            btnAutoPlay.UseVisualStyleBackColor = false;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.Gold;
            btnPlay.Location = new Point(464, 444);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(150, 50);
            btnPlay.TabIndex = 27;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // lblPlayers1
            // 
            lblPlayers1.AutoSize = true;
            lblPlayers1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayers1.Location = new Point(99, 198);
            lblPlayers1.Name = "lblPlayers1";
            lblPlayers1.Size = new Size(107, 15);
            lblPlayers1.TabIndex = 29;
            lblPlayers1.Text = "Players Remaining:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(99, 403);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 30;
            label1.Text = "Players Remaining:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblCurrentPlayers);
            panel1.Controls.Add(pbCoinCurrent);
            panel1.Location = new Point(339, 222);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 210);
            panel1.TabIndex = 31;
            // 
            // lblCurrentPlayers
            // 
            lblCurrentPlayers.AutoSize = true;
            lblCurrentPlayers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentPlayers.Location = new Point(0, 0);
            lblCurrentPlayers.Name = "lblCurrentPlayers";
            lblCurrentPlayers.Size = new Size(137, 21);
            lblCurrentPlayers.TabIndex = 34;
            lblCurrentPlayers.Text = "Player1 vs Player2";
            // 
            // pbCoinCurrent
            // 
            pbCoinCurrent.Image = Properties.Resources.coin;
            pbCoinCurrent.Location = new Point(149, 54);
            pbCoinCurrent.Name = "pbCoinCurrent";
            pbCoinCurrent.Size = new Size(100, 100);
            pbCoinCurrent.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCoinCurrent.TabIndex = 34;
            pbCoinCurrent.TabStop = false;
            // 
            // pbCoinCrown
            // 
            pbCoinCrown.Image = Properties.Resources.coin_crown;
            pbCoinCrown.Location = new Point(43, 177);
            pbCoinCrown.Name = "pbCoinCrown";
            pbCoinCrown.Size = new Size(50, 50);
            pbCoinCrown.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCoinCrown.TabIndex = 32;
            pbCoinCrown.TabStop = false;
            // 
            // pbCoinStar
            // 
            pbCoinStar.Image = Properties.Resources.coin_star;
            pbCoinStar.Location = new Point(43, 382);
            pbCoinStar.Name = "pbCoinStar";
            pbCoinStar.Size = new Size(50, 50);
            pbCoinStar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCoinStar.TabIndex = 33;
            pbCoinStar.TabStop = false;
            // 
            // lblWinner
            // 
            lblWinner.AutoSize = true;
            lblWinner.Location = new Point(339, 198);
            lblWinner.Name = "lblWinner";
            lblWinner.Size = new Size(164, 21);
            lblWinner.TabIndex = 35;
            lblWinner.Text = "XXX Won Last Round! ";
            lblWinner.Visible = false;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.PaleGreen;
            btnContinue.Location = new Point(439, 444);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(200, 50);
            btnContinue.TabIndex = 36;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Visible = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // MinigameForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(784, 561);
            Controls.Add(lblWinner);
            Controls.Add(pbCoinStar);
            Controls.Add(pbCoinCrown);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(lblPlayers1);
            Controls.Add(btnAutoPlay);
            Controls.Add(btnPlay);
            Controls.Add(lbTeam2Players);
            Controls.Add(lbTeam1Players);
            Controls.Add(lblTeam2Name);
            Controls.Add(lblTeam1Name);
            Controls.Add(lblWelcome);
            Controls.Add(pbTitleImage);
            Controls.Add(lblTitle);
            Controls.Add(btnContinue);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "MinigameForm";
            Text = "Ultimate Flipper - Coin Flip";
            FormClosing += MinigameForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbTitleImage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCoinCurrent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCoinCrown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCoinStar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private PictureBox pbTitleImage;
        private Label lblTitle;
        private Label lblTeam1Name;
        private Label lblTeam2Name;
        private ListBox lbTeam1Players;
        private ListBox lbTeam2Players;
        private Button btnAutoPlay;
        private Button btnPlay;
        private Label lblPlayers1;
        private Label label1;
        private Panel panel1;
        private PictureBox pbCoinCrown;
        private PictureBox pbCoinStar;
        private Label lblCurrentPlayers;
        private PictureBox pbCoinCurrent;
        private Label lblWinner;
        private Button btnContinue;
    }
}