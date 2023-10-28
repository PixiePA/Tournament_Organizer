namespace Tournament_Tracker
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
            lblTitle = new Label();
            btnPlayerRegistration = new Button();
            pbTitleImage = new PictureBox();
            btnTeamRegistration = new Button();
            btnTournamentCreation = new Button();
            ((System.ComponentModel.ISupportInitialize)pbTitleImage).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(339, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(188, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Main Menu";
            // 
            // btnPlayerRegistration
            // 
            btnPlayerRegistration.Location = new Point(298, 146);
            btnPlayerRegistration.Name = "btnPlayerRegistration";
            btnPlayerRegistration.Size = new Size(200, 50);
            btnPlayerRegistration.TabIndex = 2;
            btnPlayerRegistration.Text = "Player Registration";
            btnPlayerRegistration.UseVisualStyleBackColor = true;
            btnPlayerRegistration.Click += btnPlayerRegistration_Click;
            // 
            // pbTitleImage
            // 
            pbTitleImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbTitleImage.Image = Properties.Resources.person;
            pbTitleImage.Location = new Point(258, 12);
            pbTitleImage.Name = "pbTitleImage";
            pbTitleImage.Size = new Size(75, 75);
            pbTitleImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTitleImage.TabIndex = 3;
            pbTitleImage.TabStop = false;
            // 
            // btnTeamRegistration
            // 
            btnTeamRegistration.Location = new Point(298, 220);
            btnTeamRegistration.Name = "btnTeamRegistration";
            btnTeamRegistration.Size = new Size(200, 50);
            btnTeamRegistration.TabIndex = 4;
            btnTeamRegistration.Text = "Team Registration";
            btnTeamRegistration.UseVisualStyleBackColor = true;
            btnTeamRegistration.Click += btnTeamRegistration_Click;
            // 
            // btnTournamentCreation
            // 
            btnTournamentCreation.Location = new Point(298, 294);
            btnTournamentCreation.Name = "btnTournamentCreation";
            btnTournamentCreation.Size = new Size(200, 50);
            btnTournamentCreation.TabIndex = 5;
            btnTournamentCreation.Text = "Tournament Creation";
            btnTournamentCreation.UseVisualStyleBackColor = true;
            btnTournamentCreation.Click += btnTournamentCreation_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(784, 561);
            Controls.Add(btnTournamentCreation);
            Controls.Add(btnTeamRegistration);
            Controls.Add(pbTitleImage);
            Controls.Add(btnPlayerRegistration);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Ultimate Flipper - Main Menu";
            ((System.ComponentModel.ISupportInitialize)pbTitleImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnPlayerRegistration;
        private PictureBox pbTitleImage;
        private Button btnTeamRegistration;
        private Button btnTournamentCreation;
    }
}