//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniversityManagementSystem.Models.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class enroll
    {
        public int enrollid { get; set; }
        public int courseid { get; set; }
        public string coursename { get; set; }
        public int teacherid { get; set; }
        public int sid { get; set; }
        public string session { get; set; }
    
        public virtual cours cours { get; set; }
    }
}