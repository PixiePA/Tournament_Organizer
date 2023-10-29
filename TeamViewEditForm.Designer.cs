namespace Tournament_Tracker
{
    partial class TeamViewEditForm
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
            btnView = new Button();
            btnEdit = new Button();
            cbTeams = new ComboBox();
            lblChooseTeam = new Label();
            lblTeamName = new Label();
            lblPlayers = new Label();
            lblPlayerInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)pbTitleImage).BeginInit();
            SuspendLayout();
            // 
            // pbTitleImage
            // 
            pbTitleImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbTitleImage.Image = Properties.Resources.person;
            pbTitleImage.Location = new Point(220, 12);
            pbTitleImage.Name = "pbTitleImage";
            pbTitleImage.Size = new Size(75, 75);
            pbTitleImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTitleImage.TabIndex = 14;
            pbTitleImage.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(301, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(263, 45);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Team Edit / View";
            // 
            // btnView
            // 
            btnView.Location = new Point(163, 188);
            btnView.Name = "btnView";
            btnView.Size = new Size(150, 30);
            btnView.TabIndex = 15;
            btnView.Text = "View Team";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(471, 188);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 30);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Edit Team/Players";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // cbTeams
            // 
            cbTeams.FormattingEnabled = true;
            cbTeams.Location = new Point(303, 131);
            cbTeams.Name = "cbTeams";
            cbTeams.Size = new Size(300, 29);
            cbTeams.TabIndex = 18;
            // 
            // lblChooseTeam
            // 
            lblChooseTeam.AutoSize = true;
            lblChooseTeam.Location = new Point(181, 135);
            lblChooseTeam.Name = "lblChooseTeam";
            lblChooseTeam.Size = new Size(116, 21);
            lblChooseTeam.TabIndex = 17;
            lblChooseTeam.Text = "Choose a team:";
            // 
            // lblTeamName
            // 
            lblTeamName.AutoSize = true;
            lblTeamName.Location = new Point(163, 259);
            lblTeamName.Name = "lblTeamName";
            lblTeamName.Size = new Size(126, 21);
            lblTeamName.TabIndex = 19;
            lblTeamName.Text = "Team Name: XXX";
            lblTeamName.Visible = false;
            // 
            // lblPlayers
            // 
            lblPlayers.AutoSize = true;
            lblPlayers.Location = new Point(163, 319);
            lblPlayers.Name = "lblPlayers";
            lblPlayers.Size = new Size(63, 21);
            lblPlayers.TabIndex = 21;
            lblPlayers.Text = "Players:";
            lblPlayers.Visible = false;
            // 
            // lblPlayerInfo
            // 
            lblPlayerInfo.AutoSize = true;
            lblPlayerInfo.Location = new Point(232, 319);
            lblPlayerInfo.Name = "lblPlayerInfo";
            lblPlayerInfo.Size = new Size(0, 21);
            lblPlayerInfo.TabIndex = 22;
            lblPlayerInfo.Visible = false;
            // 
            // TeamViewEditForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(lblPlayerInfo);
            Controls.Add(lblPlayers);
            Controls.Add(lblTeamName);
            Controls.Add(cbTeams);
            Controls.Add(lblChooseTeam);
            Controls.Add(btnEdit);
            Controls.Add(btnView);
            Controls.Add(pbTitleImage);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "TeamViewEditForm";
            Text = "Ultimate Flippers - View / Edit";
            Load += TeamViewEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbTitleImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbTitleImage;
        private Label lblTitle;
        private Button btnView;
        private Button btnEdit;
        private ComboBox cbTeams;
        private Label lblChooseTeam;
        private Label lblTeamName;
        private Label lblPlayers;
        private Label lblPlayerInfo;
    }
}