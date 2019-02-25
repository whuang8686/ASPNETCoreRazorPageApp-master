using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
namespace AdminPanelTutorial
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}