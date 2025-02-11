﻿using BlogSitesi.Entity;

namespace BlogSitesi.Data.Abstract
{
    public interface IUserRepository
    {
        IQueryable<User> Users { get; }
        void CreateUser(User User);
    }
}
