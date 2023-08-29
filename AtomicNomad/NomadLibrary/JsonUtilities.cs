using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NomadLibrary
{
    public static class JsonUtilities
    {
        public static JObject JSONFromFile(string file)
        {
            using (StreamReader stream = File.OpenText("./data/" + file + ".json"))
            using (JsonTextReader reader = new JsonTextReader(stream))
            {
                return (JObject) JToken.ReadFrom(reader);
            }
        }

        public static Dictionary<string, T> DictionaryFromFile<T>(string file)
        {
            Dictionary<string, T> dictionary = new Dictionary<string, T>();

            foreach (var data in JSONFromFile(file))
            {
                JObject jsonObject = JObject.Parse(data.Value.ToString());
                jsonObject["id"] = data.Key;

                T deserialized = JsonConvert.DeserializeObject<T>(jsonObject.ToString());

                dictionary.Add(data.Key, deserialized);
            }

            return dictionary;
        }
    }
}
