using Microsoft.AspNetCore.Mvc; // For controller
using System.Collections.Generic; //For list
using myCalendar.Models; //For Task line 11
using System; //For DateTime
using System.Linq; // For ToList()

namespace myCalendar.Controllers{
    public class ApiController : Controller {

        private DataContext database;
        public ApiController(DataContext db){
            this.database = db;
        }
// Below is an API - Application Programming Interface
        public IActionResult Tasks(){

            //read from DB

            var list = database.TasksTable.ToList();

            return Json(list);
        }

        [HttpPost]
        public IActionResult CreateTask( [FromBody] Task theTask ){
            database.TasksTable.Add(theTask);
            database.SaveChanges();

            return Json(theTask);
        }
    }
}