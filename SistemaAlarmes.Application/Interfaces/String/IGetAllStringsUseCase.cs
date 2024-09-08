using SistemaAlarmes.Domain.Entities;
using String = SistemaAlarmes.Domain.Entities.String;

namespace SistemaAlarmes.Application.Interfaces.Strings
{
    public interface IGetAllStringsUseCase
    {
        Task<IEnumerable<String>> ExecuteAsync();
    }
}
