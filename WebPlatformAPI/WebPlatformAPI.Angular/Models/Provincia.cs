using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebPlatformAPI.Angular.Models
{
    public class Provincia
    {
        [Key]
        public int Id { get; set; }
        public string IdProvincia { get; set; }
        public string nombre { get; set; }
    }
}
