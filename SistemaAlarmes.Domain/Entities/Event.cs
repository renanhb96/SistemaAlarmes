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

        // Eletrocentro
        public int? EletrocentroId { get; set; }

        // Inversor
        public int? InverterId { get; set; }

        // String
        public int? StringId { get; set; }

        // Painel
        public int? PanelId { get; set; }
        public Panel Panel { get; set; }

        // Outros campos do evento
        public AssetType AssetType { get; set; }
        public int EventCategoryId { get; set; }
        public string Severity { get; set; }  // Criticidade do evento
        public DateTime StartDate { get; set; }
        public DateTime? EndedDate { get; set; }
        public string Description { get; set; }
    }
}
