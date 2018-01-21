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
    public class StudentController : ApiController
    {
        private readonly IStudentManager _studentManager;

        public StudentController(IStudentManager studentManager)
        {
            _studentManager = studentManager;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_studentManager.GetAll());
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Ok(_studentManager.GetStudentById(id));
        }

        [HttpPost]
        public IHttpActionResult Create(Student student)
        {
            return Ok(_studentManager.CreateStudent(student));
        }
    }
}