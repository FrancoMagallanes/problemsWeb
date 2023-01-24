using Microsoft.EntityFrameworkCore;
using ProblemsWeb.Models;
using ProblemsWeb.Models.Dto;
using ProblemsWeb.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ProblemsWeb.Repository
{
    public class SolutionRepository : ISolutionRepository
    {

        private readonly ProblemsContext _context;

        public SolutionRepository(ProblemsContext context)
        {
            _context = context;
        }

        public int CreateUpdateSolution(Solution solution)
        {
            if (solution.Id == 0)
            {
                _context.Solution.Add(solution);
            }
            else
            {
                 var borrar = _context.KeyWord.Where(x => x.SolutionId == solution.Id
                && !solution.ListKeyWord.Select(x => x.Id).ToList().Contains(x.Id)).ToList();

                _context.KeyWord.RemoveRange(borrar);


                _context.Update(solution);
            }


            _context.SaveChanges();

            return solution.Id;
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
            return _context.Solution.ToList();
        }

        public Solution GetSolutionById(int id)
        {
            return _context.Solution.Include(x => x.ListKeyWord).Where(x => x.Id == id).FirstOrDefault();
        }
        public List<Solution> FindAllSltSearch(SearchDto searchDto)
        {
            List<Solution> response = new List<Solution>();

            var solutions = _context.Solution.Include(x => x.ListKeyWord).ToList();

            foreach (var solution in solutions)
            {
                bool toAdd = true;

                foreach (var kw in solution.ListKeyWord)
                {
                    if (!searchDto.ErrorCode.Contains(kw.KeyWords))
                    {
                        toAdd = false;
                        break;
                    }
                }

                if (toAdd)
                    response.Add(solution);
            }

            return response;
        }

        public int CreateLike(Like like)
        {
            _context.Like.Add(like);
            _context.SaveChanges();

            return like.Id;
        }

        public int DeleteKeyWord(int id)
        {
            var delete= _context.KeyWord.Where(x=>x.Id == id).ToList();
            _context.KeyWord.RemoveRange(delete);
            _context.SaveChanges();
            return delete.Count;

        }
    }
}

