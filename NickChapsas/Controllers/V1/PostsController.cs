using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NickChapsas.Contracts.V1;
using NickChapsas.Domain;

namespace NickChapsas.Controllers
{
    [ApiController]
    [Route($"{ApiRoutes.Posts.GetAll}/"+"[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly List<Post> _posts;

        public PostsController()
        {
            _posts = new List<Post>();
            for (int i = 0; i < 5; i++)
            {
                _posts.Add(new Post(){Id = Guid.NewGuid().ToString()});
            }
        }

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(_posts);
        }
    }
}