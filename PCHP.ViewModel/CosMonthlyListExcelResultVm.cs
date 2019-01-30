using System;
using System.Runtime.CompilerServices;

namespace PCHP.ViewModel
{
    public class CosMonthlyListExcelResultVm
    {
        public string ChildName { get; set; }
        public int ChildId { get; set; }
        public string PrimaryLanguageSpokenAtHomeValue { get; set; }
        public string EthinicityName { get; set; }
        public string GenderValue { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool PchpYesNo { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public int SiteId { get; set; }
        public string ProgramYearName { get; set; }
        public string ProgramCycle { get; set; }

        public int NumberHomeVisits { get; set; }
        //public int TotalHomeVisitsToDate { get; set; }//not added yet in query
        
        public int? CbtPreIndependence { get; set; }
        public int? CbtPreSocialCooperation { get; set; }
        public int? CbtPreTaskOrientation { get; set; }
        public int? CbtPreCognitiveAbility { get; set; }
        public int? CbtPreEmotionalStability { get; set; }

        public int? CbtPostIndependence { get; set; }
        public int? CbtPostSocialCooperation { get; set; }
        public int? CbtPostTaskOrientation { get; set; }
        public int? CbtPostCognitiveAbility { get; set; }
        public int? CbtPostEmotionalStability { get; set; }

        public int? PactPreCommunicationWithChild { get; set; }
        public int? PactPreConsistentlyWithTheChild { get; set; }
        public int? PactPreAffectionTowardTheChild { get; set; }
        public int? PactPreParentsResponsivenessToChild { get; set; }

        public int? PactPostCommunicationWithChild { get; set; }
        public int? PactPostConsistentlyWithTheChild { get; set; }
        public int? PactPostAffectionTowardTheChild { get; set; }
        public int? PactPostParentsResponsivenessToChild { get; set; }
    }
    public class CosMonthlyTotalTabListExcelResultVm
    {
        public string ChildName { get; set; }
        public int ChildId { get; set; }
        public string PrimaryLanguageSpokenAtHomeValue { get; set; }
        public string EthinicityName { get; set; }
        public string GenderValue { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool PchpYesNo { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public int SiteId { get; set; }
        public string ProgramYearName { get; set; }
        public string ProgramCycle { get; set; }

        public int NumberHomeVisits { get; set; }
        //public int TotalHomeVisitsToDate { get; set; }//not added yet in query

        public double? CbtPreIndependence { get; set; }
        public double? CbtPreSocialCooperation { get; set; }
        public double? CbtPreTaskOrientation { get; set; }
        public double? CbtPreCognitiveAbility { get; set; }
        public double? CbtPreEmotionalStability { get; set; }

        public double? CbtPostIndependence { get; set; }
        public double? CbtPostSocialCooperation { get; set; }
        public double? CbtPostTaskOrientation { get; set; }
        public double? CbtPostCognitiveAbility { get; set; }
        public double? CbtPostEmotionalStability { get; set; }

        public double? PactPreCommunicationWithChild { get; set; }
        public double? PactPreConsistentlyWithTheChild { get; set; }
        public double? PactPreAffectionTowardTheChild { get; set; }
        public double? PactPreParentsResponsivenessToChild { get; set; }

        public double? PactPostCommunicationWithChild { get; set; }
        public double? PactPostConsistentlyWithTheChild { get; set; }
        public double? PactPostAffectionTowardTheChild { get; set; }
        public double? PactPostParentsResponsivenessToChild { get; set; }
    }
}