using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Web.Mvc;
namespace SimpleBlog.Areas.Admin.Controllers
{
    public class PostsController : Controller 
    {
        public ActionResult Index()
        {
            return Content("Admin Posts !!");
        }
       
    }
}
