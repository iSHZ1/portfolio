using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NutsShop.Models
{
    public class ApplicationType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
