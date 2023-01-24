using ProblemsWeb.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemsWeb.Business.Interface
{
    public interface ISearchBusiness
    {
        int CreateSearch(Search search);
    }
}
