namespace parcial.Models
{
    using System.ComponentModel.DataAnnotations; // Necesario para usar Data Annotations
        public class Producto
        {
            public int Id { get; set; }

            [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
            [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres.")]
            [Display(Name = "Nombre del Producto")] // Etiqueta amigable para la interfaz de usuario
            public string Nombre { get; set; }

            [Required(ErrorMessage = "El precio es obligatorio.")]
            [Range(0.01, 10000.00, ErrorMessage = "El precio debe estar entre 0.01 y 10000.00.")]
            [DataType(DataType.Currency)] // Sugiere un formato de moneda en la UI
            [Display(Name = "Precio Unitario")]
            public decimal Precio { get; set; }

            [Required(ErrorMessage = "El stock es obligatorio.")]
            [Range(0, int.MaxValue, ErrorMessage = "El stock no puede ser negativo.")]
            [Display(Name = "Cantidad en Stock")]
            public int Stock { get; set; }
        }
    
}
