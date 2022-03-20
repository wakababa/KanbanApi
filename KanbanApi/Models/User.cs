namespace KanbanApi.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<Project>? Projects { get; set; }
    }
}
