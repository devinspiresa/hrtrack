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
    
    public partial class Visas
    {
        public int VisaID { get; set; }
        public Nullable<int> StaffID { get; set; }
        public string VisaType { get; set; }
        public string ValidCountryISOCodes { get; set; }
        public Nullable<System.DateTime> ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public Nullable<int> DocumentID { get; set; }
    
        public virtual Documents Documents { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
