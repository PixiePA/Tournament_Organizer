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
            ((System.ComponentModel.ISupportInitialize)pbTitleImage).BeginInit();
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
            // MinigameForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(lblWelcome);
            Controls.Add(pbTitleImage);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MinigameForm";
            Text = "Ultimate Flipper - Coin Flip";
            ((System.ComponentModel.ISupportInitialize)pbTitleImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private PictureBox pbTitleImage;
        private Label lblTitle;
    }
}