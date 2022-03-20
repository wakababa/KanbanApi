namespace KanbanApi.Models
{
    public class Issue
    {
        public int IssueId { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }
        public int ColumnId { get; set; }

        public Column? Column { get; set; }

    }
}
