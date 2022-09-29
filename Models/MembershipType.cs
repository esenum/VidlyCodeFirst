using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace VidlyCF.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }
        public short SignUpFee { get; set; }//no more than 32 thousand
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }


        // used magical numbers
        public static readonly byte Unknown = 0; 
        public static readonly byte PayAsYouGo = 1;

    }
}