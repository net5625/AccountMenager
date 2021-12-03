using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AccountMenager.Models.Identity
{
    public class Database : IdentityDbContext<User>
    {
        public Database(DbContextOptions<Database> options) : base(options)
        {

        }
    }
}
