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

        private Form1 menu;
        public PlayerRegistrationForm(Form1 menu)
        {

            InitializeComponent();
            this.menu = menu;
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
            this.Close();
            menu.Show();
        }

        private void PlayerRegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            tbPlayerEmail.Text = string.Empty;
            tbPlayerName.Text = string.Empty;
            cbTeams.Items.Clear();
        }
    }
}
