using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProblemsWeb.Models;
using System.Threading.Tasks;
using System;
using ProblemsWeb.Business.Interface;

namespace ProblemsWeb.Controllers.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SearchController : ControllerBase
    {

        private readonly ISearchBusiness _searchBusiness;

        public SearchController(ISearchBusiness searchBusiness)
        {
            _searchBusiness=searchBusiness; 

        }



        [HttpPost]
        public async Task<ActionResult<int>> CreateSearch(Search search)
        {
            try
            {
                int response = _searchBusiness.CreateSearch(search);

                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

    }
}
