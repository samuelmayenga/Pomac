//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POMACSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InterviewSummary
    {
        public int InterviewSummaryID { get; set; }
        public Nullable<int> PetitionDetailsId { get; set; }
        public string UserId { get; set; }
        public string OwnAccountOfCircumstances { get; set; }
        public string ReconciliationEffortsWithVictims { get; set; }
        public string IndicationOfRemoursefullness { get; set; }
        public string AnyOtherComments { get; set; }
        public string RepresentationOfVictims { get; set; }
        public string ConcludingObservationsOfMember { get; set; }
        public Nullable<bool> Recommendation { get; set; }
        public string RemarksOnRecommendation { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual PetitionDetail PetitionDetail { get; set; }
    }
}
