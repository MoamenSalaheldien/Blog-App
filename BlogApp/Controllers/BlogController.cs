using BlogApp.Command;
using BlogApp.Interfaces;
using BlogApp.Models;
using BlogApp.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BlogController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<ActionResult> GetBlogs()
        {

            var blogs = await _mediator.Send(new GetBlogsQuery());
             return Ok(blogs);
        }

        [HttpGet("{id:int}", Name = "GetBlogById")]
        public async Task<ActionResult> GetBlogById(int id)
        {
            var blog = await _mediator.Send(new GetBlogByIdQuery(id));
             return Ok(blog);
        }

        [HttpPost]
        public async Task<ActionResult> AddBlog([FromBody] Blog blog)
        {
                await _mediator.Send(new AddBlogCommand(blog));
                 return StatusCode(201);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteBlogById(int id)
        {
             await _mediator.Send(new DeleteBlogQuery(id));
              return Ok();
        }
    }
}