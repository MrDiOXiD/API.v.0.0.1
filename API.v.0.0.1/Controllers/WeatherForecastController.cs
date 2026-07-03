



    using Microsoft.AspNetCore.Mvc;

/*using Microsoft.AspNetCore.Mvc;*/ // ← این خط را اضافه یا چک کن
// using Microsoft.AspNetCore.Components; // ← این خط را پاک کن یا کامنت کن اگر لازم نیست
using NoteApi.Models;

using NoteApi.Services;
//using NoteApi.Models;
//using NoteApi.Services;

namespace NoteApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NoteController : ControllerBase
    {
        public readonly FileNoteStore server_data;

        public NoteController(FileNoteStore store)
        {
            server_data = store;
        }

        // دریافت آخرین پیام
        [HttpGet]
        public IActionResult Get()
        {
            var note = server_data.Load();
            return note != null ? Ok(note) : NotFound("No data found.");
        }

        // ذخیره پیام جدید
        [HttpPost]
        public IActionResult Post([FromBody] NoteData note)
        {
            server_data.Save(note);
            return Ok(new { message = "Data persisted successfully." });
        }
    }

}