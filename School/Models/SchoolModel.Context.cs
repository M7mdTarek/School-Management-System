﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
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
    
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<CourseLevel1> CourseLevel1 { get; set; }
    
        [DbFunction("SchoolEntities", "funcGetCourseByTitle")]
        public virtual IQueryable<funcGetCourseByTitle_Result> funcGetCourseByTitle(string title)
        {
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<funcGetCourseByTitle_Result>("[SchoolEntities].[funcGetCourseByTitle](@title)", titleParameter);
        }
    
        public virtual ObjectResult<Course> GetCourses()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Course>("GetCourses");
        }
    
        public virtual ObjectResult<Course> GetCourses(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Course>("GetCourses", mergeOption);
        }
    
        public virtual int InsertCourse(string title, Nullable<int> credits)
        {
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var creditsParameter = credits.HasValue ?
                new ObjectParameter("credits", credits) :
                new ObjectParameter("credits", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertCourse", titleParameter, creditsParameter);
        }
    }
}
