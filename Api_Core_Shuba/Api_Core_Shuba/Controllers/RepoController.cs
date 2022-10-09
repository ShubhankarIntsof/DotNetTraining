using Api_Core_Shuba.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Core_Shuba.Controllers
{
    public class RepoController : Controller
    {
        private readonly PostRepository _post;
        public RepoController(PostRepository postRepository)
        {
            _post = postRepository;
        }

        [HttpGet]
        [Route("api")]
        public IActionResult Index()
        {
            var post = _post.GetCategories();
            return View(post);
        }
    }
}
