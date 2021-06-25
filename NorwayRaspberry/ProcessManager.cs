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
        private readonly string _usersPath = @"DB\Users.json";
        private readonly string _statisticsPath = @"DB\PickedRaspberries.json";


        public ProcessManager()
        {
            LoadUsers();
            LoadStatistic();
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
            var a = _users.FindIndex(c => c.Id == id);
            _users[a].Valid = false;
            SaveUsers();

        }
        private void SaveUsers()
        {
            if (!Directory.Exists(@"DB")) Directory.CreateDirectory(@"DB");
            Misc.SaveJson(_users, _usersPath);
            LoadUsersToListBox();

        }
        public List<UserType> LoadUsers()
        {

            if (File.Exists(_usersPath))
            {
                if (new FileInfo(_usersPath).Length != 0)
                {
                    _users = Misc.LoadJson<List<UserType>>(_usersPath);
                    return _users;
                }
                else return _users;
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
            if (File.Exists(_statisticsPath))
            {
                if (new FileInfo(_statisticsPath).Length != 0)
                {
                    _statistics = Misc.LoadJson<List<CollectedStuffType>>(_statisticsPath);
                    return _statistics;
                }
                else return _statistics;
            }
            else
            {
                List<CollectedStuffType> a = new List<CollectedStuffType>();
                return a;
            }

        }
        public void AddStatistic(CollectedStuffType stuffObject)
        {
            _statistics.Add(stuffObject);
            SaveStatistics();

        }
        private void SaveStatistics()
        {
            if (!Directory.Exists(@"DB")) Directory.CreateDirectory(@"DB");
            Misc.SaveJson(_statistics, _statisticsPath);
            LoadStatistic();

        }



    }
}
