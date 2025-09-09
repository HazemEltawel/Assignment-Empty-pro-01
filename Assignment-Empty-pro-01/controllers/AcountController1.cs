using Microsoft.AspNetCore.Mvc;

namespace Assignment_Empty_pro_01.controllers
{
    public class AcountController1 : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
