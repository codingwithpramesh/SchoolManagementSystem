using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class Subject
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<GradeSubject> GradeSubject { get; set; }
    }
}
