using System;
using System.Collections.Generic;
using System.Configuration;
using System.Security.Principal;
using System.Windows.Forms;
using GetGroupsByUser;

namespace GetGroupsByUser
{
    public partial class ALAForm : Form
    {
        public ALAForm()
        {
            InitializeComponent();            
        }

        private void groupMembersButton_Click(object sender, EventArgs e)
        {
            ADUCCollection ADUCCollection = new ADUCCollection();
            if (groupNameTextBox.Text == "")
            {
                MessageBox.Show("Please insert text in the Group Name Box before clicking.");
                return;
            }
            ADUCCollection.getUsersByGroup(groupNameTextBox.Text);
        }

        private void userAccessButton_Click(object sender, EventArgs e)
        {
            ADUCCollection ADUCCollection = new ADUCCollection();
            if (userIDTextBox.Text == "")
            {
                MessageBox.Show("Please insert text in the User ID Box before clicking.");
                return;
            }
            string userID = userIDTextBox.Text;
            // RunScript for User Groups
            ADUCCollection.getGroupsbyUser(userID);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   This application is meant to be used for looking at " +
                " Users and groups. All you need to do is input" +
                " a User's Network ID or a Global group that you can find on the ADUC (Active" +
                " Directory Users and Computers) search and you will recieve the results in a CSV file.");
        }
    }
}
