using PCHP.Core;
using PCHP.Core.Enums;
using System;

namespace PCHP.ViewModel
{
    public class PaperFormsAddUpdate
    {
        public int Id { get; set; }
        public int ProgramType { get; set; }
        public string FormName { get; set; }
        public string Version { get; set; }

        public string RandomFileName { get; set; }
        public string ActualFileName { get; set; }

        public string FileData { get; set; }
        public string FileExtension { get; set; }

        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class PaperFormsViewModel
    {
        public int Id { get; set; }
        public ProgramType ProgramType { get; set; }
        public string FormName { get; set; }
        public string Version { get; set; }
        public string RandomFileName { get; set; }
        public string ActualFileName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class PaperFormsGridResultVm : TGridResultViewModel
    {
        public int Id { get; set; }
        public ProgramType ProgramType { get; set; }
        public string FormName { get; set; }
        public string Version { get; set; }
        public string RandomFileName { get; set; }
        public string ActualFileName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

    }

    public class PaperFormsSearchRequest : GridParameter
    {
        public string FormName { get; set; }

        public int? Status { get; set; }

        public ProgramType? ProgramType { get; set; }
    }
}