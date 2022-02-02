using System;

namespace Bruhunter.Shared.Projections
{
    public record CandidateVacancyDocumentProjection
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}
