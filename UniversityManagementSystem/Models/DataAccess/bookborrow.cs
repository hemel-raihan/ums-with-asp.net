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
    
    public partial class bookborrow
    {
        public int borrowid { get; set; }
        public int libraryid { get; set; }
        public string bookname { get; set; }
        public System.DateTime bdate { get; set; }
        public System.DateTime rdate { get; set; }
        public string semail { get; set; }
    
        public virtual library library { get; set; }
    }
}