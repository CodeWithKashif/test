using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCHP.ViewModel
{
    public class MasterDataVM
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public MasterDataVM()
        {

        }
    }
    public class EthencityMasterDataVM
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public List<SubEthencityMasterDataVM> SubEthenicity {get;set;}
        public EthencityMasterDataVM()
        {
            SubEthenicity = new List<SubEthencityMasterDataVM>();
        }
    }
    public class SubEthencityMasterDataVM
    {
        public int Id { get; set; }
        public int EthinicityId { get; set; }
        public string Value { get; set; }
        public SubEthencityMasterDataVM()
        {

        }
    }
    public class SubDropDownMasterDataVM
    {
        public int Id { get; set; }
        public string ParentOption { get; set; }
        public string Type { get; set; }
        public SubDropDownMasterDataVM()
        {

        }
    }
}
