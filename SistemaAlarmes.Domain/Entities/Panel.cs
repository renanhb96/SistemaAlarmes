using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlarmes.Domain.Entities
{
    public class Panel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StringId { get; set; }
        public String String { get; set; }  // Relação com a string
    }
}
