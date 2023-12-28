using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class Teacher
    {

        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DOB { get; set; }

        public DateTime DateofJoin { get; set; }

        public bool Selected { get; set; }
        [Unique]
        public string KeyId { get; set; }

        public string Qualification { get; set; }

        public int YearofEx { get; set; }
    }
}
