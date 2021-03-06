﻿using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IStudentGroupClassRepository
    {
        Task<IEnumerable<StudentGroupClass>> GetStudentsByClassAsync(int classId);
    }
}
