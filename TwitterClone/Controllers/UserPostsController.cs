using TwitterClone.Models;
using System.Web.Mvc;

namespace TwitterApp.Controllers
{
    public class UserPostsController : Controller
    {
        public ActionResult Random()
        {
            var post = new UserPost(001, "Jared");
            return View(post);
        }
    }
}