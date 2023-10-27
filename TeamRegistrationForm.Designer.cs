namespace Tournament_Tracker
{
    partial class TeamRegistrationForm
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
            pbTitleImage = new PictureBox();
            lblTitle = new Label();
            tbTeamName = new TextBox();
            lblTeamName = new Label();
            label2 = new Label();
            lblWelcome = new Label();
            lblNumOfPlayers = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            lblPlayer1 = new Label();
            lblPlayer2 = new Label();
            lblPlayer3 = new Label();
            lblPlayer4 = new Label();
            cbPlayer1 = new ComboBox();
            cbPlayer2 = new ComboBox();
            cbPlayer3 = new ComboBox();
            cbPlayer4 = new ComboBox();
            btnCancel = new Button();
            btnSubmit = new Button();
            lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)pbTitleImage).BeginInit();
            SuspendLayout();
            // 
            // pbTitleImage
            // 
            pbTitleImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbTitleImage.Image = Properties.Resources.person;
            pbTitleImage.Location = new Point(205, 12);
            pbTitleImage.Name = "pbTitleImage";
            pbTitleImage.Size = new Size(75, 75);
            pbTitleImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTitleImage.TabIndex = 3;
            pbTitleImage.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(286, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(282, 45);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Team Registration";
            // 
            // tbTeamName
            // 
            tbTeamName.Location = new Point(149, 180);
            tbTeamName.Name = "tbTeamName";
            tbTeamName.Size = new Size(300, 29);
            tbTeamName.TabIndex = 6;
            // 
            // lblTeamName
            // 
            lblTeamName.AutoSize = true;
            lblTeamName.Location = new Point(48, 183);
            lblTeamName.Name = "lblTeamName";
            lblTeamName.Size = new Size(95, 21);
            lblTeamName.TabIndex = 5;
            lblTeamName.Text = "Team Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(48, 136);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 11;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.ForeColor = SystemColors.ControlDarkDark;
            lblWelcome.Location = new Point(139, 115);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(507, 21);
            lblWelcome.TabIndex = 10;
            lblWelcome.Text = "Welcome to Team Registration! Please choose a team name and players.";
            // 
            // lblNumOfPlayers
            // 
            lblNumOfPlayers.AutoSize = true;
            lblNumOfPlayers.Location = new Point(48, 257);
            lblNumOfPlayers.Name = "lblNumOfPlayers";
            lblNumOfPlayers.Size = new Size(143, 21);
            lblNumOfPlayers.TabIndex = 12;
            lblNumOfPlayers.Text = "Number of Players:";
            // 
            // btn1
            // 
            btn1.Location = new Point(205, 252);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 30);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(261, 252);
            btn2.Name = "btn2";
            btn2.Size = new Size(50, 30);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(317, 252);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 30);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(373, 252);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 30);
            btn4.TabIndex = 16;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // lblPlayer1
            // 
            lblPlayer1.AutoSize = true;
            lblPlayer1.Location = new Point(87, 323);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(66, 21);
            lblPlayer1.TabIndex = 17;
            lblPlayer1.Text = "Player 1";
            // 
            // lblPlayer2
            // 
            lblPlayer2.AutoSize = true;
            lblPlayer2.Location = new Point(272, 323);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(66, 21);
            lblPlayer2.TabIndex = 18;
            lblPlayer2.Text = "Player 2";
            // 
            // lblPlayer3
            // 
            lblPlayer3.AutoSize = true;
            lblPlayer3.Location = new Point(449, 323);
            lblPlayer3.Name = "lblPlayer3";
            lblPlayer3.Size = new Size(66, 21);
            lblPlayer3.TabIndex = 19;
            lblPlayer3.Text = "Player 3";
            // 
            // lblPlayer4
            // 
            lblPlayer4.AutoSize = true;
            lblPlayer4.Location = new Point(633, 323);
            lblPlayer4.Name = "lblPlayer4";
            lblPlayer4.Size = new Size(66, 21);
            lblPlayer4.TabIndex = 20;
            lblPlayer4.Text = "Player 4";
            // 
            // cbPlayer1
            // 
            cbPlayer1.FormattingEnabled = true;
            cbPlayer1.Location = new Point(60, 347);
            cbPlayer1.Name = "cbPlayer1";
            cbPlayer1.Size = new Size(120, 29);
            cbPlayer1.TabIndex = 21;
            cbPlayer1.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // cbPlayer2
            // 
            cbPlayer2.FormattingEnabled = true;
            cbPlayer2.Location = new Point(242, 347);
            cbPlayer2.Name = "cbPlayer2";
            cbPlayer2.Size = new Size(120, 29);
            cbPlayer2.TabIndex = 22;
            cbPlayer2.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // cbPlayer3
            // 
            cbPlayer3.FormattingEnabled = true;
            cbPlayer3.Location = new Point(423, 347);
            cbPlayer3.Name = "cbPlayer3";
            cbPlayer3.Size = new Size(120, 29);
            cbPlayer3.TabIndex = 23;
            cbPlayer3.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // cbPlayer4
            // 
            cbPlayer4.FormattingEnabled = true;
            cbPlayer4.Location = new Point(605, 347);
            cbPlayer4.Name = "cbPlayer4";
            cbPlayer4.Size = new Size(120, 29);
            cbPlayer4.TabIndex = 24;
            cbPlayer4.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.Location = new Point(228, 477);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 50);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.PaleGreen;
            btnSubmit.Location = new Point(406, 477);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 50);
            btnSubmit.TabIndex = 25;
            btnSubmit.Text = "Create Team";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(261, 421);
            lblError.Name = "lblError";
            lblError.Size = new Size(262, 15);
            lblError.TabIndex = 27;
            lblError.Text = "You can't select the same player more than once";
            lblError.Visible = false;
            // 
            // TeamRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(lblError);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(cbPlayer4);
            Controls.Add(cbPlayer3);
            Controls.Add(cbPlayer2);
            Controls.Add(cbPlayer1);
            Controls.Add(lblPlayer4);
            Controls.Add(lblPlayer3);
            Controls.Add(lblPlayer2);
            Controls.Add(lblPlayer1);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(lblNumOfPlayers);
            Controls.Add(label2);
            Controls.Add(lblWelcome);
            Controls.Add(tbTeamName);
            Controls.Add(lblTeamName);
            Controls.Add(pbTitleImage);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "TeamRegistrationForm";
            Text = "Ultimate Flipper - Team Registration";
            FormClosing += TeamRegistrationForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbTitleImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbTitleImage;
        private Label lblTitle;
        private TextBox tbTeamName;
        private Label lblTeamName;
        private Label label2;
        private Label lblWelcome;
        private Label lblNumOfPlayers;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Label lblPlayer1;
        private Label lblPlayer2;
        private Label lblPlayer3;
        private Label lblPlayer4;
        private ComboBox cbPlayer1;
        private ComboBox cbPlayer2;
        private ComboBox cbPlayer3;
        private ComboBox cbPlayer4;
        private Button btnCancel;
        private Button btnSubmit;
        private Label lblError;
    }
}