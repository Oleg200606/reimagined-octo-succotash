using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationLibrary
{
    public class SerializeDeserialize
    {
        public static void Serialize<T>(T data, string filePath)
        {
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(filePath, json);
        }

        public static T Deserialize<T>(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
