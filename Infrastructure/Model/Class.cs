using System;
using System.Collections.Generic;

namespace Infrastructure.Model
{
    public partial class Class
    {
        public Class()
        {
            StudentClass = new HashSet<StudentClass>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<StudentClass> StudentClass { get; set; }
    }
}
