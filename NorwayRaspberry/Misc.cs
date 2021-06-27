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
   public class Misc
    {
        public static void SaveJson<T>(T data, string filename, bool formatIndented = true)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    if (formatIndented) serializer.Formatting = Formatting.Indented;

                    serializer.Serialize(writer, data);
                }
            }
        }
        public static T LoadJson<T>(string filename)
        {
            T jsonObject;

            using (StreamReader sr = new StreamReader(filename))
            {
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    jsonObject = serializer.Deserialize<T>(reader);
                }
            }

            return jsonObject;
        }
        public static void LoadUsersToComboBox(ComboBox comboBox, bool loadOnlyValidUsers = true)
        {
            ProcessManager process = new ProcessManager();
            if (process._users.Count > 0)
            {
                Dictionary<Guid, string> comboSource = new Dictionary<Guid, string>();
            foreach (UserType user in process._users)
            {
                    if (loadOnlyValidUsers)
                    {
                        if (user.Valid) comboSource.Add(user.Id, user.Name + " " + user.Surname);
                    }
                    else
                    {
                        comboSource.Add(user.Id, user.Name + " " + user.Surname + (!user.Valid?" [Ištrintas]":""));
                    }
                }

                
            comboBox.DataSource = new BindingSource(comboSource, null);
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";

            }
                
        }
    }
}
