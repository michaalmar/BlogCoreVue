using BlogNetCore.BLL.DTO;
using BlogNetCore.Contracts.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService postService;

        public PostsController(IPostService postService)
        {
            this.postService = postService;
        }


        [HttpPost]
        public async Task<ActionResult<PostDTO>> Post(PostDTO post)
        {
            if (ModelState.IsValid)
            {
                 postService.AddPost(post);
            }

            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<PostDTO>> Get()
        {
            var result = await postService.GetAll();
            return Ok(result);
        }
    }
}

