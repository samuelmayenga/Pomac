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
    
    public partial class NextOfKin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NextOfKin()
        {
            this.FamilyDetails = new HashSet<FamilyDetail>();
            this.PetitionerDetails = new HashSet<PetitionerDetail>();
        }
    
        public int NextOfKinID { get; set; }
        public string Relation { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FamilyDetail> FamilyDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PetitionerDetail> PetitionerDetails { get; set; }
    }
}
