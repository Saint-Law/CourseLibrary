using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLibrary.API.Profiles
{
    public class CoursesProfile : Profile
    {
        public CoursesProfile()
        {
            CreateMap<Entities.Course, Model.CourseDto>();
            CreateMap<Model.CourseForCreationDto, Entities.Course>();
            CreateMap<Model.CourseForUpdateDto, Entities.Course>();
            CreateMap<Entities.Course, Model.CourseForUpdateDto>();
        }
    }
}
