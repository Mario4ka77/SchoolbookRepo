﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SchoolbookApp.Models;

namespace SchoolbookApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SchoolbookApp.Models.SchoolClass> SchoolClass { get; set; }
        public DbSet<SchoolbookApp.Models.Subject> Subject { get; set; }
        public DbSet<SchoolbookApp.Models.SubjectType> SubjectType { get; set; }
        public DbSet<SchoolbookApp.Models.Absence> Absence { get; set; }
        public DbSet<SchoolbookApp.Models.Note> Note { get; set; }
        public DbSet<SchoolbookApp.Models.Grade> Grade { get; set; }
        public DbSet<SchoolbookApp.Models.UserUser> UserUser { get; set; }
        public DbSet<SchoolbookApp.Models.UserSchoolClass> UserSchoolClass { get; set; }
    }
}
