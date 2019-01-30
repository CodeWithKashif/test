using PCHP.Core;
using System;

namespace PCHP.ViewModel
{
    public class NotificationVm
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int UserId { get; set; }
      
        public bool IsRead { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
     
    }

    public class NotificationGridResultVm : TGridResultViewModel
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int UserId { get; set; }

        public bool IsRead { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UnreadNotifications { get; set; }

    }

    public class NotificationSearchRequest : GridParameter
    {
        public int UserId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Status { get; set; }
    }
    public class NotificationLogVM
    {
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Name { get; set; }
        public string MessageLabel { get; set; }
        public string Rolevalue { get; set; }
    }
}