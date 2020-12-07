using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MIPT.Dal
{
    public class TimeTable
    {
        [Key]
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int SubjectId { get; set; }
        public DateTimeOffset StartAt { get; set; }
        public DateTimeOffset FinishAt { get; set; }

        [ForeignKey("GroupId")] public Group GroupRef { get; set; }
        [ForeignKey("SubjectId")] public Subject SubjectRef { get; set; }
    }
}