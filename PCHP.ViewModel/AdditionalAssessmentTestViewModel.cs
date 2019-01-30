using PCHP.Core.Enums;
using System;
using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class AdditionalAssessmentTestViewModel
    {
        public int Id { get; set; }
        public int AdditionalAssessmentTestId { get; set; }
        public int ProgramYearId { get; set; }
        public int ChildCoreFormsId { get; set; }
        public double? Score { get; set; }
        public string TestName { get; set; }
        public DateTime AdministeredDate { get; set; }
        public ProgramCycle ProgramCycle { get; set; }
        public string Comments { get; set; }

        public int ChildId { get; set; }
        public string ChildFirstName { get; set; }
        public string ChildMiddleName { get; set; }
        public string ChildLastName { get; set; }

        public int ElsId { get; set; }
        public string ElsName { get; set; }

        public FormStatus FormStatus { get; set; }
        public string ProgramYearName { get; set; }
        public FormType FormType { get; set; }

        public AssessmentFormType? AssessmentFormType { get; set; }
        public int? MonthScale { get; set; }

        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

        public List<AdditionalAssessmentScoreVm> AdditionalAssessmentScore { get; set; }
    }
    public class AdditionalAssessmentTestAddUpdate
    {
        public int Id { get; set; }
        public int ChildCoreFormsId { get; set; }
        public int ChildId { get; set; }
        public int ProgramYearId { get; set; }
        public double? Score { get; set; }
        public string TestName { get; set; }
        public FormType FormType { get; set; }
        public AssessmentFormType? AssessmentFormType { get; set; }
        public int? MonthScale { get; set; }
        public DateTime AdministeredDate { get; set; }
        public ProgramCycle ProgramCycle { get; set; }
        public string Comments { get; set; }

        public List<AdditionalAssessmentScoreVm> AdditionalAssessmentScore { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

        public AdditionalAssessmentTestAddUpdate()
        {
            AdditionalAssessmentScore = new List<AdditionalAssessmentScoreVm>();
        }

        public FormStatus FormStatus { get; set; }

    }
}