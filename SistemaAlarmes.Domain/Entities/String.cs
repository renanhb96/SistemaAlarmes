using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlarmes.Domain.Entities
{
    public class String
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InverterId { get; set; }
        public Inverter Inverter { get; set; }  // Relação com o inversor
    }
}
