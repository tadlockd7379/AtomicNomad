using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NomadLibrary
{
    public static class JsonUtilities
    {
        public static JObject FromFile(string file)
        {
            using (StreamReader stream = File.OpenText("./data/" + file + ".json"))
            using (JsonTextReader reader = new JsonTextReader(stream))
            {
                return (JObject)JToken.ReadFrom(reader);
            }
        }
    }
}
