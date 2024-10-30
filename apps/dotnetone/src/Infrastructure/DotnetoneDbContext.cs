using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dotnetone.Infrastructure;

public class DotnetoneDbContext : IdentityDbContext<IdentityUser>
{
    public DotnetoneDbContext(DbContextOptions<DotnetoneDbContext> options)
        : base(options) { }
}
