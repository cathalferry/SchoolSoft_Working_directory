﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School_Soft
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SchoolSoftEntities1 : DbContext
    {
        public SchoolSoftEntities1()
            : base("name=SchoolSoftEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Course_Table> Course_Table { get; set; }
        public virtual DbSet<Login_Table> Login_Table { get; set; }
        public virtual DbSet<Student_Table> Student_Table { get; set; }
    }
}