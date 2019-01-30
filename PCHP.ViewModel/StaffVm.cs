using System;
using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class StaffVm
    {
        public List<AddressVm> Addresses { get; set; }
        public List<PhoneVm> Phones { get; set; }
        public List<EmailVm> Emails { get; set; }
        public List<UserRoleBridgeVM> Roles { get; set; }

        public int Id { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public bool IsActive { get; set; }          //Status
        public int MisLanguagePrefrence { get; set; }
        public string UserImage { get; set; }
        public string UserImageExtension { get; set; }
        public string ActualFileName { get; set; }
        public bool IsSuperAdmin { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

        public string CreatedByFirstName { get; set; }
        public string CreatedByMiddleName { get; set; }
        public string CreatedByLastName { get; set; }
        public string LastEditedByFirstName { get; set; }
        public string LastEditedByMiddleName { get; set; }
        public string LastEditedByLastName { get; set; }
        public string Email { get; set; }
        
        public StaffVm()
        {
            Addresses = new List<AddressVm>();
            Phones = new List<PhoneVm>();
            Emails = new List<EmailVm>();
            Roles = new List<UserRoleBridgeVM>();
        }
    }
}