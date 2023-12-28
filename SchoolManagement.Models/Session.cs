﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class Session
    {

        public int Id { get; set; }

        public string Start { get; set; }

        public string End { get; set; }

        public ICollection<Enroll> enrolls { get; set; } = new HashSet<Enroll>();

        public ICollection<TeacherSession> TeacherSessions { get; set; } = new HashSet<TeacherSession>();
    }
}
