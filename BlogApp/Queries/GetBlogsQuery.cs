using BlogApp.Models;
using MediatR;

namespace BlogApp.Queries
{
    public class GetBlogsQuery : IRequest<IEnumerable<Blog>>
    {
    }
}
