using NorwayRaspberry.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorwayRaspberry.Forms
{
    public partial class FormUsers : Form
    {
        List<UserType> _listOfUsers;
        public FormUsers()
        {
            InitializeComponent();
            ProcessManager manager = new ProcessManager();
            _listOfUsers =  manager.LoadUsers();

        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            UserType newUser = new UserType
            {
                Name = TextBoxName.Text,
                Surname = TextBoxSurname.Text
            };
            ProcessManager abc = new ProcessManager();
            abc.AddUser(newUser);


        }
    }
}
