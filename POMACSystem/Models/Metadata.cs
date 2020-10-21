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
}