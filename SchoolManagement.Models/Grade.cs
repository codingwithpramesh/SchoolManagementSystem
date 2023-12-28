using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class Grade
    {

        public int Id { get; set; }

        public string Name { get; set; }

        [NotMapped]
        public ICollection<AssignGrade> AssignGrade { get; set; }

        [NotMapped]
        public ICollection<Enroll> Enroll { get; set; }

        public ICollection<GradeSubject> GradeSubjects { get; set; }
    }
}
