using Core.Interfaces;
using Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class StudentGroupClassRepository : AggregateRepository<StudentGroupClass>, IStudentGroupClassRepository
    {
        public StudentGroupClassRepository(DbContext context) : base(context)
        {

        }
        public async Task<IEnumerable<StudentGroupClass>> GetStudentsByClassAsync(int classId)
        {
            return await _entities.FromSql($"EXEC GetStudentsFromClass {classId}").ToListAsync();
        }
    }
}
