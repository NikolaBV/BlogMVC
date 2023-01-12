using BlogMVC.Context;
using BlogMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogMVC.Controllers
{
    public class BlogController : Controller
    {
        BlogContext db;
        public BlogController(BlogContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Blog> Blogs = db.Blogs.Select(b => b).ToList();
            return View(Blogs);
        }
        public IActionResult Delete(int id)
        {
            Blog Blogs = db.Blogs.FirstOrDefault(b => b.Id == id);
            if(id != null)
            {
                db.Remove(Blogs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
