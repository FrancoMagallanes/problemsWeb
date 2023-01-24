using ProblemsWeb.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemsWeb.Repository.Interface
{
    public interface IUserRepository
    {
        int CreateUser(User user);
    }
}
