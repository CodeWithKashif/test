using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class LoginResult : ApiResult
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int MisLanguagePrefrence { get; set; }
        public string UserImageUrl { get; set; }
        public List<UserRoleBridgeVM> UserRoles { get; set; }
        public List<RolePermissionVm> RoleAccess { get; set; }

        public LoginResult()
        {
            UserRoles=new List<UserRoleBridgeVM>();
            RoleAccess =new List<RolePermissionVm>();
        }
    }

    public class RolePermissionVm
    {
        public string Module { get; set; }
        public string Permission { get; set; }
    }
}