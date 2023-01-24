using ProblemsWeb.Models;
using ProblemsWeb.Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemsWeb.Repository.Interface
{
    public interface ISolutionRepository
    {

        int CreateUpdateSolution(Solution solution);
        List<Solution> FindAllSlt();
        int CreateKeyword(KeyWord keyWord);
        List<KeyWord> FindAllKey();
        List<Solution> FindAllSltSearch(SearchDto searchDto);
        int CreateLike(Like like);
        Solution GetSolutionById(int id);
        int DeleteKeyWord(int id);


    }
}
