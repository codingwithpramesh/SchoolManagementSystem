using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class Enroll
    {

        public int Id { get; set; }
        public int? StudentId { get; set; }

        public Student? Student { get; set; }

        public int? SessionId { get; set; }

        public Session? session { get; set; }

        public int? GradeId { get; set; }

        public Grade? Grade { get; set; }
    }
}
