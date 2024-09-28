using SistemaAlarmes.Domain.Enums;
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

        // Usina (Plant)
        public int? PlantId { get; set; }
        virtual public Plant Plant { get; set; }   

        // Eletrocentro
        public int? ElectrocenterId { get; set; }
        public virtual Electrocenter Electrocenter { get; set; }    

        // Inversor
        public int? InverterId { get; set; }
        public virtual Inverter Inverter { get; set; }  

        // Module
        public int? ModuleId { get; set; }
        public virtual Module Module { get; set; }

        // Outros campos do evento
        public AssetType AssetType { get; set; }
        public int EventCategoryId { get; set; }
        public virtual EventCategory EventCategory { get; set; }    
        public string Severity { get; set; }  // Criticidade do evento
        public DateTime StartDate { get; set; }
        public DateTime? EndedDate { get; set; }
        public string Description { get; set; }
    }
}
