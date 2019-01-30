namespace PCHP.ViewModel.Results
{
    public class StaffGridResult
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public int RoleLevel { get; set; }
        public string RoleName { get; set; }
        public string SiteName { get; set; }
        public string RegionName { get; set; }
        public string RoleStartDate { get; set; }
        public string RoleEndDate { get; set; }
        public int TotalRecordFound { get; set; }

    }
}
