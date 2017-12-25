using TwitterClone.Models;
using System.Web.Mvc;
using TwitterClone.DAL;
using System.Linq;

namespace TwitterApp.Controllers
{
    public class UserPostsController : Controller
    {

        //private PostContext db = new PostContext();

        public ActionResult Random()
        {
            UserPost post = new UserPost(001, "Jared", "Anderson", "This is Jared's first post.");
            //return View(db.UserPosts.ToList());
            return View(post);
        }
    }
}