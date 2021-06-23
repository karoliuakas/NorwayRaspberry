using Newtonsoft.Json;
using NorwayRaspberry.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NorwayRaspberry
{
    public class ProcessManager
    {
        public List<UserType> _users { get; set; } = new List<UserType>();
        public List<CollectedStuffType> _statistics { get; set; } = new List<CollectedStuffType>();
        public ListBox _listbox { get; set; }
        
        public ProcessManager()
        {
            LoadUsers();
        }
        public void AddUser(UserType user)
        {
            Guid g = Guid.NewGuid();
            user.Id = g;
            _users.Add(user);
            SaveUsers();
        }
        public void DeleteUser(Guid id)
        {
           var a =_users.FindIndex(c => c.Id == id);
            _users[a].Valid = false;
            SaveUsers();
            
        }
        private void SaveUsers()
        {
            string newJson = JsonConvert.SerializeObject(_users, Formatting.Indented);

            if (!Directory.Exists(@"DB")) Directory.CreateDirectory(@"DB");
            File.WriteAllText(@"DB\Users.json", newJson);
            LoadUsersToListBox();

        }
        public List<UserType> LoadUsers()
        {
            if (File.Exists(@"DB\Users.json"))
            {
                using (StreamReader r = new StreamReader(@"DB\Users.json"))
                {
                    string json = r.ReadToEnd();
                    _users = JsonConvert.DeserializeObject<List<UserType>>(json);
                    return _users;
                }
            }
            else
            {
                return _users;
            }
        }
        public void LoadUsersToListBox()
        {
            _users = LoadUsers();
            _listbox.Items.Clear();
            foreach (UserType user in _users)
            {
                if (user.Valid) _listbox.Items.Add(user.Name + " " + user.Surname);
            }

        }
        public List<CollectedStuffType> LoadStatistic()
        {
            if (File.Exists(@"DB\PickedRaspberries.json"))
            {
                using (StreamReader r = new StreamReader(@"DB\PickedRaspberries.json"))
                {
                    string json = r.ReadToEnd();
                    _statistics = JsonConvert.DeserializeObject<List<CollectedStuffType>>(json);
                    return _statistics;
                }
            }
            else
            {
                List<CollectedStuffType> a = new List<CollectedStuffType>();
                return a;
            }

        }
        public void AddStatistic(CollectedStuffType stuffObject)
        {
            LoadStatistic();
            _statistics.Add(stuffObject);
            SaveStatistics();

        }
        private void SaveStatistics()
        {
                string newJson = JsonConvert.SerializeObject(_statistics, Formatting.Indented);

                if (!Directory.Exists(@"DB")) Directory.CreateDirectory(@"DB");
                File.WriteAllText(@"DB\PickedRaspberries.json", newJson);

            
        }

     

    }
}
