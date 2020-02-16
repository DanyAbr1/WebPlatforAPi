using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebPlatformAPI.Angular.Models
{
    public class Localizacion
    {
        [Key]
        public int Id { get; set; }
        public string IdLocalizacion { get; set; }
        public int IdProvincia { get; set; }
        public int IdMunicipio { get; set; }
        public int IdSector { get; set; }
        public string Barrio { get; set; }
        public string Detalles { get; set; }
        public string GoogleMapUrl { get; set; }

    }
}
