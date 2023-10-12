using BlogApp.Models;
using MediatR;

namespace BlogApp.Command
{
    public record AddBlogCommand(Blog Blog) : IRequest;
}
