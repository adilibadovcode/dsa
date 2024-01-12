﻿using Twitter.Business.Repositories.Interfaces;
using Twitter.Core.Entities;
using Twitter.DAL.Contexts;

namespace Twitter.Business.Repositories.Implements;

public class PostRepository : GenericRepository<Post>, IPostRepository
{
    public PostRepository(TwitterContext context) : base(context)
    {
    }
}
