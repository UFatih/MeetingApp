using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers
{
   
    public class MeetingController : Controller
    {
       /* [HttpGet] //Bunu yazmasak bile default olarak get methodu çalışır, "IActionResult" için
        public IActionResult Index()
        {
            return View();
        }  Index yerine direk thanks yazsaydık modelsiz şekilde çağırılabilirdi. Ondan aşağıda return view kısmına yazdık repository nin altına   */  

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
           /* Console.WriteLine(Name);
            Console.WriteLine(Phone);
            Console.WriteLine(Email);
            Console.WriteLine(WillAttend);*/

            if(ModelState.IsValid){
                Repository.CreateUser(model);
                ViewBag.UserCount = Repository.Users.Where(info=> info.WillAttend == true).Count();
                return View("thanks", model);
            } else {
                return View(model);
            }
            
        }

        [HttpGet]
        public IActionResult List()
        {
            return View(Repository.Users);
        }


        // meeting/details/2
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }

    }
    
}