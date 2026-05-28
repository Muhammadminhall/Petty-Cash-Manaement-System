namespace PettyCash.Core.Models
{
    /// <summary>Third entity model — expense categories managed by the user.</summary>
    public class Category
    {
        public int    Id   { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
