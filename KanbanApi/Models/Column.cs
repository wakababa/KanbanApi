namespace KanbanApi.Models
{
    public class Column
    {
        public int ColumnId { get; set; }
        public string? Name { get; set; }
        public int ProjectId { get; set; }
        public Project? Project { get; set; }
        public virtual ICollection<Issue>? Issues { get; set; }

    }
}
