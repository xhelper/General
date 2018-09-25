using System.ComponentModel.DataAnnotations.Schema;

namespace Genneral.Entities.Category
{
    [Table("Category")]
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMenu { get; set; }
        public string SysResource { get; set; }
        public int ResourceId { get; set; }
        public string FatherResource { get; set; }
        public int FatherId { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string RuteName { get; set; }
        public string CssClass { get; set; }
        public int Sort { get; set; }
        public bool IsDisabled { get; set; }
    }
}
