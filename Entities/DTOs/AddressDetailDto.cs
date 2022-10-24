using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class AddressDetailDto
    {
        public int Id { get; set; }
        public City City { get; set; }
        public District District { get; set; }
        public string AddressDetail { get; set; }
    }
}
