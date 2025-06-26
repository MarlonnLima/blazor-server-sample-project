using System.ComponentModel.DataAnnotations;

namespace BlazingShop.Models
{
    public class Category
    {
        [Key]
        [Required(ErrorMessage = "Id é obrigatório")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Título é obrigatório")]
        [MaxLength(50, ErrorMessage = "Título não pode ter mais de 50 caracteres")]
        [MinLength(5, ErrorMessage = "Título deve ter pelo menos 5 caracteres")]
        public string Title { get; set; }
    }
}
