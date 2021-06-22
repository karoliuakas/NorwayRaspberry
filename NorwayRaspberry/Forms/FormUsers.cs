using NorwayRaspberry.Objects;
using System;
using System.Windows.Forms;

namespace NorwayRaspberry.Forms
{
    public partial class FormUsers : Form
    {
        ProcessManager process = new ProcessManager();
        public FormUsers()
        {
            InitializeComponent();
            process.LoadUsersToListBox(listBoxOfUsers);
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            UserType newUser = new UserType
            {
                Name = TextBoxName.Text,
                Surname = TextBoxSurname.Text
            };
            process.AddUser(newUser);
            process.LoadUsersToListBox(listBoxOfUsers);


        }

    }
}
