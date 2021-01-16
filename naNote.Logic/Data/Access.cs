using System.IO;
using System;
using Newtonsoft.Json;

namespace naNote.Logic.Data
{
    public static class Access
    {
        // TODO: Possibly replace this with a config file or something?
        private const string fileName = "naNoteDB.json";
        private const string filePath = @"\naNote\";

        private static string jsonSaveFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + filePath + fileName;

        public static void Save(Catalog catalogToSave)
        {
            // Start by checking whether or not the file actually exists
            if (!File.Exists(jsonSaveFile))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + filePath);
            }
            File.WriteAllText(jsonSaveFile, JsonConvert.SerializeObject(catalogToSave, Formatting.Indented));
        }

        public static Catalog Load()
        {
            return JsonConvert.DeserializeObject<Catalog>(File.ReadAllText(jsonSaveFile));
        }
    }
}
