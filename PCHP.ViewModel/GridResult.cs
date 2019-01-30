using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class GridResult<T> where T : class 
    {
        public int TotalRecordFound { get; set; }
        public List<T> Results { get; set; }
    }
}