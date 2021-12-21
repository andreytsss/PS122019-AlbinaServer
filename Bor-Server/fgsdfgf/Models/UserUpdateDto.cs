using System;
using System.Collections.Generic;
using System.Text;

namespace Bor.Core.Models
{
   public class UserUpdateDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
    }
}
