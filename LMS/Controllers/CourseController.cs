using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL.Managers.Interfaces;
using Model.Model;

namespace LMS.Controllers
{
    public class CourseController : ApiController
    {
        private readonly ICourseManager _courseManager;
        public CourseController(ICourseManager courseManager)  
        {
            _courseManager = courseManager;     
        }
      
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_courseManager.GetAll());
        }

        [HttpGet]
        public IHttpActionResult Get(int id){
            return Ok(_courseManager.GetCourseById(id));
        }

        [HttpPost]
        public IHttpActionResult Create(Course course)
        {
            return Ok(_courseManager.CreateCourse(course));
        }
}