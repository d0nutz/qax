using System;

namespace qax.Entities
{
    public record Workplace
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public DateTimeOffset CreatedDate { get; init;}
    }
}
