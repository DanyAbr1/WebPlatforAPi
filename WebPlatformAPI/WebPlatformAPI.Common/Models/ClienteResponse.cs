using System.ComponentModel.DataAnnotations;

namespace WebPlatformAPI.Common.Entities
{
    public class ClienteResponse
    {
        public int Id { get; set; }

        public string Idcliente { get; set; }

        [Required]
        [MaxLength(50,ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]          
        public string Nombre { get; set; }

        public string Nombre2 { get; set; }

        public string Apellido { get; set; }

        public string Apellido2 { get; set; }
        
        [Required]
        public string Cedula { get; set; }

        public string Pasaporte { get; set; }

        public string RNC { get; set; }

        public string Telefono { get; set; }

        public string Telefon2 { get; set; }

        public string Telefono3 { get; set; }

        public string Direccion { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public string Municipio { get; set; }
    }
}