namespace SistemaAlarmes.Domain.Entities
{
    public class EventCategory
    {
        public int Id { get; set; }  // Chave primária, auto-incremento
        public string Name { get; set; }  // Nome da categoria, não pode ser nulo
        public string? Description { get; set; }  // Descrição opcional
        public DateTime CreatedAt { get; set; }  // Data de criação, com valor padrão
        public IEnumerable<Event> Events { get; set; }

    }
}