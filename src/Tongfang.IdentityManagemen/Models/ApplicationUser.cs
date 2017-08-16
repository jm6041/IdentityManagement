using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Tongfang.IdentityManagemen.Models
{
    /// <summary>
    /// 用户<see cref="IdentityUser"/>
    /// </summary>
    public class ApplicationUser : IdentityUser<Guid>
    {
    }
}
