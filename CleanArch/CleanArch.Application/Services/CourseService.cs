using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;

        public CourseService(ICourseRepository courseRepository) => this.courseRepository = courseRepository;

        public async Task<CourseViewModel> GetCourses()
        {
            var vm = new CourseViewModel
            {
                Courses = await courseRepository.GetCourses()
            };

            return vm;
        }
    }
}
