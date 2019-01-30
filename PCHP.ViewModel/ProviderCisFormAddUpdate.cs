using System;
using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class ProviderCisFormAddUpdate
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public int ProgramYearId { get; set; }
        public int ProviderFormTypeId { get; set; }
        public float? CisAverage { get; set; }

        public List<CisFormVm> CisForm { get; set; }

        public ProviderCisFormAddUpdate()
        {
            CisForm = new List<CisFormVm>();
        }

        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class CisFormVm
    {         
        public int ProviderFormsId { get; set; }
        public int QuestionId { get; set; }
        public int DisplayValue { get; set; }
        public int CalculatedValue { get; set; }
      
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class ProviderCisFormVm
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public int ProgramYearId { get; set; }

        public string ProviderFirstName { get; set; }
        public string ProviderMiddleName { get; set; }
        public string ProviderLastName { get; set; }
        public string ProgramYearName { get; set; }

        public int ProviderFormTypeId { get; set; }
        public float? CisAverage { get; set; }

        public List<CisFormVm> CisForm { get; set; }

        public ProviderCisFormVm()
        {
            CisForm = new List<CisFormVm>();
        }

        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }


    public class ProviderFccersFormAddUpdate
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public int ProgramYearId { get; set; }
        public int ProviderFormTypeId { get; set; }
        public float? CisAverage { get; set; }
        public int? FormStatus { get; set; }
        public List<ProviderFccerSectionVm> FccerForm { get; set; }

        public ProviderFccersFormAddUpdate()
        {
            FccerForm = new List<ProviderFccerSectionVm>();
        }

        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }
    public class ProviderFccersFormVm
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public int ProgramYearId { get; set; }
        public int ProviderFormTypeId { get; set; }
        public float? CisAverage { get; set; }
        public int? FormStatus { get; set; }
        public string Status { get; set; }
        public string ProviderName { get; set; }
        public string ProgramYearName { get; set; }
        public List<ProviderFccerSectionVm> FccerForm { get; set; }
        public ProviderFccersFormVm()
        {
            FccerForm = new List<ProviderFccerSectionVm>();
        }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }



    public class ProviderFccersForm
    {
        public int ProviderId { get; set; }
        public int ProgramYearId { get; set; }
        public int QuestionId { get; set; }
        public int IndicatorId { get; set; }
        public string RatingValue { get; set; }
        public bool IsActive { get; set; }
        public string ProviderFirstName { get; set; }
        public string ProviderMiddleName { get; set; }
        public string ProviderLastName { get; set; }
        public string ProgramYearName { get; set; }
        public List<ProviderFccerSectionVm> Section { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

    }
    public class ProviderFccerSectionVm
    {
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public List<ProviderFccerQuestionsVm> Questions { get; set; }
        public double SectionScore { get; set; }
    }
    public class ProviderFccerQuestionsVm
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public string QuestionName { get; set; }
        public int Score { get; set; }
        public List<OptionBoxesVm> Boxes { get; set; }
       
    }
    public class OptionBoxesVm
    {
        public List<BoxesVm> OptionBoxes { get; set; }
    }
    public class BoxesVm
    {
        public int box_id { get; set; }
        public string Option_Name { get; set; }
        public bool Option_Value_YES { get; set; }
        public bool Option_Value_NO { get; set; }
        public bool Option_Value_NA { get; set; }
        public bool isOptionSelected { get; set; }
        public string selectedOption { get; set; }
        public int IndicatorId { get; set; }
        public int QuestionId { get; set; }
    }
}