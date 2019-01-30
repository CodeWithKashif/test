using PCHP.Core.Enums;

namespace PCHP.ViewModel
{
    public class ApiResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public ResponseCode ResponseCode { get; set; }
        public int ChildScheduleId { get; set; }

    }
}