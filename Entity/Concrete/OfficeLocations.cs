using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class OfficeLocations
    {
        public int Id { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Quarter { get; set; }
        public string? GoogleMapsLink { get; set; }
    }
}
