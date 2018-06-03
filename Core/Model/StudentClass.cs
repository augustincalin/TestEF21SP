using Core.Common;
using System;
using System.Collections.Generic;

namespace Core.Model
{
    public class StudentClass : Entity
    {
        public override int Id { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }

        public Class Class { get; set; }
        public Student Student { get; set; }
    }
}
