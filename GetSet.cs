using System;

namespace NoteApi.Models
{
    public class NoteData
    {
        public string Content { get; set; } = string.Empty;
        public DateTime SavedAt { get; set; }
        public string Sender { get; set; } = string.Empty;
    }
}
