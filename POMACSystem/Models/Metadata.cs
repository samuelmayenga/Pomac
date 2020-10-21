using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace POMACSystem.Models
{
    public class Metadata
    {
    }

    [MetadataType(typeof(PetitionerDetailMetadata))]
    public partial class PetitionerDetail
    {
    }

    [MetadataType(typeof(PetitionDetailMetadata))]
    public partial class PetitionDetail
    {
    }

    public class PetitionerDetailMetadata
    {

        [StringLength(50)]
        [Display(Name = "Petition Number")]
        public string PetitionNumber { get; set; }

        [StringLength(50)]
        [Display(Name = "Petitioner First Name")]
        public string PetitionerFirstName { get; set; }

        [StringLength(50)]
        [Display(Name = "Petitioner Middle Name")]
        public string PetionerMidName { get; set; }

        [StringLength(50)]
        [Display(Name = "Petitioner Last Name")]
        public string PetitionerLastName { get; set; }

        [StringLength(50)]
        [Display(Name = "Petitioner Alias Name")]
        public string PetitionerAliasName { get; set; }

        public Nullable<int> Gender { get; set; }

        [Display(Name = "Marital Status")]
        public Nullable<int> MaritalStatus { get; set; }

        
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DateOfBirth { get; set; }

        [Display(Name = "Date of Birth Known ")]
        public Nullable<bool> DateOfBirthKnown { get; set; }
        public Nullable<int> Nationality { get; set; }

        [StringLength(50)]
        [Display(Name = "Id Number/Passport No")]
        public string IdNumber { get; set; }
        public Nullable<int> County { get; set; }

      
        [Display(Name = "Sub County")]
        public Nullable<int> SubCounty { get; set; }
        public Nullable<int> Location { get; set; }

     
        [Display(Name = "Sub Location")]
        public Nullable<int> SubLocation { get; set; }
        public string Village { get; set; }

        [Display(Name = "Ethnicity")]
        public Nullable<int> EthnicityId { get; set; }
        public string Ocupation { get; set; }

        [Display(Name = "Level Of Education")]
        public Nullable<int> LevelOfEducation { get; set; }

        [Display(Name = "Nearest Church")]
        public string NearestChurch { get; set; }

        [Display(Name = "Nearest School")]
        public string NearestSchool { get; set; }
        [Display(Name = "Nearest Market")]
        public string NearestMarket { get; set; }
        [Display(Name = "Home Chief")]
        public string HomeCheif { get; set; }

        [Display(Name = "Next Of Kin")]
        public Nullable<int> NextOfKin { get; set; }
        [Display(Name = "Next of Kin Contact")]
        public string NextOfKinContact { get; set; }
        [Display(Name = "Next of Relation")]
        public Nullable<int> NextOfKinRelation { get; set; }
        [Display(Name = "Contact Person")]
        public string ContactPersonName { get; set; }
        [Display(Name = "Contact Person Phone")]
        public string ContactPersonPhone { get; set; }

    }

    public class PetitionDetailMetadata
    {
        public int PetitionDetailsID { get; set; }
        public string UserId { get; set; }
        public int PetitionerDetailsID { get; set; }

        [StringLength(50)]
        [Display(Name = "Court Case Number")]
        public string CourtCaseNumber { get; set; }

        [Display(Name = "Date of Conviction")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DateOfConviction { get; set; }

        [Display(Name = "Date of Offence")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DateOfOffence { get; set; }


        [StringLength(100)]
        [Display(Name = "Place of Offence")]
        public string PlaceOfOffence { get; set; }

        [Display(Name = "Date of Arrest")]
        [DataType(DataType.Date)]

        public Nullable<System.DateTime> DateOfArrest { get; set; }

        [Display(Name = "Date of Remand")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DateOfRemand { get; set; }
        [Display(Name = "Earliest Possible Date of Discharge")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> EarliestPossibleDateOfDischarge { get; set; }

        [Display(Name = "Latest Possible Date of Discharge")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> LatestPossibleDateOfDischarge { get; set; }

       
        [Display(Name = "Trial Court")]
        public Nullable<int> TrialCourt { get; set; }

        [StringLength(100)]
        [Display(Name = "Counts Implementation")]
        public string CountsImplementation { get; set; }
        public Nullable<bool> Resentenced { get; set; }

       
        [Display(Name = "Resentencing Outcome")]
        public string ResentencingOutcome { get; set; }

      
        [Display(Name = "Pending Court Matter")]
        public Nullable<bool> PendingCourtMatter { get; set; }

       
        [Display(Name = "Pending Court Matters Explanation")]
        public string PendingCourtMattersExplanation { get; set; }

        
        [Display(Name = "Reliefs")]
        public Nullable<int> ReliefsID { get; set; }
        public string Skills { get; set; }

        
        [Display(Name = "Nature,Particulars and Circumstances Of Offence")]
        public string NatureParticularsCircumstancesOfOffence { get; set; }

        [Display(Name = "Previous Petitions")]
        public Nullable<int> PreviousPetitions { get; set; }
        public Nullable<bool> Trustee { get; set; }
        [Display(Name = "Date Of Trustee Promotion")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DateOfTrusteePromotion { get; set; }
        public string Achievement { get; set; }
        public string Attributes { get; set; }
        [Display(Name = "Are you a Prisoner?")]
        public Nullable<bool> AreYouPrisoner { get; set; }

        [Display(Name = "Name Of Representative Or Advocate")]
        public string NameOfRepresentativeOrAdvocate { get; set; }

        [Display(Name = "Relationship With Convict")]
        public string RelationshipWithConvict { get; set; }

        
        [Display(Name = "Phone Number")]
        public string TelephoneNumber { get; set; }
        [Display(Name = "ID Number/Passport No")]
        public string IDNumber { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }

    }
}