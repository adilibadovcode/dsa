using Twitter.Core.Entities;
using Twitter.DAL.Contexts;

namespace Twitter.Business.Repositories.Implements
{
    public class CommentRepository : GenericRepository<Comment>
    {
        public CommentRepository(TwitterContext context) : base(context)
        {
        }
    }
}
