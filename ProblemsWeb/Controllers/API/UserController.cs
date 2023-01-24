using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProblemsWeb.Business;
using ProblemsWeb.Business.Interface;
using ProblemsWeb.Models;
using System.Threading.Tasks;
using System;

namespace ProblemsWeb.Controllers.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBusiness _UserBusiness;

        public UserController(IUserBusiness UserBusiness)
        {

            _UserBusiness = UserBusiness;


        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateUser(User user)
        {
            try
            {
                int response = _UserBusiness.CreateUser(user);

                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
