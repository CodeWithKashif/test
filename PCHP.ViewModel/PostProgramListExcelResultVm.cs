namespace PCHP.ViewModel
{
    public class PostProgramListExcelResultVm
    {
        public int SiteId { get; set; }
        public int ChildId { get; set; }
        public bool? PostP1RecommendEIServices { get; set; }
        public bool? PostP1EvalEIServices { get; set; }
        public int? PostP1OfferedEIServices { get; set; }
        public int? PostP1PrimaryCaregiver1 { get; set; }
        public string PrimaryCaregiver1EmploymentStatus { get; set; }
        public bool? PrimaryCaregiver1CurrentlyInSchoolOrOtherEducationalProgram { get; set; }
        public int? PostP1PrimaryCaregiver2 { get; set; }
        public int? PrimaryCaregiver2EmploymentStatusId { get; set; }
        public string PrimaryCaregiver2EmploymentStatus { get; set; }
        public bool? PrimaryCaregiver2CurrentlyInSchoolOrOtherEducationalProgram { get; set; }
        public bool? PostP1HomelessFamily { get; set; }
        public bool? PostP1AccessingCommunityServices { get; set; }
        public int? PostP1HomeVisitsCompleted { get; set; }
        public int? PostP1BooksReceived { get; set; }
        public int? PostP1ToysReceived { get; set; }
        public bool? P1Completed { get; set; }
        public string WhyP1NotCompleted { get; set; }
        public bool? ReturningforP2 { get; set; }
        public string WhyNotReturningForP2 { get; set; }

        public bool? PostP2RecommendEIServices { get; set; }
        public bool? PostP2EvalEIServices { get; set; }
        public int? PostP2OfferedEIServices { get; set; }
        public int? PostP2PrimaryCaregiver1 { get; set; }
        public string PrimaryCaregiver1EmploymentStatus1 { get; set; }
        public bool? PrimaryCaregiver1CurrentlyInSchoolOrOtherEducationalProgram1 { get; set; }
        public int? PostP2PrimaryCaregiver2 { get; set; }
        public string PrimaryCaregiver2EmploymentStatus1 { get; set; }
        public bool? PrimaryCaregiver2CurrentlyInSchoolOrOtherEducationalProgram1 { get; set; }
        public bool? PostP2HomelessFamily { get; set; }
        public bool? PostP2AccessingCommunityServices { get; set; }
        public int? PostP2HomeVisitsCompleted { get; set; }
        public int? PostP2BooksReceived { get; set; }
        public int? PostP2ToysReceived { get; set; }
        public string WhyP2NotCompleted { get; set; }
    }
}