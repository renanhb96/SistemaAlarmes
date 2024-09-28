using SistemaAlarmes.Application.Interfaces.Email;
using SistemaAlarmes.Application.Interfaces.Event;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Domain.Enums;
using SistemaAlarmes.Infrastructure.Interfaces;
using SistemaAlarmes.Infrastructure.Repositories;

public class ProcessEventUseCase : IProcessEventUseCase
{
    private readonly IEventRepository _eventRepository;
    private readonly ISendEmailUseCase _sendEmailUseCase;
    private readonly IPlantRepository _plantRepository;
    private readonly IElectrocenterRepository _electrocenterRepository;
    private readonly IInverterRepository _inverterRepository;
    private readonly IModuleRepository _moduleRepository;

    public ProcessEventUseCase(
        IEventRepository eventRepository,
        ISendEmailUseCase sendEmailUseCase,
        IPlantRepository plantRepository,
        IElectrocenterRepository electrocenterRepository,
        IInverterRepository inverterRepository,
        IModuleRepository moduleRepository)
    {
        _eventRepository = eventRepository;
        _sendEmailUseCase = sendEmailUseCase;
        _plantRepository = plantRepository;
        _electrocenterRepository = electrocenterRepository;
        _inverterRepository = inverterRepository;
        _moduleRepository = moduleRepository;
    }

    public async Task ExecuteAsync(Event eventItem)
    {
        // Valida a hierarquia dos IDs
        await ValidateHierarchyAsync(eventItem);

        // Salva o evento no banco
        await _eventRepository.AddAsync(eventItem);

        // Envia email se o evento for crítico
        if (eventItem.Severity == SeverityType.Critical.ToString())
        {
            string subject = "Critical Event Alert";
            string body = $"A critical event occurred: {eventItem.AssetType}. Description: {eventItem.Description}";
            await _sendEmailUseCase.ExecuteAsync("operator@yourcompany.com", subject, body);
        }
    }

    private async Task ValidateHierarchyAsync(Event eventItem)
    {
        if (eventItem.PlantId.HasValue)
        {
            var plant = await _plantRepository.GetByIdAsync(eventItem.PlantId.Value);
            if (plant == null) throw new Exception("Plant ID does not exist.");
        }

        if (eventItem.EletrocentroId.HasValue)
        {
            var eletrocentro = await _electrocenterRepository.GetByIdAsync(eventItem.EletrocentroId.Value);
            if (eletrocentro == null) throw new Exception("Eletrocentro ID does not exist.");

            if (eventItem.PlantId.HasValue && eletrocentro.PlantId != eventItem.PlantId.Value)
            {
                throw new Exception("Eletrocentro does not belong to the specified Plant.");
            }
        }

        if (eventItem.InverterId.HasValue)
        {
            var inverter = await _inverterRepository.GetByIdAsync(eventItem.InverterId.Value);
            if (inverter == null) throw new Exception("Inverter ID does not exist.");

            if (eventItem.EletrocentroId.HasValue && inverter.EletrocentroId != eventItem.EletrocentroId.Value)
            {
                throw new Exception("Inverter does not belong to the specified Eletrocentro.");
            }
        }

        if (eventItem.StringId.HasValue)
        {
            var stringEntity = await _moduleRepository.GetByIdAsync(eventItem.StringId.Value);
            if (stringEntity == null) throw new Exception("Module ID does not exist.");

            if (eventItem.InverterId.HasValue && stringEntity.InverterId != eventItem.InverterId.Value)
            {
                throw new Exception("Module does not belong to the specified Inverter.");
            }
        }
    }
}
