using System;

namespace PCHP.ViewModel
{
    public class ProviderDemographicAddUpdate
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public int EthinicityId { get; set; }
        public int subEthinicityId { get; set; }
        public bool IsBirthInUS { get; set; }
        public string LanguageSpokenAtHome { get; set; }
        public string LanguageSpokenInChildCareSetting { get; set; }
        public string EducationCompleted { get; set; }
        public string AnnualIncomeRange { get; set; }
        public bool IsEnrolledInEducation { get; set; }
        public string IfYesEnrolledInEducation { get; set; }
        public bool IsEnrolledInQualityImprovement { get; set; }
        public string IfYesEnrolledInQualityImprovement { get; set; }
        public string ProfessionalDevelopmentHours { get; set; }
        public string IfZeroProfessionalDevelopmentHours { get; set; }
        public bool IsProviderAcceptGovernmentAid { get; set; }
        public bool IsEnrolledInOtherGovernmentAid { get; set; }
        public string IfYesEnrolledInOtherGovernmentAid { get; set; }
        public string SourceOfPchpFCC { get; set; }

        public int YearsInUSA { get; set; }
        public string CountryOrigin { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime LastEditedOn { get; set; }
    }

    public class ProviderDemographicViewModel
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public int EthinicityId { get; set; }
        public int SubEthinicityId { get; set; }
        public bool IsBirthInUS { get; set; }
        public string LanguageSpokenAtHome { get; set; }
        public string LanguageSpokenInChildCareSetting { get; set; }
        public string EducationCompleted { get; set; }
        public string AnnualIncomeRange { get; set; }
        public bool IsEnrolledInEducation { get; set; }
        public string IfYesEnrolledInEducation { get; set; }
        public bool IsEnrolledInQualityImprovement { get; set; }
        public string IfYesEnrolledInQualityImprovement { get; set; }
        public string ProfessionalDevelopmentHours { get; set; }
        public string IfZeroProfessionalDevelopmentHours { get; set; }
        public bool IsProviderAcceptGovernmentAid { get; set; }
        public bool IsEnrolledInOtherGovernmentAid { get; set; }
        public string IfYesEnrolledInOtherGovernmentAid { get; set; }
        public string SourceOfPchpFCC { get; set; }
        public int YearsInUSA { get; set; }
        public string CountryOrigin { get; set; }

        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime LastEditedOn { get; set; }
    }
}