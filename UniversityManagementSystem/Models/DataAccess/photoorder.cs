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
    
    public partial class photoorder
    {
        public int id { get; set; }
        public int photoid { get; set; }
        public string title { get; set; }
        public int ownerid { get; set; }
        public string email { get; set; }
    
        public virtual skill skill { get; set; }
    }
}