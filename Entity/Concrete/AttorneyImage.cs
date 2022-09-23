using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class AttorneyImage
    {
        public int Id { get; set; }
        public int AttorneyId { get; set; }
        public string? ImagePath { get; set; }
    }
}
