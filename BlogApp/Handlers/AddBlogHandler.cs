using BlogApp.Command;
using BlogApp.Data_Store;
using MediatR;

namespace BlogApp.Handlers
{
    public class AddBlogHandler : IRequestHandler<AddBlogCommand>
    {
        private readonly BlogDataStore _blogDataStore;

        public AddBlogHandler(BlogDataStore blogDataStore) => _blogDataStore=blogDataStore;
        public async Task Handle(AddBlogCommand request, CancellationToken cancellationToken)
        {
            await _blogDataStore.AddBlog(request.Blog);

            return;
        }
    }
}
