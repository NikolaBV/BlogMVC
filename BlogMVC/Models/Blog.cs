using System.ComponentModel.DataAnnotations;

namespace BlogMVC.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
