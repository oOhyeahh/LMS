using AutoMapper;
using BL.Managers.Interfaces;
using Data.Repositories.Interfaces;
using Model.Dto.Model.Dto;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Managers
{
    public class CourseManager : ICourseManager
    {
        private ICourseRepository _courseRepository;

        public CourseManager(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public Course CreateCourse(Course course)
        {
            var result = _courseRepository.Add(course);
            return result;
        }

        public List<Course> GetAll()
        {
            return _courseRepository.Records.ToList();
        }

        public Course GetCourseById(int id)
        {
            return _courseRepository.GetById(id);
        }

    }
}
