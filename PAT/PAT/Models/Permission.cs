//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManageShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Permission
    {
        public long ID { get; set; }
        public long GroupID { get; set; }
        public long ModuleID { get; set; }
        public string DisplayName { get; set; }
        public string ModuleName { get; set; }
        public string URL { get; set; }
        public string Reftype { get; set; }
        public string Refcode { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public string LastUpdatedBy { get; set; }
        public System.DateTime LastUpdatedDateTime { get; set; }
    }
}
