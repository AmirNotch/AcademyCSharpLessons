﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCSharpLesson21._10._2021
{
    public class Client
    {
        //[Table("Clients")]
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime? Updated_At { get; set; }
    }
}
