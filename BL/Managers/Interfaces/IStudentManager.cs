﻿using Model.Dto.Model.Dto;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Managers.Interfaces
{
    public interface IStudentManager
    {
        Student CreateStudent(Student student);

        StudentDto GetStudentById(int id);
    }
}

