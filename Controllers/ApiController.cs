using Microsoft.AspNetCore.Mvc; // For controller
using System.Collections.Generic; //For list
using myCalendar.Models; //For Task line 11
using System; //For DateTime

namespace myCalendar.Controllers{
    public class ApiController : Controller {

// Below is an API - Application Programming Interface
        public IActionResult Tasks(){

            var list = new List<Task>();

            var t1 = new Task();
            t1.Id = 1;
            t1.Title = "First task";
            t1.Notes = "This is the first task on my calender";
            t1.Important = true;
            t1.Date = DateTime.Now;
            list.Add(t1);

            var t2 = new Task(){
                Id = 2,
                Title = "Get Cheese",
                Notes = "Don't forget the cheese!",
                Important = true,
                Date = DateTime.Now               
            };
            list.Add(t2);

            var t3 = new Task(){
                Id = 3,
                Title = "Get a new TV",
                Notes = "Buy a new TV for the den",
                Important = true,
                Date = DateTime.Today.AddDays(1) // This makes it so the date is the next day
            };
            list.Add(t3);

            var t4 = new Task(){
                Id = 4,
                Title = "Walk the dog",
                Notes = "Make sure our fat dog goes for a walk!",
                Important = true,
                Date = DateTime.Today.AddDays(1) // This makes it so the date is the next day
            };
            list.Add(t4);

            return Json(list);
        }
    }
}