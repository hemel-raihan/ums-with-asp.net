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
    
    public partial class skill
    {
        public skill()
        {
            this.photoorders = new HashSet<photoorder>();
        }
    
        public int photoid { get; set; }
        public string title { get; set; }
        public string photo { get; set; }
        public string description { get; set; }
        public int uid { get; set; }
    
        public virtual ICollection<photoorder> photoorders { get; set; }
        public virtual skill skills1 { get; set; }
        public virtual skill skill1 { get; set; }
        public virtual skill skills11 { get; set; }
        public virtual skill skill2 { get; set; }
    }
}