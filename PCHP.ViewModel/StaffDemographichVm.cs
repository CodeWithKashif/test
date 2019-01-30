using System;

namespace PCHP.ViewModel
{
    public class StaffDemographicVm
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public int EthinicityId { get; set; }
        public string EthinicityName { get; set; }
        public int SubEthinicityId { get; set; }
        public string SubEthinicityName { get; set; }
        public string Salary { get; set; }
        public string EducationHighSchool { get; set; }
        public string EducationCollege { get; set; }
        public string EducationOther { get; set; }
        public bool IsRaisedInServingCommunity { get; set; }
        public int PriorExperience { get; set; }
        public int EmploymentStatusId { get; set; }
        public string EmploymentStatusName { get; set; }
        public DateTime HireDate { get; set; }
        public string OtherConcurrentEmployment { get; set; }
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
        public bool FProgramParticipent { get; set; }
        public int EducationLevel { get; set; }
        public StaffDemographicVm()
        {
            
        }
    }
}