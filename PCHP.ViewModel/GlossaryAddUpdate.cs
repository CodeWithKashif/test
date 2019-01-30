using PCHP.Core;
using System;

namespace PCHP.ViewModel
{
    public class GlossaryAddUpdate
    {
        public int Id { get; set; }
        public string GlossaryName { get; set; }
        public string EnglishDescription { get; set; }
        public string GlossaryNameFirstLatter { get; set; }
        public string AdditionalLanguages { get; set; }
        public string AdditionalLanguagesName { get; set; }
        public string SpanishDescription { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class GlossaryViewModel
    {
        public int Id { get; set; }
        public string GlossaryName { get; set; }
        public string GlossaryNameFirstLatter { get; set; }
        public string EnglishDescription { get; set; }
        public string AdditionalLanguages { get; set; }
        public string AdditionalLanguagesName { get; set; }
        public string SpanishDescription { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class GlossaryGridResultVm : TGridResultViewModel
    {
        public int Id { get; set; }
        public string GlossaryName { get; set; }
        public string GlossaryNameFirstLatter { get; set; }
        public string EnglishDescription { get; set; }
        public string AdditionalLanguages { get; set; }
        public string AdditionalLanguagesName { get; set; }
        public string SpanishDescription { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

        public string CreatedByFirstName { get; set; }
        public string CreatedByMiddleName { get; set; }
        public string CreatedByLastName { get; set; }

        public string LastEditedFirstName { get; set; }
        public string LastEditedMiddleName { get; set; }
        public string LastEditedLastName { get; set; }
    }

    public class GlossarySearchRequest : GridParameter
    {
        public string GlossaryName { get; set; }
        public string GlossaryNameFirstLatter { get; set; }
        public bool? Status { get; set; }

    }
}