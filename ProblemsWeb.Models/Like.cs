using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemsWeb.Models
{
    public class Like : BaseEntity
    {
        public int SolutionId { get; set; }
        public string LikeType { get; set; }
        public int UserId { get; set; }


    }
}
