using System.ComponentModel.DataAnnotations;

namespace bai_test_1.Models
{
    public class Device
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Type { get; set; }

        public string Status { get; set; }  // Available / In-use / Broken
    }
}
