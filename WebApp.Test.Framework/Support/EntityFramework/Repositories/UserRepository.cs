﻿using System.Linq;
using WebApp.Test.Framework.Support.EntityFramework.DomainClasses;

namespace WebApp.Test.Framework.Support.EntityFramework.Repositories
{
    public class UserRepository
    {
        private readonly DemoDbContext _context;

        public UserRepository(DemoDbContext context)
        {
            _context = context;
        }
        public User GetUserByLogin(string user_name)
        {
            return _context.Users
                .Where(n => n.user_name == user_name)
                .FirstOrDefault();
        }
    }
}
