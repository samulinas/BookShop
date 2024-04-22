using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Введіть значення для поля!")]
        [StringLength(50)]
        [DisplayName("Назва категорії")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Введіть значення для поля!")]
        [DisplayName("Порядок відображення")]
        [Range(1, int.MaxValue, ErrorMessage = "Значення порядку відображення повинно бути більше нуля!")]
        public int DisplayOrder { get; set; }
    }
}
