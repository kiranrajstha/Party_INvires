using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Party_Invites.Models;

namespace Party_Invites.Controllers
{
    public class HomeController : Controller
    {
      public ViewResult Index() // This is the home page view
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good afternoon ";
            return View("MyView");  //  View("MyView") is an object type ViewResult !!
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View(); // Default view of RsvpForm.HTML
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse); // Store response from guest
            }
            else
            {
                //There is a validation error
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Reponses.Where(r => r.WillAttend == true));  // Uses the default action name
        }
    }
}
