using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLibrary.API.Model
{
    public class AuthorForCreationDto
    {
        public string FIrstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateOfBirth{ get; set; } 
        public string MainCategory { get; set; }
    }
}
