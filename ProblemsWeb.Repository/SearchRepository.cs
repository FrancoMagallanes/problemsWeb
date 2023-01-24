using ProblemsWeb.Models;
using ProblemsWeb.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemsWeb.Repository
{
    public class SearchRepository : ISearchRepository
    {
        private readonly ProblemsContext _context;

        public SearchRepository(ProblemsContext context)
        {
            _context = context;
        }
        public int CreateSearch(Search search)
        {
            _context.Add(search);
            _context.SaveChanges();
            return search.Id;
        }
    }
}
