using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlarmes.Domain.Entities
{
    public class Inverter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EletrocentroId { get; set; }
        public Eletrocentro Eletrocentro { get; set; }  // Relação com o eletrocentro
    }
}
