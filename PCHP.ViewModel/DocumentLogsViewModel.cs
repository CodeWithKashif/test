using System;
namespace PCHP.ViewModel
{
    public class DocumentLogsViewModel
    {
        public int Id { get; set; }
        public int? SiteId { get; set; }
        public DateTime LogDate { get; set; }
        public string LogFile { get; set; }
        public string OriginalDocument { get; set; }
        public string LogFileExtension { get; set; }
        public string Comments { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class DocumentLogsGridResultVm
    {
        public int Id { get; set; }
        public DateTime LogDate { get; set; }
        public string LogFile { get; set; }
        public string OriginalDocument { get; set; }
        public string Comments { get; set; }

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
}