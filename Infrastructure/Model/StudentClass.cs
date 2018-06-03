using System;
using System.Collections.Generic;

namespace Infrastructure.Model
{
    public partial class StudentClass
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }

        public Class Class { get; set; }
        public Student Student { get; set; }
    }
}
