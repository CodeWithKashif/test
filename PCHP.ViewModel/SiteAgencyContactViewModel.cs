using System;
using System.Collections.Generic;
using PCHP.Core.Enums;

namespace PCHP.ViewModel
{
    public class SiteAgencyContactViewModel
    {
        public int Id { get; set; }
        public int SiteAgencyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ContactType { get; set; }
        public string Comments { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public List<PhoneVm> Phones { get; set; }

        public SiteAgencyContactViewModel()
        {
            Phones = new List<PhoneVm>();
        }
    }

    public class SiteAgencyContactAddUpdate
    {
        public int Id { get; set; }
        public int SiteAgencyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ContactType { get; set; }
        public bool IsActive { get; set; }
        public string Comments { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public List<PhoneVm> Phones { get; set; }
    }


    public class SiteAgencyContactViewModelGridResultVm
    {
        public int Id { get; set; }
        public int SiteAgencyId { get; set; }
        public string SiteAgencyName { get; set; }
        public DateTime SiteAgencyStartDate { get; set; }
        public DateTime? SiteAgencyEndDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ContactType { get; set; }
        
        //public bool IsActive { get; set; }   //Displayed as ContactStatus
        private bool _isActive;
        public bool IsActive
        {
            get
            {
                if (_isActive)
                {
                    //TODO:Move this logic to single place
                    if (SiteAgencyStartDate <= DateTime.Today && SiteAgencyEndDate == null)
                        return true;

                    if (SiteAgencyStartDate > DateTime.Today || SiteAgencyEndDate < DateTime.Today)
                        return false;
                }
                return _isActive;
            }
            set { _isActive = value; }
        }
        public PhoneType PhoneType { get; set; }
        public string PhoneNumber { get; set; }
        public string Comments { get; set; }
    }
}