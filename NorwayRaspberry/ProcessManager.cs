using Newtonsoft.Json;
using NorwayRaspberry.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorwayRaspberry
{
    public class ProcessManager
    {
        List<UserType> _users;
        public void AddUser(UserType user)
        {
            _users = LoadUsers();
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

    }
}
