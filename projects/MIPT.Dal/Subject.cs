using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MIPT.Dal
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<TimeTable> TimeTables { get; set; }
    }
}