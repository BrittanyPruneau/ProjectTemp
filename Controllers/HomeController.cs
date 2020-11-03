using Microsoft.AspNetCore.Mvc;
using ProjectPage1and2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
 

namespace ProjectPage1and2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SecondPage()
        {
            return View();
        }
        [HttpGet]  
        public IActionResult  AddTool()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult AddTool(ToolsResourcesAdvice t) // passing in model 
        {
            if (ModelState.IsValid)  // checking to see if the model is valid
            {
                return View("ToolDetails", t);  // returning the view
            }
            else 
            {
                return View(t);
            }
        }

        [HttpGet]
        public IActionResult EditTool()
        {
            // Go To Database with the id and get the peak with that id 
            // Fake out a totally lame o database

            ToolsResourcesAdvice t = new ToolsResourcesAdvice();
            t.toolID = 1;
            t.toolName = "Shovel";
            t.giftedTo = "Green Team Farm";
            t.giftedFrom = "George Bloomy";
            t.phoneNumber = "248-485-8887";
            t.address = "786 Hidden Pines Trail";
            return View(t);


        }
        [HttpPost]
        public IActionResult EditTool(ToolsResourcesAdvice t)
        {
            if (ModelState.IsValid)  // checking to see if the model is valid
            {
                return View("ToolDetails", t);  // returning the view
            }
            else
            {
                return View(t);
            }
        }

    }
}
