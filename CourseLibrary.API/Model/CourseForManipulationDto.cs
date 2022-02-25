using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLibrary.API.Model
{
    public abstract class CourseForManipulationDto
    {
        [Required(ErrorMessage = "you should fill out a title")]
        [MaxLength(100, ErrorMessage = "the title should not have more than 100 characters.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "you should fill out a title")]
        [MaxLength(1500, ErrorMessage = "the description should not have more than 1500 characters.")]
        public string Description { get; set; }
    }
}
