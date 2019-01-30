using PCHP.Core;
using PCHP.Core.Enums;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class TrainingAddUpdate
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SiteId { get; set; }
        public bool IsSiteLevelVism { get; set; } //VISM List
        public string SiteName { get; set; }
        public int NcApprovalLevel { get; set; }
        public bool? IsActive { get; set; }
        public bool IsRequiredNC { get; set; }
        public bool IsSiteCordinator { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public List<string> Topics { get; set; }
        public List<int> Roles { get; set; }
    }
    public class TrainingListFilterRequest : GridParameter
    {
        public int Type { get; set; }
        public string Name { get; set; }
        public int SiteId { get; set; }
        public bool? IsSiteLevelTraining { get; set; }
        public int NcApprovalLevel { get; set; }
        public bool? IsActive { get; set; }
        public int TrainingList { get; set; }
        public int UserId { get; set;}
        public int ProviderId { get; set; }
        public string Region { get; set; }
        public string TraineeName { get; set;}
        public int RoleId { get; set; }

    }
    public class TrainingGridResult
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Status { get; set; }
        public string TrainingType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SiteId { get; set; }
        public string SiteName { get; set; }
        public int NcApprovalLevel { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsRequiredNC { get; set; }
        public bool IsSiteCordinator { get; set; }
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
       
    }

    public class TrainingViewModel
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Status { get; set; }
        public string TrainingType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SiteId { get; set; }
        public string SiteName { get; set; }
        public int NcApprovalLevel { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsRequiredNC { get; set; }
        public bool IsSiteCordinator { get; set; }
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
        public List<TrainingTopic> Topics { get; set; }
        public List<TrainingRole> Roles { get; set; }
    }

    public class TrainingTopic
    {
        public int Id { get; set; }
        public int TrainingId { get; set; }
        public string Topic { get; set; }
    }
    public class TrainingRole
    {
        public int Id { get; set; }
        public int TrainingId { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }

    public class UserTrainingViewModel
    {
        public int Id { get; set; }
        public int TrainingId { get; set; }
        public int Type { get; set; }
        public int TrainingStatus { get; set; }
        public string Status { get; set; }
        public string TrainingType { get; set; }
        public string TrainingName { get; set; }
        public string Comments { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
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
        public List<TrainingTopic> Topics { get; set; }
        public string Description { get; set; }
        public int IsRequiredNC { get; set; }
        public int IsSiteCordinator { get; set; }
    }
    public class UserTrainingGridResult
    {
        public int Id { get; set; }
        public int TrainingId { get; set; }
        public int Type { get; set; }
        public string TrainingType { get; set; }
        public string TrainingName { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public int TrainingStatus { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Comments { get; set; }
        public int UserId { get; set; }
        public int ProviderId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
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
        public string SiteName { get; set; }
        public bool ISiteLevelTraining { get; set; }
        public string TrainingUserId { get; set; }
        public int IsRequiredNC { get; set; }
        public int IsSiteCordinator { get; set; }
    }

    public class UserTrainingAddUpdate
    {
        public int Id { get; set; }
        public int TrainingId { get; set; }
        public int Type { get; set; }
        public int TrainingStatus { get; set; }
        public string Status { get; set; }
        public string TrainingType { get; set; }
        public string TrainingName { get; set; }
        public string Comments { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
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
        public int UserId { get; set; }
        public int ProviderId { get; set; }

        public bool IsRequiredNC { get; set; }

    }
    public class TrainingSiteUserGridResult
    {
        public int UserId { get; set; }
        public int Type { get; set; }
        public string Status { get; set; }
        public string TrainingType { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public bool UserActive { get; set; }
        public string RoleName { get; set; }
        public string StaffName { get; set; }

    }
    public class NCTrainingGridResult:GridResultVm
    {
        public string Region { get; set; }
        public string RoleName { get; set; }
        public string TraineeName { get; set; }
        public string TrainingName { get; set; }
        public string TrainingType { get; set; }
        public string SiteName { get; set; }
        public bool IsActive { get; set; }
        public int IsRequiredNC { get; set; }
        public string Program { get; set; }
        public string ProgramYear { get; set; }
        public int RoleId { get; set; }
        public int SiteId { get; set; }
        public int Type { get; set; }

    }

}