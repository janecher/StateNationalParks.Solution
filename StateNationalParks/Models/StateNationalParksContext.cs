using Microsoft.EntityFrameworkCore;

namespace StateNationalParks.Models
{
    public class StateNationalParksContext : DbContext
    {
        public StateNationalParksContext(DbContextOptions<StateNationalParksContext> options)
            : base(options)
        {
        }

        public DbSet<StatePark> StateParks { get; set; }
        public DbSet<NationalPark> NationalParks { get; set; }
    }
}