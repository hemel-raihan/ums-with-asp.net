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
    
    public partial class employee
    {
        public int emp_id { get; set; }
        public int uid { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public System.DateTime joindate { get; set; }
        public int salary { get; set; }
        public int phone { get; set; }
    
        public virtual user user { get; set; }
    }
}