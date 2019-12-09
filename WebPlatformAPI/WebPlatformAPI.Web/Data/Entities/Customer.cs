
namespace WebPlatformAPI.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Customer
    {
        public int Id { get; set; }

        public string Idinternal { get; set; }

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Document { get; set; }


        [Display(Name = "Nombre")]
        [MaxLength(60, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Name { get; set; }

        [Display(Name = "Apellido")]
        [MaxLength(60, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string LastName { get; set; }

        [Display(Name = "Telefono 1")]
        [MaxLength(14, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Telephone { get; set; }

        [Display(Name = "Telefono 2")]
        [MaxLength(14, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Telephone1 { get; set; }

        [Display(Name = "Telefono 3")]
        [MaxLength(14, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Telephone2 { get; set; }

        [Display(Name = "Telefono 4")]
        [MaxLength(14, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Telephone3 { get; set; }

        [Display(Name = "Sexo")]
        [MaxLength(1, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Gender { get; set; }

        [Display(Name = "Direccion")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Addres { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [MaxLength(10, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string BirthDate { get; set; }

        [Display(Name = "Estado Civil")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string CivilStatus { get; set; }

        [Display(Name = "Compañia")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Company { get; set; }

        [Display(Name = "Posición Laboral")]
        [MaxLength(60, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Job { get; set; }

        [Display(Name = "Numero Comprobante Fiscal")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string RNC { get; set; }

        [Display(Name = "Pasaporte")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Passport { get; set; }

        [Display(Name = "Nacionalidad")]
        [MaxLength(60, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Nationality { get; set; }

        public float CreditLimit { get; set; }

    }
}
