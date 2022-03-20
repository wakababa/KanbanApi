namespace KanbanApi.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string? Name { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public virtual ICollection<Column>? Columns { get; set; }

    }
}
