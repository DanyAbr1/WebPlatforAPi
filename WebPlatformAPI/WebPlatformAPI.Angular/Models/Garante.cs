using System.ComponentModel.DataAnnotations;

namespace WebPlatformAPI.Angular.Models
{
    public class Garante
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        public string IdGarante { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        [Display(Name = "Primer Nombre")]
        public string Nombre1 { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        [Display(Name = "Segundo Nombre")]
        public string Nombre2 { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        [Display(Name = "Apellido Paterno")]
        public string Apellido1 { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        [Display(Name = "Apellido Materno")]
        public string Apellido2 { get; set; }
        [Required]
        [Display(Name = "Cédula")]
        [MaxLength(15, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        public string Cedula { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        public string Pasaporte { get; set; }
        [Required]
        [MaxLength(1, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        public string Sexo { get; set; }
        [Required]
        [Display(Name = "Teléfono 1")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        [DataType(DataType.PhoneNumber)]
        public string Telefono1 { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Teléfono 2")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        public string Telefono2 { get; set; }

        [Display(Name = "Ubicación")]
        public int IdLocalizacion { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        public string Email { get; set; }

        [Display(Name = "Ocupación")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        public string Ocupacion { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        [Display(Name = "Nombre Empresa")]
        public string NombreEmpresa { get; set; }
        [Required]
        [MaxLength(150, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        [Display(Name = "Dirección Laboral")]
        public string DireccionLaboral { get; set; }
        [Required]
        [MaxLength(15, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        [Display(Name = "Teléfono Laboral")]
        [DataType(DataType.PhoneNumber)]
        public string TelefonoLaboral { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        public double Sueldo { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        public string Puesto { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        [Display(Name = "Jefe Inmediato")]
        public string JefeInmediato { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
        [Display(Name = "Tiempo Laborando")]
        public string TiempoLaborando { get; set; }

        [Display(Name = "Nombre Completo")]
        public string NombreCompleto => $"{Nombre1} {Nombre2} {Apellido1} {Apellido2} ";
    }
}
