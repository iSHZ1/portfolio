using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NutsShop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Name")]
        [Required]
        [Range(1, int.MaxValue,ErrorMessage ="Введите значение больше 0")]
        public int DisplayOrder { get; set; }
    }
}
