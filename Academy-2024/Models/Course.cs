using System.ComponentModel.DataAnnotations;

namespace Academy_2024.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public ICollection<User> Users { get; set; } = [];
    }
}
