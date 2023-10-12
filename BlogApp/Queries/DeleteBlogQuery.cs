using MediatR;

namespace BlogApp.Queries
{
    public record DeleteBlogQuery(int id):IRequest
    {
    }
}
