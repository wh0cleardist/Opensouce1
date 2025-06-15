using System.ComponentModel.DataAnnotations;

namespace parcial.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres.")]
        [Display(Name = "Nombre del Producto")]
        public required string Nombre { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio.")]
        [Range(typeof(decimal), "0.01", "10000.00", ErrorMessage = "El precio debe estar entre 0.01 y 10000.00.")]
        [Display(Name = "Precio Unitario")]
        [DataType(DataType.Currency)]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El stock es obligatorio.")]
        [Range(0, int.MaxValue, ErrorMessage = "El stock no puede ser negativo.")]
        [Display(Name = "Cantidad en Stock")]
        public int Stock { get; set; }


        [Display(Name = "Fecha de Registro")]
        [DataType(DataType.Date)]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}

