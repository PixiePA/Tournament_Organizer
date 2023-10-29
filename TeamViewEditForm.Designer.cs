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
            cbTeams = new ComboBox();
            lblChooseTeam = new Label();
            lblTeamName = new Label();
            lblPlayerInfo = new Label();
            tbName = new TextBox();
            lblPlayers = new Label();
            lbPlayers = new ListBox();
            lbAllPlayers = new ListBox();
            lblAllPlayers = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            lblArrow = new Label();
            label1 = new Label();
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
            // cbTeams
            // 
            cbTeams.FormattingEnabled = true;
            cbTeams.Location = new Point(186, 149);
            cbTeams.Name = "cbTeams";
            cbTeams.Size = new Size(300, 29);
            cbTeams.TabIndex = 18;
            cbTeams.SelectedIndexChanged += cbTeams_SelectedIndexChanged;
            // 
            // lblChooseTeam
            // 
            lblChooseTeam.AutoSize = true;
            lblChooseTeam.Location = new Point(64, 149);
            lblChooseTeam.Name = "lblChooseTeam";
            lblChooseTeam.Size = new Size(116, 21);
            lblChooseTeam.TabIndex = 17;
            lblChooseTeam.Text = "Choose a team:";
            // 
            // lblTeamName
            // 
            lblTeamName.AutoSize = true;
            lblTeamName.Location = new Point(64, 209);
            lblTeamName.Name = "lblTeamName";
            lblTeamName.Size = new Size(92, 21);
            lblTeamName.TabIndex = 19;
            lblTeamName.Text = "Team name:";
            lblTeamName.Visible = false;
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
            // tbName
            // 
            tbName.Location = new Point(162, 206);
            tbName.Name = "tbName";
            tbName.Size = new Size(324, 29);
            tbName.TabIndex = 23;
            tbName.Visible = false;
            // 
            // lblPlayers
            // 
            lblPlayers.AutoSize = true;
            lblPlayers.Location = new Point(483, 270);
            lblPlayers.Name = "lblPlayers";
            lblPlayers.Size = new Size(120, 21);
            lblPlayers.TabIndex = 21;
            lblPlayers.Text = "Current players:";
            lblPlayers.Visible = false;
            // 
            // lbPlayers
            // 
            lbPlayers.FormattingEnabled = true;
            lbPlayers.ItemHeight = 21;
            lbPlayers.Location = new Point(483, 294);
            lbPlayers.Name = "lbPlayers";
            lbPlayers.Size = new Size(245, 151);
            lbPlayers.TabIndex = 24;
            lbPlayers.Visible = false;
            // 
            // lbAllPlayers
            // 
            lbAllPlayers.FormattingEnabled = true;
            lbAllPlayers.ItemHeight = 21;
            lbAllPlayers.Location = new Point(64, 293);
            lbAllPlayers.Name = "lbAllPlayers";
            lbAllPlayers.Size = new Size(245, 151);
            lbAllPlayers.TabIndex = 26;
            lbAllPlayers.Visible = false;
            // 
            // lblAllPlayers
            // 
            lblAllPlayers.AutoSize = true;
            lblAllPlayers.Location = new Point(64, 269);
            lblAllPlayers.Name = "lblAllPlayers";
            lblAllPlayers.Size = new Size(85, 21);
            lblAllPlayers.TabIndex = 25;
            lblAllPlayers.Text = "All players:";
            lblAllPlayers.UseMnemonic = false;
            lblAllPlayers.Visible = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(347, 355);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.Location = new Point(236, 499);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 50);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.PaleGreen;
            btnSave.Location = new Point(414, 499);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 50);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblArrow
            // 
            lblArrow.AutoSize = true;
            lblArrow.Location = new Point(347, 331);
            lblArrow.Name = "lblArrow";
            lblArrow.Size = new Size(105, 21);
            lblArrow.TabIndex = 31;
            lblArrow.Text = "-------------->";
            lblArrow.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 102);
            label1.Name = "label1";
            label1.Size = new Size(379, 21);
            label1.TabIndex = 32;
            label1.Text = "Here you can change a team's name and add players!";
            // 
            // TeamViewEditForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(label1);
            Controls.Add(lblArrow);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(lbAllPlayers);
            Controls.Add(lblAllPlayers);
            Controls.Add(lbPlayers);
            Controls.Add(tbName);
            Controls.Add(lblPlayerInfo);
            Controls.Add(lblPlayers);
            Controls.Add(lblTeamName);
            Controls.Add(cbTeams);
            Controls.Add(lblChooseTeam);
            Controls.Add(pbTitleImage);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "TeamViewEditForm";
            Text = "Ultimate Flippers - View / Edit";
            FormClosing += TeamViewEditForm_FormClosing;
            Load += TeamViewEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbTitleImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbTitleImage;
        private Label lblTitle;
        private ComboBox cbTeams;
        private Label lblChooseTeam;
        private Label lblTeamName;
        private Label lblPlayerInfo;
        private TextBox tbName;
        private Label lblPlayers;
        private ListBox lbPlayers;
        private ListBox lbAllPlayers;
        private Label lblAllPlayers;
        private Button btnAdd;
        private Button btnCancel;
        private Button btnSave;
        private Label label1;
        private Label lblArrow;
    }
}