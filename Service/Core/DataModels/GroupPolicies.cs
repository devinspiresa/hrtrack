//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class GroupPolicies
    {
        public int GroupPolicyID { get; set; }
        public int CompanyGroupID { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<int> PolicyLevel { get; set; }
        public int Rank { get; set; }
        public string Description { get; set; }
        public string Policy { get; set; }
        public string DocumentRef { get; set; }
        public Nullable<int> DocumentID { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public Nullable<int> LastUpdatedBy { get; set; }
        public Nullable<bool> Deleted { get; set; }
    
        public virtual CompanyGroup CompanyGroup { get; set; }
    }
}
