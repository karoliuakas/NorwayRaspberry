using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
