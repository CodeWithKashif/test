using System;

namespace PCHP.ViewModel
{
    public class SiteStaffGridResultVm
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string RoleName { get; set; }
        public DateTime RoleStartDate { get; set; }
        public DateTime? RoleEndDate { get; set; }
        public bool IsFromSite { get; set; }

        private bool _isActive;
        public bool IsActive
        {
            get
            {
                if (!IsFromSite)
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
                return _isActive;
            }
            set { _isActive = value; }
        }

        public int RoleId { get; set; }

    }
}