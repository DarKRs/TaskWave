using System.ComponentModel.DataAnnotations;

namespace TaskWave.Domain.Entities
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
