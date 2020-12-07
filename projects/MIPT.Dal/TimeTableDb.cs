using Microsoft.EntityFrameworkCore;

namespace MIPT.Dal
{
    public class TimeTableDb : DbContext
    {
        public DbSet<Group> Group { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<TimeTable> TimeTable { get; set; }

        public TimeTableDb(DbContextOptions options) : base(options)
        {
        }
    }
}