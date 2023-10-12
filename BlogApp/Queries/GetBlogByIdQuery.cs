using BlogApp.Models;
using MediatR;

namespace BlogApp.Queries
{
    public record GetBlogByIdQuery(int Id): IRequest<Blog>;
}
