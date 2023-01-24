using System;
using System.Collections.Generic;

namespace ProblemsWeb.Models
{
    public class Solution : BaseEntity
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public int UserId { get; set; }
        public string SolutionGroup { get; set; }
        public List<KeyWord> ListKeyWord { get; set; }
    }
}
