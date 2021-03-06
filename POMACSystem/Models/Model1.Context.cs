﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PomacDBEntities1 : DbContext
    {
        public PomacDBEntities1()
            : base("name=PomacDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Achievement> Achievements { get; set; }
        public virtual DbSet<Appeal> Appeals { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Attribute> Attributes { get; set; }
        public virtual DbSet<Coaccused> Coaccuseds { get; set; }
        public virtual DbSet<Counselling> Counsellings { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<Count> Counts { get; set; }
        public virtual DbSet<Court> Courts { get; set; }
        public virtual DbSet<CurrentPetitionReson> CurrentPetitionResons { get; set; }
        public virtual DbSet<DateKnown> DateKnowns { get; set; }
        public virtual DbSet<Deployment> Deployments { get; set; }
        public virtual DbSet<DisciplinaryAction> DisciplinaryActions { get; set; }
        public virtual DbSet<EducationLevel> EducationLevels { get; set; }
        public virtual DbSet<FamilyDetail> FamilyDetails { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<HearingSummary> HearingSummaries { get; set; }
        public virtual DbSet<InterviewSummary> InterviewSummaries { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<MaritalStatu> MaritalStatus { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<NextOfKin> NextOfKins { get; set; }
        public virtual DbSet<PetitionDetail> PetitionDetails { get; set; }
        public virtual DbSet<PetitionerDetail> PetitionerDetails { get; set; }
        public virtual DbSet<PetitionReason> PetitionReasons { get; set; }
        public virtual DbSet<PreviousConviction> PreviousConvictions { get; set; }
        public virtual DbSet<PrisonComment> PrisonComments { get; set; }
        public virtual DbSet<PrisonerHistoryInRehab> PrisonerHistoryInRehabs { get; set; }
        public virtual DbSet<PrisonerMedicalHistory> PrisonerMedicalHistories { get; set; }
        public virtual DbSet<PrisonerTraining> PrisonerTrainings { get; set; }
        public virtual DbSet<Prison> Prisons { get; set; }
        public virtual DbSet<ProbatioAndAftercareService> ProbatioAndAftercareServices { get; set; }
        public virtual DbSet<ProgressiveStage> ProgressiveStages { get; set; }
        public virtual DbSet<Relief> Reliefs { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<SubCounty> SubCounties { get; set; }
        public virtual DbSet<Sublocation> Sublocations { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }
        public virtual DbSet<Tribe> Tribes { get; set; }
        public virtual DbSet<Victim> Victims { get; set; }
        public virtual DbSet<VitalStatu> VitalStatus { get; set; }
        public virtual DbSet<Recommendation> Recommendations { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        //public virtual DbSet<Appeal> Appeals { get; set; }
    }
}
