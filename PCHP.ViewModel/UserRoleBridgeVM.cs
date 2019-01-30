using System;
using System.Collections.Generic;

namespace PCHP.ViewModel
{
   public class UserRoleBridgeVM
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleLevelId { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public int? SiteId { get; set; }
        public string SiteName { get; set; }

        public int? RegionId { get; set; }
        public string RegionName { get; set; }

        public DateTime RoleStartDate { get; set; }
        public DateTime? RoleEndDate { get; set; }

        private bool _isActive;
        public bool IsActive
        {
            get
            {
                if (_isActive)
                {
                    //TODO:Move this logic to single place
                    if (RoleStartDate.Date <= DateTime.Today.Date && RoleEndDate == null)
                        return true;

                    if (RoleStartDate > DateTime.Today || RoleEndDate < DateTime.Today)
                        return false;
                }
                return _isActive;
            }
            set { _isActive = value; }
        }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public List<int> SiteIds { get; set; }
        public List<UserSiteRoles> SiteRoles { get; set; }

    }

    public class UserRoleBaseAccess
    {
       public int SiteChildren { get; set; }
    }

    public class UserSiteRoles
    {
        public int SiteId { get; set; }
        public string SiteName { get; set; }

    }
}
