﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School_DA
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SchoolEntities : DbContext
    {
        public SchoolEntities()
            : base("name=SchoolEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<City> City { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<University> University { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<SubjectFaculty> SubjectFaculty { get; set; }
    }
}
