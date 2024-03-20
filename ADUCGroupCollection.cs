using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Text;
using System.Runtime.CompilerServices;

namespace GetGroupsByUser
{
    public class ADUCCollection
    {       
        public void getGroupsbyUser(string userID) {
            using (PrincipalContext domainContext = new PrincipalContext(ContextType.Domain, "%DOMAIN_CONTROLLER%"))
            {
                List<string> groupList = new List<string>();
                // Find the user
                UserPrincipal user = UserPrincipal.FindByIdentity(domainContext, IdentityType.SamAccountName, userID);

                if (user != null)
                {
                    // Get the authorization groups
                    var groups = user.GetGroups();

                    foreach (Principal group in groups)
                    {
                        groupList.Add(group.Name);
                    }

                    // Export to CSV
                    bool isExported = exportToCSV(groupList);

                    if (isExported == true) 
                    {
                        MessageBox.Show("Group List completed and Saved!");
                    }
                    else
                    {
                        MessageBox.Show("Export path invalid");
                    }
                    
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }
        }

        public void getUsersByGroup(string groupID)
        {
            string defaultPath = ConfigurationManager.AppSettings["defaultExportPath"];
            List<string> userList = new List<string>();
            using (PrincipalContext context = new PrincipalContext(ContextType.Domain, "%DOMAIN_CONTROLLER%"))
            {
                GroupPrincipal group = GroupPrincipal.FindByIdentity(context, groupID);

                if (group != null)
                {                   

                    foreach (Principal principal in group.GetMembers())
                    {
                        if (principal is UserPrincipal user)
                        {
                            userList.Add(user.Name);                         
                        }
                    }

                    // Export to CSV
                    bool isExported = exportToCSV(userList);

                    if (isExported == true)
                    {
                        MessageBox.Show("User List completed and Saved!");
                    }
                    else
                    {
                        MessageBox.Show("Export path invalid.");
                    }
                }
                else
                {
                    MessageBox.Show("Group not found.");
                }
            }
        }        
        private bool exportToCSV(List<string> resultsList)
        {
            // Open a folder dialog to ask where the file should be exported.
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = "C:\\";
            saveFile.Filter = "CSV Files (*.csv)|*.csv";          
            if (saveFile.ShowDialog() == DialogResult.OK)
            {                
                string filePath = saveFile.FileName;

                // Write all lines to a file
                File.WriteAllLines(filePath, resultsList);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
