using PCHP.Core;
using System;

namespace PCHP.ViewModel
{
    public class DropDownMangementVM
    {
        public string Value { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }
        public string Label { get; set; }
        public bool IsSubdrodown { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public DropDownMangementVM()
        {

        }
    }
    public class AddUpdateDropDownMangement
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public bool Active { get; set; }
        public string Label { get; set; }
        public bool IsSubdrodown { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

    }
    public class DropdownMangementGridResultVM
    {
        public int Id { get; set; }
        public string OptionNumber { get; set; }
        public string Type { get; set; }
        public string CreatedByFirstName { get; set; }
        public string CreatedByMiddleName { get; set; }
        public string CreatedByLastName { get; set; }
        public string LastEditedFirstName { get; set; }
        public string LastEditedMiddleName { get; set; }
        public string LastEditedLastName { get; set; }
        public int Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public string Label { get; set; }
        public bool IsSubdrodown { get; set; }

    }
    public class SubDropdownMangementGridResultVm
    {
        public int Id { get; set; }
        public string ParentOption { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string CreatedByFirstName { get; set; }
        public string CreatedByMiddleName { get; set; }
        public string CreatedByLastName { get; set; }

        public string LastEditedFirstName { get; set; }
        public string LastEditedMiddleName { get; set; }
        public string LastEditedLastName { get; set; }

        public int IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public string Label { get; set; }
        public bool IsSubdrodown { get; set; }

    }
    public class DropdownMangementListFilterVm : GridParameter
    {
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public int DropDownId { get; set; }
        public string Type { get; set; }

    }
    public class DropDownSearchRequest : GridParameter
    {
        public string Name { get; set; }
        public int? Status { get; set; }

    }
    public class AddUpdateSubDropDown
    {
        public int Id { get; set; }
        public int ParentOptionId { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public bool Active { get; set; }
        public string Label { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

    }
    public class SubDropDownVm
    {
        public int Id { get; set; }
        public int ParentOptionId { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public bool Active { get; set; }
        public string Label { get; set; }
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
        public string ParentOption { get; set; }

    }
}
