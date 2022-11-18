using Microsoft.AspNetCore.Mvc;

namespace ChatRoom.Controllers
{
    public class ChatController : Controller
    {
        public static Dictionary<int, string> Rooms = new Dictionary<int, string>()
        {
            {1, "Cerveza" },
            {2, "Programacion" },
            {3, "Chisme" }
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Room(int roomId)
        {
            return View("Room", roomId);
        }
    }
}
