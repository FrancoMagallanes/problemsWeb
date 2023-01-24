using ProblemsWeb.Business.Interface;
using ProblemsWeb.Models;
using ProblemsWeb.Repository;
using ProblemsWeb.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemsWeb.Business
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepository _UserRepository;

        public UserBusiness(IUserRepository UserRepository)
        {

            _UserRepository = UserRepository;


        }
        public int CreateUser(User user)
        {
            int response = _UserRepository.CreateUser(user);
            return response;
        }
    }
}
