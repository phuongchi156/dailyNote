using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using noteAPI.Model;

namespace noteAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        public NoteController() { }

        [HttpGet("")]
        public String GetAllNote()
        {
            return "xin chào";
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewNote(NoteModel model)
        {
            return Ok();
        }
    }
}
