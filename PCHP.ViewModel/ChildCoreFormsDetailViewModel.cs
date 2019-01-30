using PCHP.Core.Enums;
using System;
using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class ChildCoreFormsDetailViewModel
    {
        public int Id { get; set; }

        public int ChildCoreFormsId { get; set; }
        public int HomeVisitNo { get; set; }
        public string OptionId { get; set; }
        public DateTime TestAdministrationDate { get; set; }
        public string Comments { get; set; }

        public FormStatus FormStatus { get; set; }
        public FormType FormType { get; set; }
        public AssessmentFormType AssessmentFormType { get; set; }
        public int? MonthScale { get; set; }

        public int ProgramYearId { get; set; }
        public string ProgramYearName { get; set; }
        public ProgramCycle ProgramCycle { get; set; }

        public int ChildId { get; set; }
        public string ChildFirstName { get; set; }
        public string ChildMiddleName { get; set; }
        public string ChildLastName { get; set; }
        public string ChildPlaceOfBirth { get; set; }

        public int ElsId { get; set; }
        public string ElsName { get; set; }

        public string CareGiverFirstName { get; set; }
        public string CareGiverLastName { get; set; }
        public RelationshipToChild RelationshipToChild { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

        public List<ChildFormsQuestionnaireViewModel> ChildFormsQuestionnaires { get; set; }

    }

    public class ChildCoreFormsDetailAddUpdate
    {
        public int Id { get; set; }

        public int ChildCoreFormsId { get; set; }
        public int HomeVisitNo { get; set; }
        public string OptionId { get; set; }
        public DateTime TestAdministrationDate { get; set; }
        public string Comments { get; set; }

        public int ElsId { get; set; }
        public string ElsName { get; set; }

        public List<ChildFormsQuestionnaireViewModel> ChildFormsQuestionnaires { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

        public ChildCoreFormsDetailAddUpdate()
        {
            ChildFormsQuestionnaires= new List<ChildFormsQuestionnaireViewModel>();
        }

        public FormStatus FormStatus { get; set; }


    }
}