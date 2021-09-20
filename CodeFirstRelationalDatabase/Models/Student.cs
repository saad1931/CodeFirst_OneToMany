using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstRelationalDatabase.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int CurrentGradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
