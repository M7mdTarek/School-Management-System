//------------------------------------------------------------------------------
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
    
    public partial class GetCourses_Result
    {
        public int courseID { get; set; }
        public string courseName { get; set; }
        public int credits { get; set; }
        public string courseDescribtion { get; set; }
        public Nullable<int> price { get; set; }
        public bool IsCourseActive { get; set; }
        public string level { get; set; }
    }
}