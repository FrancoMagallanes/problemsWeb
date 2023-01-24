using ProblemsWeb.Business.Interface;
using ProblemsWeb.Models;
using ProblemsWeb.Models.Dto;
using ProblemsWeb.Repository;
using ProblemsWeb.Repository.Interface;
using System;
using System.Collections.Generic;

namespace ProblemsWeb.Business
{
    public class SolutionBusiness : ISolutionBusiness
    {

        private readonly ISolutionRepository _solutionRepository;

        public SolutionBusiness(ISolutionRepository solutionRepository)
        {

            _solutionRepository = solutionRepository;


        }

        public int CreateUpdateSolution(Solution solution)
        {
            int response = _solutionRepository.CreateUpdateSolution(solution);
            return response;
        }

        public int CreateKeyword(KeyWord keyWord)
        {
            throw new NotImplementedException();
        }

        public List<KeyWord> FindAllKey()
        {
            throw new NotImplementedException();
        }

        public List<Solution> FindAllSlt()
        {
            return _solutionRepository.FindAllSlt();



        }

        public Solution GetSolutionById(int id)
        {
            return _solutionRepository.GetSolutionById(id);

        }

        public List<Solution> FindAllSltSearch(SearchDto searchDto)
        {
            return _solutionRepository.FindAllSltSearch(searchDto);
        }

        public int CreateLike(Like like)
        {
            return _solutionRepository.CreateLike(like);
        }

        public int DeleteKeyWord(int id)
        {
            return _solutionRepository.DeleteKeyWord(id);
        }
    }
}
