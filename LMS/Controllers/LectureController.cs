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
    public class LectureController : ApiController
    {
        private readonly ILectureManager _lectureManager;
        public LectureController(ILectureManager lectureManager)
        {
            _lectureManager = lectureManager;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_lectureManager.GetAll());
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Ok(_lectureManager.GetlectureById(id));
        }

        [HttpPost]
        public IHttpActionResult Create(Lecture lecture)
        {
            return Ok(_lectureManager.CreateLecture(lecture));
        }
    }