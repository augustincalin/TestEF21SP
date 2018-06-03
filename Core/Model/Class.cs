using Core.Common;
using System;
using System.Collections.Generic;

namespace Core.Model
{
    public class Class : Entity
    {
        public Class()
        {
            StudentClass = new HashSet<StudentClass>();
        }

        public override int Id { get; set; }
        public string Name { get; set; }

        public ICollection<StudentClass> StudentClass { get; set; }
    }
}
