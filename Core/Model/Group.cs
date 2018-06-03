using Core.Common;
using System;
using System.Collections.Generic;

namespace Core.Model
{
    public class Group : Entity
    {
        public Group()
        {
            Student = new HashSet<Student>();
        }

        public override int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Student> Student { get; set; }
    }
}
