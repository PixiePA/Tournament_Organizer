namespace Tournament_Tracker
{
    partial class PlayerRegistrationForm
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
            lblTitle = new Label();
            pbTitleImage = new PictureBox();
            lblPlayerName = new Label();
            lblPlayerEmail = new Label();
            tbPlayerName = new TextBox();
            tbPlayerEmail = new TextBox();
            label1 = new Label();
            cbTeams = new ComboBox();
            lblWelcome = new Label();
            label2 = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pbTitleImage).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(299, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(294, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Player Registration";
            // 
            // pbTitleImage
            // 
            pbTitleImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbTitleImage.Image = Properties.Resources.person;
            pbTitleImage.Location = new Point(218, 12);
            pbTitleImage.Name = "pbTitleImage";
            pbTitleImage.Size = new Size(75, 75);
            pbTitleImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTitleImage.TabIndex = 1;
            pbTitleImage.TabStop = false;
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Location = new Point(48, 204);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(55, 21);
            lblPlayerName.TabIndex = 2;
            lblPlayerName.Text = "Name:";
            // 
            // lblPlayerEmail
            // 
            lblPlayerEmail.AutoSize = true;
            lblPlayerEmail.Location = new Point(48, 267);
            lblPlayerEmail.Name = "lblPlayerEmail";
            lblPlayerEmail.Size = new Size(51, 21);
            lblPlayerEmail.TabIndex = 3;
            lblPlayerEmail.Text = "Email:";
            // 
            // tbPlayerName
            // 
            tbPlayerName.Location = new Point(109, 201);
            tbPlayerName.Name = "tbPlayerName";
            tbPlayerName.Size = new Size(200, 29);
            tbPlayerName.TabIndex = 4;
            // 
            // tbPlayerEmail
            // 
            tbPlayerEmail.Location = new Point(109, 264);
            tbPlayerEmail.Name = "tbPlayerEmail";
            tbPlayerEmail.Size = new Size(300, 29);
            tbPlayerEmail.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 330);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 6;
            label1.Text = "Choose a team:";
            // 
            // cbTeams
            // 
            cbTeams.FormattingEnabled = true;
            cbTeams.Location = new Point(170, 327);
            cbTeams.Name = "cbTeams";
            cbTeams.Size = new Size(400, 29);
            cbTeams.TabIndex = 7;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.ForeColor = SystemColors.ControlDarkDark;
            lblWelcome.Location = new Point(48, 120);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(689, 21);
            lblWelcome.TabIndex = 8;
            lblWelcome.Text = "Welcome to Player Registration! Please enter your name and email, as well as selecting your team!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(48, 141);
            label2.Name = "label2";
            label2.Size = new Size(518, 21);
            label2.TabIndex = 9;
            label2.Text = "Please note that if you don't have a team, you will need to create one first.";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.PaleGreen;
            btnSubmit.Location = new Point(406, 456);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 50);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Create Player";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.Location = new Point(228, 456);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 50);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // PlayerRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(label2);
            Controls.Add(lblWelcome);
            Controls.Add(cbTeams);
            Controls.Add(label1);
            Controls.Add(tbPlayerEmail);
            Controls.Add(tbPlayerName);
            Controls.Add(lblPlayerEmail);
            Controls.Add(lblPlayerName);
            Controls.Add(pbTitleImage);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "PlayerRegistrationForm";
            Text = "Ultimate Flipper - Player Registration";
            FormClosing += PlayerRegistrationForm_FormClosing;
            Load += PlayerRegistrationForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbTitleImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox pbTitleImage;
        private Label lblPlayerName;
        private Label lblPlayerEmail;
        private TextBox tbPlayerName;
        private TextBox tbPlayerEmail;
        private Label label1;
        private ComboBox cbTeams;
        private Label lblWelcome;
        private Label label2;
        private Button btnSubmit;
        private Button btnCancel;
    }
}