using Newtonsoft.Json;
using NorwayRaspberry.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorwayRaspberry
{
    public class ProcessManager
    {
        List<UserType> _users;
        public void AddUser(UserType user)
        {
            _users = LoadUsers();
            user.Id = _users[_users.Count() - 1].Id + 1;
            _users.Add(user);

            string newJson =   JsonConvert.SerializeObject(_users, Formatting.Indented);
            File.WriteAllText(@"C:\Users\Karolis\source\repos\NorwayRaspberry\DB\Users.json", newJson);

        }
        public List<UserType> LoadUsers()
        {
            using (StreamReader r = new StreamReader(@"C:\Users\Karolis\source\repos\NorwayRaspberry\DB\Users.json"))
            {
                string json = r.ReadToEnd();
              List<UserType> myDeserializedClass = JsonConvert.DeserializeObject<List<UserType>>(json);
                return myDeserializedClass;
            }
        }
        public void LoadUsersToListBox(ListBox listBox)
        {
            _users = LoadUsers();
            listBox.Items.Clear();
            foreach (UserType user in _users)
            {
                if(user.Valid) listBox.Items.Add(user.Name + " " + user.Surname);
            }

        }

    }
}
