using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Data_Store
{
    public class BlogDataStore
    {
        private static List<Blog> blogs;

        public BlogDataStore()
        {
            blogs = new List<Blog>
        {
            new Blog { Id = 1, Title = "Title 1" ,Text="Text 1" },
            new Blog { Id = 2, Title = "Title 2" ,Text="Text 2" },
            new Blog { Id = 3, Title = "Title 3" ,Text="Text 3" },

        };
        }
        public async Task AddBlog(Blog blog)
        {
            blogs.Add(blog);
            await Task.CompletedTask;
        }
        public async Task<IEnumerable<Blog>> GetAllBlogs() => await Task.FromResult(blogs);

        public async Task<Blog> GetBlogById(int id) =>
             await Task.FromResult(blogs.Single(p => p.Id == id));

        public async Task DeleteBlogById(int id)
        {
            var blog = blogs.Where(b => b.Id == id).SingleOrDefault();
            blogs.Remove(blog);
            await Task.CompletedTask;
        }
    }
}

