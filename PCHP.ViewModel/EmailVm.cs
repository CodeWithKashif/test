namespace PCHP.ViewModel
{
    public class EmailVm
    {
        public int Id { get; set; }
        public int? ProviderId { get; set; }
        public int? SiteId { get; set; }
        public int? UserId { get; set; }
        public int? ChildId { get; set; }
        public string Email { get; set; } //Email
        public bool IsPrimaryEmail { get; set; }
        public bool IsActive { get; set; }
    }
}