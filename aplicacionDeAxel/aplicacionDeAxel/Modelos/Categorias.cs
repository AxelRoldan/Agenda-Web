using System.ComponentModel.DataAnnotations;

namespace aplicacionDeAxel.Modelos


{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Etiqueta")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(maximumLength: 12, ErrorMessage = "El campo debe contener entre (4) y (12) caracteres", MinimumLength = 4)]
        public String NombreCategoria { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Creado el dia")]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

    }
}
