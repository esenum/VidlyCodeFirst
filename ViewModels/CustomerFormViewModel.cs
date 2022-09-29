using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyCF.Models;

namespace VidlyCF.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; } //used IEnumerable instead of List
        public Customer Customer { get; set; }
    }
}