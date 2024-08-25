using SistemaAlarmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlarmes.Application.Interfaces.Event
{
    public interface IProcessEventUseCase
    {
        Task ExecuteAsync(Domain.Entities.Event eventItem);
    }
}
