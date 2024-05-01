using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Введіть значення для поля!")]
        [DisplayName("Назва книги")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Введіть значення для поля!")]
        [DisplayName("Автор книги")]
        public string? Author { get; set; }

        [Required(ErrorMessage = "Введіть значення для поля!")]
        [DisplayName("Видавництво")]
        public string? Publisher { get; set; }

        [Required(ErrorMessage = "Введіть значення для поля!")]
        [DisplayName("Рік випуску")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Введіть значення для поля!")]
        [DisplayName("Кількість сторінок")]
        public int Quantity { get; set; }

        [DisplayName("Категорія")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }
    }
}
