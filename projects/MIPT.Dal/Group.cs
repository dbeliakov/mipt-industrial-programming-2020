using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MIPT.Dal
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TimeTable> TimeTables { get; set; }
    }
}