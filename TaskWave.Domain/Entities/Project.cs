using System.ComponentModel.DataAnnotations;

namespace TaskWave.Domain.Entities
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public ICollection<ProjectTask> Tasks { get; set; }
    }
}
