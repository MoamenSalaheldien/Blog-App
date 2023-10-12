using BlogApp.Data_Store;
using BlogApp.Models;
using BlogApp.Queries;
using MediatR;

namespace BlogApp.Handlers
{
    public class GetBlogByIdHadler: IRequestHandler<GetBlogByIdQuery, Blog>
    {
        private readonly BlogDataStore _blogDataStore;
        public GetBlogByIdHadler(BlogDataStore blogDataStore) => _blogDataStore = blogDataStore;
        public async Task<Blog> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken) =>
            await _blogDataStore.GetBlogById(request.Id);
    }
}
