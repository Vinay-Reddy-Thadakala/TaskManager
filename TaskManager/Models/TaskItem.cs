using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class TaskItem
    {
        public int Id { set; get; }

        [Required]
        public string Title { set; get; }

        public string Description { set; get; }

        public bool IsCompleted { set; get; }
    }
}
