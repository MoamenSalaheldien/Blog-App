using BlogApp.Data_Store;
using BlogApp.Models;
using BlogApp.Queries;
using MediatR;

namespace BlogApp.Handlers
{
    public class GetBlogsHandler : IRequestHandler<GetBlogsQuery, IEnumerable<Blog>>
    {
        private readonly BlogDataStore _blogDataStore;
        public GetBlogsHandler(BlogDataStore blogDataStore) => _blogDataStore = blogDataStore;

        public async Task<IEnumerable<Blog>> Handle(GetBlogsQuery request, CancellationToken cancellationToken)
        {
           return await _blogDataStore.GetAllBlogs();
        }
    }
}
