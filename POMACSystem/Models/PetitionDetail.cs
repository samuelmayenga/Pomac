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

    public partial class PetitionDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PetitionDetail()
        {
            this.Appeals = new HashSet<Appeal>();
            this.Coaccuseds = new HashSet<Coaccused>();
            this.Counts = new HashSet<Count>();
            this.CurrentPetitionResons = new HashSet<CurrentPetitionReson>();
            this.DisciplinaryActions = new HashSet<DisciplinaryAction>();
            this.HearingSummaries = new HashSet<HearingSummary>();
            this.InterviewSummaries = new HashSet<InterviewSummary>();
            this.PreviousConvictions = new HashSet<PreviousConviction>();
            this.PrisonerHistoryInRehabs = new HashSet<PrisonerHistoryInRehab>();
            this.ProbatioAndAftercareServices = new HashSet<ProbatioAndAftercareService>();
            this.Victims = new HashSet<Victim>();
            this.Victims1 = new HashSet<Victim>();
            this.Appeals = new HashSet<Appeal>();
        }

        public int PetitionDetailsID { get; set; }
        public string UserId { get; set; }
        public int PetitionerDetailsID { get; set; }
        public string CourtCaseNumber { get; set; }
        public Nullable<System.DateTime> DateOfConviction { get; set; }
        public Nullable<System.DateTime> DateOfOffence { get; set; }
        public string PlaceOfOffence { get; set; }
        public Nullable<System.DateTime> DateOfArrest { get; set; }
        public Nullable<System.DateTime> DateOfRemand { get; set; }
        public Nullable<System.DateTime> EarliestPossibleDateOfDischarge { get; set; }
        public Nullable<System.DateTime> LatestPossibleDateOfDischarge { get; set; }
        public Nullable<int> TrialCourt { get; set; }
        public string CountsImplementation { get; set; }
        public Nullable<bool> Resentenced { get; set; }
        public string ResentencingOutcome { get; set; }
        public Nullable<bool> PendingCourtMatter { get; set; }
        public string PendingCourtMattersExplanation { get; set; }
        public Nullable<int> ReliefsID { get; set; }
        public string Skills { get; set; }
        public string NatureParticularsCircumstancesOfOffence { get; set; }
        public Nullable<int> PreviousPetitions { get; set; }
        public Nullable<bool> Trustee { get; set; }
        public Nullable<System.DateTime> DateOfTrusteePromotion { get; set; }
        public string Achievement { get; set; }
        public string Attributes { get; set; }
        public Nullable<bool> AreYouPrisoner { get; set; }
        public string NameOfRepresentativeOrAdvocate { get; set; }
        public string RelationshipWithConvict { get; set; }
        public string TelephoneNumber { get; set; }
        public string IDNumber { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appeal> Appeals { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Coaccused> Coaccuseds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Count> Counts { get; set; }
        public virtual Court Court { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CurrentPetitionReson> CurrentPetitionResons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DisciplinaryAction> DisciplinaryActions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HearingSummary> HearingSummaries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InterviewSummary> InterviewSummaries { get; set; }
        public virtual PetitionerDetail PetitionerDetail { get; set; }
        public virtual Relief Relief { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PreviousConviction> PreviousConvictions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrisonerHistoryInRehab> PrisonerHistoryInRehabs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProbatioAndAftercareService> ProbatioAndAftercareServices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Victim> Victims { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Victim> Victims1 { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Appeal> Appeals { get; set; }
    }

}
