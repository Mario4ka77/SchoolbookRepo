﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolbookApp.Models
{
    public class SubjectType
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public ICollection<Subject> Subjects { get; set; }

        public SubjectType()
        {

        }

    }
}
