using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojasMoveis.Models
{
    [Table("Moveis")]
    public class Movel
    {
        [Key]
        public int MovelId { get; set; }

        [Required(ErrorMessage = "O nome do movel deve ser informado")]
        [Display(Name = "Nome do Movel")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "A descrição do movel deve ser informado")]
        [Display(Name = "Descrição do Movel")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição pode exceder {1} caracteres")]
        public string DescricaoCurta { get; set; } = string.Empty;

        [Required(ErrorMessage = "A descrição detalhada do movel deve ser informada")]
        [Display(Name = "Descrição detalhada do movel")]
        [MinLength(20, ErrorMessage = "Descrição detalhada deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição detalhada pode exceder {1} caracteres")]
        public string DescricaoDetalhada { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o preço do movel")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 99999.99, ErrorMessage = "O preço deve estar entre R$ 1,00 e R$ 99.999,99")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string? ImagemUrl { get; set; }

        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string? ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsMovelPreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        [Display(Name = "Categorias")]
        public int CategoriaId { get; set; }
        public virtual Categoria? Categoria { get; set; }
    }
}
