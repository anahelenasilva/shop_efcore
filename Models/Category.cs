using System.ComponentModel.DataAnnotations;

namespace shop_efcore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Máximo 60 caracteres")]
        [MinLength(3, ErrorMessage = "Mínimo 3 caracteres")]
        public string Title { get; set; }   
    }
}