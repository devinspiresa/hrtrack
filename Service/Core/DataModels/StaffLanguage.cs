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
    
    public partial class StaffLanguage
    {
        public int StaffLanguageID { get; set; }
        public int StaffID { get; set; }
        public string LanguageISO { get; set; }
        public Nullable<bool> HomeLanguage { get; set; }
        public Nullable<int> ReadProficiency { get; set; }
        public Nullable<int> WriteProficiency { get; set; }
        public Nullable<int> SpeakProficiency { get; set; }
    
        public virtual Staff Staff { get; set; }
    }
}
