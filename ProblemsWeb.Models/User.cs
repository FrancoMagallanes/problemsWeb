using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemsWeb.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public User UserObj { get; set; }
    }
}
