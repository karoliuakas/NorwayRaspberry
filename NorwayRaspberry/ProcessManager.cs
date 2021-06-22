using Newtonsoft.Json;
using NorwayRaspberry.Objects;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NorwayRaspberry
{
    public class ProcessManager
    {
        public List<UserType> _users { get; set; } = new List<UserType>();
        public void AddUser(UserType user)
        {
            if (_users.Count() < 1) user.Id = 1;
            else user.Id = _users[_users.Count() - 1].Id + 1;
            _users.Add(user);

            string newJson = JsonConvert.SerializeObject(_users, Formatting.Indented);
            if (!Directory.Exists(@"DB")) Directory.CreateDirectory("DB");
            File.WriteAllText(@"DB\Users.json", newJson);

        }
        public List<UserType> LoadUsers()
        {
            using (StreamReader r = new StreamReader(@"DB\Users.json"))
            {
                string json = r.ReadToEnd();
                if (json.Length < 1)
                {
                    return _users;
                }
                else
                {
                    _users = JsonConvert.DeserializeObject<List<UserType>>(json);
                    return _users;
                }

            }
        }
        public void LoadUsersToListBox(ListBox listBox)
        {
            _users = LoadUsers();
            listBox.Items.Clear();
            foreach (UserType user in _users)
            {
                if (user.Valid) listBox.Items.Add(user.Name + " " + user.Surname);
            }

        }

    }
}
