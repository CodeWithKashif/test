using PCHP.Core.Enums;
using System;

namespace PCHP.ViewModel
{
    public class ChildReferralStatusLogViewModel
    {
        public int Id { get; set; }
        public int ChildReferralId { get; set; }
        public int Status { get; set; }
        public DateTime StatusDate { get; set; }
      
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
      
        public string CreatedByFirstName { get; set; }
        public string CreatedByMiddleName { get; set; }
        public string CreatedByLastName { get; set; }

    }
}