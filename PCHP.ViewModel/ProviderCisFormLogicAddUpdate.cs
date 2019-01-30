using System;
using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class ProviderCisFormLogicAddUpdate
    {

        public List<ProviderCisFormLogicVm> ProviderCisFormLogic { get; set; }

        public ProviderCisFormLogicAddUpdate()
        {
            ProviderCisFormLogic = new List<ProviderCisFormLogicVm>();
        }
    }

    public class ProviderCisFormLogicVm
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public int OptionDisplayI { get; set; }
        public int OptionValueI { get; set; }
        public int OptionDisplayII { get; set; }
        public int OptionValueII { get; set; }
        public int OptionDisplayIII { get; set; }
        public int OptionValueIII { get; set; }
        public int OptionDisplayIV { get; set; }
        public int OptionValueIV { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class ProviderCisFormLogicViewModel
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public int OptionDisplayI { get; set; }
        public int OptionValueI { get; set; }
        public int OptionDisplayII { get; set; }
        public int OptionValueII { get; set; }
        public int OptionDisplayIII { get; set; }
        public int OptionValueIII { get; set; }
        public int OptionDisplayIV { get; set; }
        public int OptionValueIV { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

}