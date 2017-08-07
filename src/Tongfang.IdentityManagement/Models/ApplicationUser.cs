using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Tongfang.IdentityManagement.Models
{
    /// <summary>
    /// 用户<see cref="IdentityUser"/>
    /// </summary>
    public class ApplicationUser : IdentityUser<Guid>
    {
    }

    /// <summary>
    /// 角色<see cref="IdentityRole"/>
    /// </summary>
    public class ApplicationRole : IdentityRole<Guid>
    {
    }
}
