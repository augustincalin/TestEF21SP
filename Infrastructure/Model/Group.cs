﻿using System;
using System.Collections.Generic;

namespace Infrastructure.Model
{
    public partial class Group
    {
        public Group()
        {
            Student = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Student> Student { get; set; }
    }
}
