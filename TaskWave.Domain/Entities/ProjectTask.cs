using System.ComponentModel.DataAnnotations;

namespace TaskWave.Domain.Entities
{
    public class ProjectTask
    {
        [Key]
        public int TaskId { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }

}
