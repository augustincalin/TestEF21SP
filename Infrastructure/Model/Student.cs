using System;
using System.Collections.Generic;

namespace Infrastructure.Model
{
    public partial class Student
    {
        public Student()
        {
            StudentClass = new HashSet<StudentClass>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public int GroupId { get; set; }
        public string PhoneNumber { get; set; }

        public Group Group { get; set; }
        public ICollection<StudentClass> StudentClass { get; set; }
    }
}
