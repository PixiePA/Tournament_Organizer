using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tournament_Tracker
{
    public partial class PlayerRegistrationForm : Form
    {
        public PlayerRegistrationForm()
        {
            InitializeComponent();
        }

        private void PlayerRegistrationForm_Load(object sender, EventArgs e)
        {
            // Load all teams into the team combo box
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Populate details into a new player object into the list and add the player into the team
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Empty out text fields and combo box.
            tbPlayerEmail.Text = string.Empty;
            tbPlayerName.Text = string.Empty;
            cbTeams.Items.Clear();

            // Load main menu
            Form1 menu = new Form1();
            menu.ShowDialog();
        }
    }
}
