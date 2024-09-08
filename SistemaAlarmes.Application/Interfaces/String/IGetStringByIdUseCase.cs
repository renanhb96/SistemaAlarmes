using SistemaAlarmes.Domain.Entities;
using String = SistemaAlarmes.Domain.Entities.String;

namespace SistemaAlarmes.Application.Interfaces.Strings
{
    public interface IGetStringByIdUseCase
    {
        Task<String> ExecuteAsync(int id);
    }

}
