﻿using System;
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
        public int ElectrocenterId { get; set; }
        public Electrocenter Electrocenter { get; set; }
        public IEnumerable<Module> Modules { get; set; }
        public IEnumerable<Event> Events { get; set; }

    }
}
