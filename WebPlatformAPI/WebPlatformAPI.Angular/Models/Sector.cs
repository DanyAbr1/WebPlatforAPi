using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebPlatformAPI.Angular.Models
{
    public class Sector
    {
        [Key]
        public int Id { get; set; }
        public string IdSector{ get; set; }
        public string nombre { get; set; }
    }
}
