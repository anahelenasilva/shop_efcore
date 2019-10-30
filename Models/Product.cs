using System.ComponentModel.DataAnnotations;

namespace shop_efcore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Máximo 60 caracteres")]
        [MinLength(3, ErrorMessage = "Mínimo 3 caracteres")]
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "Máximo 1024 caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Categoria Inválida")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}