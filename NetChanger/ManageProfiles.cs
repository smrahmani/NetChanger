﻿using System;
using System.Windows.Forms;

namespace NetChanger
{
    public partial class ManageProfiles : Form
    {
        public ManageProfiles()
        {
            InitializeComponent();
            Icon = Properties.Resources.MainIcon;
            // TODO: Create a duplicate button so user can make copy from available profiles.
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var editProfile = new SettingsForm( profilesLbx.SelectedItem.ToString() );
            editProfile.Show();
        }

        private void ManageProfiles_Load(object sender, EventArgs e)
        {
            profilesLbx.Items.Clear();
            foreach ( var item in Program.operations.Profiles ) {
                profilesLbx.Items.Add( item.Name );
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show( "Are you sure to delete this item ?? It cannot be undone.",
                                  "Confirm Delete!!",
                                  MessageBoxButtons.YesNo ) == DialogResult.Yes ) {
                var profileToDelete = Program.operations.Profiles.Find(
                    p => p.Name.ToLower().Equals( profilesLbx.SelectedItem.ToString() ) );
                Program.operations.Profiles.Remove( profileToDelete );
                Program.operations.UpdateProfilesFull();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            var createProfile = new SettingsForm( SettingsForm.NEW );
            createProfile.Show();
        }
    }
}
