using Core.Common;
using System;
using System.Collections.Generic;

namespace Core.Model
{
    public class Student : Entity
    {
        public Student()
        {
            StudentClass = new HashSet<StudentClass>();
        }

        public override int Id { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public int GroupId { get; set; }
        public string PhoneNumber { get; set; }

        public Group Group { get; set; }
        public ICollection<StudentClass> StudentClass { get; set; }
    }
}
