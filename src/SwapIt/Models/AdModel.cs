using System.ComponentModel.DataAnnotations;

namespace SwapIt.Models
{
    public class AdModel
    {
        [Key]
        public long AdId { get; set; }

        public string Owner { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}