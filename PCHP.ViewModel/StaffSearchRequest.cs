using System;
using PCHP.Core;

namespace PCHP.ViewModel
{
    public class StaffSearchRequest : GridParameter
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int RoleId { get; set; }
        public int RoleLevel { get; set; }
        public int SiteId { get; set; }
        public DateTime? FromRoleStartDate { get; set; }
        public DateTime? ToRoleStartDate { get; set; }
        public DateTime? FromRoleEndDate { get; set; }
        public DateTime? ToRoleEndDate { get; set; }
        public bool? IsActive { get; set; }
        public bool IsFromSite { get; set; }
        public string Region { get; set; }
    }
}
