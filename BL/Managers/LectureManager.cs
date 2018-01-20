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
    public class LectureManager : ILectureManager
    {
        private ILectureRepository _lectureRepository;

        public LectureManager(ILectureRepository lectureRepository)
        {
            _lectureRepository = lectureRepository;
        }
        public Lecture CreateLecture(Lecture lecture)
        {
            var result = _lectureRepository.Add(lecture);
            return result;
        }

        public List<Lecture> GetAll()
        {
            return _lectureRepository.Records.ToList();
        }

        public Lecture GetlectureById(int id)
        {
            return _lectureRepository.GetById(id);
        }

    }
