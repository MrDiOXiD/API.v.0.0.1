using System.Text.Json;
using NoteApi.Models;
using System.Text.Json.Serialization;

using Newtonsoft.Json;
using System.IO;
namespace NoteApi.Services
{
    public class FileNoteStore
    {
        private readonly string _filePath = "server_data.json";





        public void Save(NoteData note)
        {
            string json = JsonConvert.SerializeObject(note, Formatting.Indented);
            File.WriteAllText(_filePath, json);

        }

        public NoteData? Load()
        {
            if (!File.Exists(_filePath)) return null;
            var json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<NoteData>(json);
        }
    }
}
