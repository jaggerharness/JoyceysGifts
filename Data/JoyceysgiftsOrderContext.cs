using Microsoft.EntityFrameworkCore;
using joyceysgifts.Models;

namespace joyceysgifts.Data
{
    public class JoyceysgiftsOrderContext : DbContext
    {
        public JoyceysgiftsOrderContext (DbContextOptions<JoyceysgiftsOrderContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Order { get; set; }
    }
}