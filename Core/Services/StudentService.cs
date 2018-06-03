using Core.Interfaces;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> _studentRepository;
        private readonly IStudentGroupClassRepository _studentGroupClassRepository;

        public StudentService(IRepository<Student> studentRepository, IStudentGroupClassRepository studentGroupClassRepository)
        {
            _studentGroupClassRepository = studentGroupClassRepository;
            _studentRepository = studentRepository;
        }
        public Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<StudentGroupClass>> GetStudentsByClassAsync(int classId)
        {
            return await _studentGroupClassRepository.GetStudentsByClassAsync(classId);
        }
    }
}
