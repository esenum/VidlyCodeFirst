using System;
using System.ComponentModel.DataAnnotations;

namespace VidlyCF.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; } //navigation property allows us to navigate from one type to another(in this case from customer to membership type)//

        [Display(Name="Membership Type")]
        public byte MembershipTypeId { get; set; } //EF recognizes this convention and treats this property as a foreign key.

        [Display(Name="Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}