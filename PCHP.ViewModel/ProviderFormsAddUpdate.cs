using System;
using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class ProviderFormsAddUpdate
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public int? SiteId { get; set; }
        public int ProgramYearId { get; set; }
        public int? ElsId { get; set; }
        public int SurveyType { get; set; }
        public DateTime SurveyDate { get; set; }
        public int? FormStatus { get; set; }
        public string Comments { get; set; }
        public int ProviderFormTypeId { get; set; }

        public int? VisitComplteted { get; set; }
        public int? TotalVismOfProvider { get; set; }
        public int? NoOfBooksChildInCare { get; set; }
        public string ProfessionalDevelopmentHours { get; set; }
        public bool? QualityImprovementProgramEnrolment { get; set; }
        public string ProgramSpecifiaction { get; set; }
        public string ProviderSurveyQueI { get; set; }
        public string ProviderSurveyQueXV { get; set; }

        public List<ChildFormsQuestionnaireViewModel> ProviderFormsQuestionnaire { get; set; }

        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public bool IsPPF { get; set; }
        public ProviderFormsAddUpdate()
        {
            ProviderFormsQuestionnaire = new List<ChildFormsQuestionnaireViewModel>();
        }

        public int ProgrammeYearId { get; set; }
    }


    public class ProviderFormsViewModel
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public int SiteId { get; set; }

        public string ProviderFirstName { get; set; }
        public string ProviderMiddleName { get; set; }
        public string ProviderLastName { get; set; }
        public string SiteName { get; set; }

        public string ElsFirstName { get; set; }
        public string ElsMiddleName { get; set; }
        public string ElsLastName { get; set; }

        public string ProgramYearName { get; set; }

        public int? ElsId { get; set; }
        public int ProgramYearId { get; set; }
        public int SurveyType { get; set; }
        public DateTime? SurveyDate { get; set; }
        public int? FormStatus { get; set; }
        public string Comments { get; set; }

        public int ProviderFormTypeId { get; set; }

        public int? NoOfBooksChildInCare { get; set; }
        public string ProfessionalDevelopmentHours { get; set; }
        public bool? QualityImprovementProgramEnrolment { get; set; }
        public string ProgramSpecifiaction { get; set; }
        public string ProviderSurveyQueI { get; set; }
        public string ProviderSurveyQueXV { get; set; }

        public List<ChildFormsQuestionnaireViewModel> ProviderFormsQuestionnaire { get; set; }

        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

        public ProviderFormsViewModel()
        {
            ProviderFormsQuestionnaire = new List<ChildFormsQuestionnaireViewModel>();
        }
    }



}