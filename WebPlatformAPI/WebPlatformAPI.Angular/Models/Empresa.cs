using System.ComponentModel.DataAnnotations;

namespace WebPlatformAPI.Angular.Models
{
    public class Empresa
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        public string NombreComercial { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        public string Tipo { get; set; }
        
        [Required]
        [MaxLength(15, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        public string RNC { get; set; }
        
        [Required]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(15, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        public string Telefono1 { get; set; }
        
        [MaxLength(15, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        [DataType(DataType.PhoneNumber)]
        public string Telefono2 { get; set; }
        
        [MaxLength(15, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        [DataType(DataType.PhoneNumber)]
        public string Fax { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [MaxLength(150, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        public string Direccion { get; set; }
        
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        public string Ubicacion { get; set; }
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        public string Logo { get; set; }
    }
}
