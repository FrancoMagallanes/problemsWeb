using ProblemsWeb.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemsWeb.Repository.Interface
{
    public interface ISearchRepository
    {
        int CreateSearch(Search search);
    }
}
