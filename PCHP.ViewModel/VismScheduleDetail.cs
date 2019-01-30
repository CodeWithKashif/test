using System;
using PCHP.Core.Enums;

namespace PCHP.ViewModel
{
    public class VismScheduleDetailViewModel
    {
        public int Id { get; set; }
        public int VismScheduleId { get; set; }

        public VismType VismType { get; set; }
        public int VismId { get; set; }
        public string VismName { get; set; }
        public int VismOrder { get; set; }

    }
}