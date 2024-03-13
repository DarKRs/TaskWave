using System.ComponentModel.DataAnnotations;

namespace TaskWave.Domain.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public ICollection<ProjectTask> Tasks { get; set; }
        public ICollection<Team> Teams { get; set; }
    }


}
