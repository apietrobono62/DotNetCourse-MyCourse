using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mycourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index(){
            return  Content("sono action");
        }
        public IActionResult Detail(string id){
            return  Content($"sono Detail e ho ricevuto l'id {id}");
        }

    }

}