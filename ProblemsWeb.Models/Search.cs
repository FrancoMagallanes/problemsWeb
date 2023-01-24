using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemsWeb.Models
{
    public class Search : BaseEntity
    {
        public string Text { get; set; }
        public int FoundCount { get; set; }   
    }
}
