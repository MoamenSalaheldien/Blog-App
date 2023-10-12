using BlogApp.Data_Store;
using BlogApp.Queries;
using MediatR;

namespace BlogApp.Handlers
{
    public class DeleteBlogHandler : IRequestHandler<DeleteBlogQuery>
    {
        private readonly BlogDataStore _blogDataStore;
        public DeleteBlogHandler(BlogDataStore blogDataStore) => _blogDataStore = blogDataStore;
        public async Task Handle(DeleteBlogQuery request,
            CancellationToken cancellationToken) => await _blogDataStore.DeleteBlogById(request.id);
    }
}
