using ProblemsWeb.Business.Interface;
using ProblemsWeb.Models;
using ProblemsWeb.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemsWeb.Business
{
    public class SearchBusiness : ISearchBusiness
    {
        private readonly ISearchRepository _searchRepository;

        public SearchBusiness(ISearchRepository searchRepository)
        {
            _searchRepository = searchRepository;
        }   

        public int CreateSearch(Search search)
        {
           int response= _searchRepository.CreateSearch(search);
            return response;
        }
    }
}
