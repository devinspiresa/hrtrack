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
    
    public partial class KPIQuestionnaire
    {
        public int KPIQuestionnaireID { get; set; }
        public Nullable<int> KPIInstanceID { get; set; }
        public Nullable<int> KPIQuestionGroupID { get; set; }
        public Nullable<int> Sequence { get; set; }
        public Nullable<int> WeightPerc { get; set; }
    
        public virtual KPIInstance KPIInstance { get; set; }
        public virtual KPIQuestionGroup KPIQuestionGroup { get; set; }
    }
}
