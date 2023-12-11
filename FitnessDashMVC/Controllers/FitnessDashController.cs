using FitnessDashMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitnessDashMVC.Controllers
{
    public class FitnessDashController : Controller
    {
        UserLogViewModel _userLogViewModel = new() { Date = DateTime.Now.Date, Steps = 10000, Weight = 182.4, Protein = 200, Fat = 100, Carbohydrates = 300, DailyReflection = "Test" };

        public static List<UserLogViewModel> userLogs = [];

        public static bool exists = false;


        public void AddListElement()
        {
            userLogs.Add(_userLogViewModel);
        }

        public IActionResult FitnessDash()
        {
            if(userLogs.Count == 0)
            {
            AddListElement();

            }
            return View(userLogs);
        }

        public IActionResult LogDay()
        {
            //Create new instance of UserLogViewModel
            var userLogVm = new UserLogViewModel();
            //Return LogDay view with userLog as parameter
            return View(userLogVm);
        }

        public IActionResult AddDailyLog(UserLogViewModel userLog)
        {
            List <DateTime> dates = [];

            foreach(var log in userLogs)
            {
                dates.Add(log.Date);
            }


            foreach (var log in userLogs)
            {

                if (dates.Contains(userLog.Date))
                {
                    exists = true;
                    return View(nameof(LogDay));
                }
                else
                {

                    //Adds user log to list
                    userLogs.Add(userLog);
                    //Redirects to index page
                    return RedirectToAction(nameof(FitnessDash));
                }

            }

            return RedirectToAction(nameof(FitnessDash));

        }

 
    }
}
