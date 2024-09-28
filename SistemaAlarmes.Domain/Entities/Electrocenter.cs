using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlarmes.Domain.Entities
{
    public class Electrocenter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PlantId { get; set; }
        public Plant Plant { get; set; }  // Relação com a usina
        public IEnumerable<Inverter> Inverters { get; set; }
        public IEnumerable<Event> Events { get; set; }

    }

}
