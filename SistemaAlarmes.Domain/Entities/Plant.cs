using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlarmes.Domain.Entities
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Electrocenter> Electrocenters { get; set; }
        public IEnumerable<Event> Events { get; set; }

    }

}
