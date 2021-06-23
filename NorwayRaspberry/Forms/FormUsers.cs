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
            UserType newUser = new UserType
            {
                Name = TextBoxName.Text,
                Surname = TextBoxSurname.Text
            };
            process.AddUser(newUser);
            process.LoadUsersToListBox();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<UserType> ab = process._users.Where(a => a.Valid == true).ToList();
            Guid index = ab[listBoxOfUsers.SelectedIndex].Id;
            process.DeleteUser(index);
        }
    }
}
