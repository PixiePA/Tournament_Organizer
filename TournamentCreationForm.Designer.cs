namespace Tournament_Tracker
{
    partial class TournamentCreationForm
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
            tbTournamentName = new TextBox();
            lblTournamentName = new Label();
            lblTournamentType = new Label();
            cbTournamentType = new ComboBox();
            lbTeamSelection = new ListBox();
            lbTeamFinal = new ListBox();
            lblAddArrows = new Label();
            lblRemoveArrows = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            btnCancel = new Button();
            btnSubmit = new Button();
            lblTeamsList = new Label();
            lblTeamsSelected = new Label();
            lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)pbTitleImage).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.ForeColor = SystemColors.ControlDarkDark;
            lblWelcome.Location = new Point(36, 115);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(712, 42);
            lblWelcome.TabIndex = 13;
            lblWelcome.Text = "Welcome to Tournament Creation! Please choose a tournament name, type, and the teams competing.\r\nPlease note that once you create a tournament, it will automatically start. Have Fun!\r\n";
            // 
            // pbTitleImage
            // 
            pbTitleImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbTitleImage.Image = Properties.Resources.person;
            pbTitleImage.Location = new Point(187, 12);
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
            lblTitle.Location = new Point(268, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(330, 45);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Tournament Creation";
            // 
            // tbTournamentName
            // 
            tbTournamentName.Location = new Point(187, 179);
            tbTournamentName.Name = "tbTournamentName";
            tbTournamentName.Size = new Size(400, 29);
            tbTournamentName.TabIndex = 15;
            // 
            // lblTournamentName
            // 
            lblTournamentName.AutoSize = true;
            lblTournamentName.Location = new Point(39, 183);
            lblTournamentName.Name = "lblTournamentName";
            lblTournamentName.Size = new Size(142, 21);
            lblTournamentName.TabIndex = 14;
            lblTournamentName.Text = "Tournament Name:";
            // 
            // lblTournamentType
            // 
            lblTournamentType.AutoSize = true;
            lblTournamentType.Location = new Point(39, 237);
            lblTournamentType.Name = "lblTournamentType";
            lblTournamentType.Size = new Size(132, 21);
            lblTournamentType.TabIndex = 16;
            lblTournamentType.Text = "Tournament Type:";
            // 
            // cbTournamentType
            // 
            cbTournamentType.FormattingEnabled = true;
            cbTournamentType.Items.AddRange(new object[] { "Single Elimination", "Double Elimination" });
            cbTournamentType.Location = new Point(187, 234);
            cbTournamentType.Name = "cbTournamentType";
            cbTournamentType.Size = new Size(400, 29);
            cbTournamentType.TabIndex = 17;
            // 
            // lbTeamSelection
            // 
            lbTeamSelection.FormattingEnabled = true;
            lbTeamSelection.ItemHeight = 21;
            lbTeamSelection.Location = new Point(106, 317);
            lbTeamSelection.Name = "lbTeamSelection";
            lbTeamSelection.Size = new Size(200, 88);
            lbTeamSelection.TabIndex = 18;
            // 
            // lbTeamFinal
            // 
            lbTeamFinal.FormattingEnabled = true;
            lbTeamFinal.ItemHeight = 21;
            lbTeamFinal.Location = new Point(478, 317);
            lbTeamFinal.Name = "lbTeamFinal";
            lbTeamFinal.Size = new Size(200, 88);
            lbTeamFinal.TabIndex = 19;
            // 
            // lblAddArrows
            // 
            lblAddArrows.AutoSize = true;
            lblAddArrows.Location = new Point(334, 339);
            lblAddArrows.Name = "lblAddArrows";
            lblAddArrows.Size = new Size(121, 21);
            lblAddArrows.TabIndex = 20;
            lblAddArrows.Text = " ---------------->";
            // 
            // lblRemoveArrows
            // 
            lblRemoveArrows.AutoSize = true;
            lblRemoveArrows.Location = new Point(334, 360);
            lblRemoveArrows.Name = "lblRemoveArrows";
            lblRemoveArrows.Size = new Size(121, 21);
            lblRemoveArrows.TabIndex = 21;
            lblRemoveArrows.Text = "<---------------- ";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(352, 317);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 25);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.Location = new Point(352, 380);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 25);
            btnRemove.TabIndex = 23;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.Location = new Point(228, 481);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 50);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.PaleGreen;
            btnSubmit.Location = new Point(406, 481);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 50);
            btnSubmit.TabIndex = 27;
            btnSubmit.Text = "Create Team";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblTeamsList
            // 
            lblTeamsList.AutoSize = true;
            lblTeamsList.Location = new Point(106, 293);
            lblTeamsList.Name = "lblTeamsList";
            lblTeamsList.Size = new Size(102, 21);
            lblTeamsList.TabIndex = 29;
            lblTeamsList.Text = "List of Teams:";
            // 
            // lblTeamsSelected
            // 
            lblTeamsSelected.AutoSize = true;
            lblTeamsSelected.Location = new Point(478, 293);
            lblTeamsSelected.Name = "lblTeamsSelected";
            lblTeamsSelected.Size = new Size(118, 21);
            lblTeamsSelected.TabIndex = 30;
            lblTeamsSelected.Text = "Teams Selected:";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(166, 442);
            lblError.Name = "lblError";
            lblError.Size = new Size(434, 15);
            lblError.TabIndex = 31;
            lblError.Text = "You must select 4, 8 or 16 teams. Tournament name and type must not be empty.";
            lblError.Visible = false;
            // 
            // TournamentCreationForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(784, 561);
            Controls.Add(lblError);
            Controls.Add(lblTeamsSelected);
            Controls.Add(lblTeamsList);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lblRemoveArrows);
            Controls.Add(lblAddArrows);
            Controls.Add(lbTeamFinal);
            Controls.Add(lbTeamSelection);
            Controls.Add(cbTournamentType);
            Controls.Add(lblTournamentType);
            Controls.Add(tbTournamentName);
            Controls.Add(lblTournamentName);
            Controls.Add(lblWelcome);
            Controls.Add(pbTitleImage);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "TournamentCreationForm";
            Text = "Ultimate Flipper - Tournament Creation";
            FormClosing += TournamentCreationForm_FormClosing;
            Load += TournamentCreationForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbTitleImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private PictureBox pbTitleImage;
        private Label lblTitle;
        private TextBox tbTournamentName;
        private Label lblTournamentName;
        private Label lblTournamentType;
        private ComboBox cbTournamentType;
        private ListBox lbTeamSelection;
        private ListBox lbTeamFinal;
        private Label lblAddArrows;
        private Label lblRemoveArrows;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnCancel;
        private Button btnSubmit;
        private Label lblTeamsList;
        private Label lblTeamsSelected;
        private Label lblError;
    }
}