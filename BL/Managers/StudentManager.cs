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
    public class StudentManager : IStudentManager
    {
        private IStudentReporsitory _studentRepository;

        public StudentManager(IStudentReporsitory studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Student CreateStudent(Student student1)
        {
            var student = new Student()
            {
                FirstName = "Max",
                LastName = "Chung",
                Gender = "Male",
                DateOfBirth = new DateTime(1987, 3, 24),
                Email = "test@test123.com",
                Credit = 16000
            };

            if (!_studentRepository.Records.Any(x => x.Email == "test@test123.com"))
            {
                _studentRepository.Add(student);
            }
            else
            {
                return _studentRepository.Records.Where(x => x.Email == student.Email).FirstOrDefault();
            }

            return student;
        }

        public StudentDto GetStudentById(int id)
        {
            return Mapper.Map<Student, StudentDto>(_studentRepository.GetById(id));
        }
    }

}
