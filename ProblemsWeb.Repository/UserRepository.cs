using ProblemsWeb.Models;
using ProblemsWeb.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemsWeb.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ProblemsContext _context;

        public UserRepository(ProblemsContext context)
        {
            _context = context;
        }

        public int CreateUser(User user)
        {
           _context.User.Add(user);
            _context.SaveChanges();
            return user.Id;
        }
    }
}
