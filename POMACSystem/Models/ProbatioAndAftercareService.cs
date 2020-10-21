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
    
    public partial class ProbatioAndAftercareService
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProbatioAndAftercareService()
        {
            this.FamilyDetails = new HashSet<FamilyDetail>();
        }
    
        public int ProbationAftercareID { get; set; }
        public int PetitionDetailsID { get; set; }
        public string UserId { get; set; }
        public string SourceOfInformation { get; set; }
        public string ReportSummary { get; set; }
        public string ReferenceToPreviousPrereleaseReports { get; set; }
        public string PersonalHistory { get; set; }
        public string PreviousConvictions { get; set; }
        public string PreviousEducation { get; set; }
        public string PreviousOccupation { get; set; }
        public string PreviousEngagementWithAlcoholDrugs { get; set; }
        public string PersonalUnderstandingOfCrimeAndEffects { get; set; }
        public string InterpersonalRelationshipsWithFamily { get; set; }
        public string LifeDevelopmentalChallenges { get; set; }
        public string CurrentChangeOfAttitudeBehaviour { get; set; }
        public string AnyOtherObservables { get; set; }
        public string FamilyTiesAndSupportSystem { get; set; }
        public string IncarcerationEffect { get; set; }
        public string CriminalityHistoryInFamily { get; set; }
        public string FrequencyOfFamilyContact { get; set; }
        public string OutstandingSuccessionInheritanceDisputes { get; set; }
        public string CircumstancesOfOffence { get; set; }
        public string RelationOfVictimToPetitionerAndRelations { get; set; }
        public string VictimFears { get; set; }
        public string CompensationResponsibility { get; set; }
        public string VictimProtectionMeasures { get; set; }
        public string CommunityAcceptanceConcerns { get; set; }
        public string InformationFromCorrectionalFacilities { get; set; }
        public string SecurityOrgansComments { get; set; }
        public string LegalRequirementsForSupervision { get; set; }
        public string AssessmentOfCorrectionalInterventions { get; set; }
        public string LevelOfReductionOfRecidivism { get; set; }
        public string AcceptanceByFamilyAndCommunity { get; set; }
        public string AccomodationAndHousing { get; set; }
        public string SubstanceAndAlcoholMisuse { get; set; }
        public string HealthcareIncludingMentalHealth { get; set; }
        public string PurposefulEmployment { get; set; }
        public string PresenceOfAlluringNegativePeers { get; set; }
        public string PostReleasePlan { get; set; }
        public string EmpowermentAndSupportRequired { get; set; }
        public string RiskFactorsAndMitigation { get; set; }
        public string ProtectiveFactors { get; set; }
        public string ReintegrationPlan { get; set; }
        public string Supervision { get; set; }
        public Nullable<bool> Recommendation { get; set; }
        public string RecommendationRemarks { get; set; }
        public string ProbationOfficerName { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> Datemodified { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FamilyDetail> FamilyDetails { get; set; }
        public virtual PetitionDetail PetitionDetail { get; set; }
    }
}