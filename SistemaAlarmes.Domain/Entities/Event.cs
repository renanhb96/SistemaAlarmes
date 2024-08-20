using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlarmes.Domain.Entities
{
    public class Event
    {
        public Guid IdEventFramePISystem { get; set; }
        public string AssetName { get; set; }
        public string AssetType { get; set; }
        public string EventType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndedDate { get; set; }
        public string Description { get; set; }
        public int PlantId { get; set; }
    }
}
