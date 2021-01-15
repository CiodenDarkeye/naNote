using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace naNote.Logic.Data
{
    public static class Access
    {
        private static string jsonConfigFile = @"C:\Users\Will Jones\OneDrive\Code\c#\naNoteCLI\config.json";

        public static void Save(Catalog catalogToSave)
        {
            File.WriteAllText(jsonConfigFile, JsonConvert.SerializeObject(catalogToSave, Formatting.Indented));
        }

        public static Catalog Load()
        {
            return JsonConvert.DeserializeObject<Catalog>(File.ReadAllText(jsonConfigFile));
        }
    }
}
