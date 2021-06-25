using NorwayRaspberry.Objects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace NorwayRaspberry.Forms
{
    public partial class FormUsers : Form
    {
        ProcessManager process = new ProcessManager ();
         public FormUsers()
        {
            InitializeComponent();
            process._listbox = listBoxOfUsers;
            process.LoadUsersToListBox();
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TextBoxName.Text) || string.IsNullOrEmpty(TextBoxSurname.Text))
            {
                MessageBox.Show("Užpildykite visus laukus");
                return;
            }
            UserType newUser = new UserType
            {
                Name = TextBoxName.Text,
                Surname = TextBoxSurname.Text
            };
            process.AddUser(newUser);
            process.LoadUsersToListBox();


        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            List<UserType> listWithValidUsers = process._users.Where(a => a.Valid == true).ToList();
            if (listBoxOfUsers.SelectedIndex == -1)
            {
                MessageBox.Show("Pasirinkite varototoją");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Ar tikrai norite ištrinti šį rinkėją", "Naudotojo ištrynimas", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Guid index = listWithValidUsers[listBoxOfUsers.SelectedIndex].Id;
                process.DeleteUser(index);
            }
            
        }
    }
}
