using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProblemsWeb.Business.Interface;
using ProblemsWeb.Repository.Interface;
using System.Threading.Tasks;
using System;
using ProblemsWeb.Models;
using System.Collections.Generic;
using ProblemsWeb.Models.Dto;

namespace ProblemsWeb.Controllers.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SolutionController : ControllerBase
    {
        private readonly ISolutionBusiness _solutionBusiness;

        public SolutionController(ISolutionBusiness solutionBusiness)
        {

            _solutionBusiness = solutionBusiness;


        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateUpdateSolution(Solution solution)
        {
            try
            {
                int response = _solutionBusiness.CreateUpdateSolution(solution);

                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Solution>>> FindAllSlt()
        {
            try
            {
                var solutions = _solutionBusiness.FindAllSlt();

                if (solutions == null)
                    return NotFound();

                return Ok(solutions);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpGet]

        public async Task<ActionResult<Solution>> GetSolutionById(int id)
        {
            try
            {
                var solution = _solutionBusiness.GetSolutionById(id);

                if (solution == null)
                    return NotFound();

                return Ok(solution);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Solution>>> FindAllSltSearch(SearchDto searchDto)
        {
            try
            {
              var response = _solutionBusiness.FindAllSltSearch(searchDto);

                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpPost]
        public async Task<ActionResult<int>>CreateLike(Like like)
        {
            try
            {
                int response = _solutionBusiness.CreateLike(like);

                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpDelete]
        public async Task<ActionResult<int>> DeleteKeyWord(int id)
        {


            try
            {
                int response = _solutionBusiness.DeleteKeyWord(id);

                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }




        }
    }
}
