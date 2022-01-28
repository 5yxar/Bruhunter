using System;

namespace Bruhunter.Shared.Documents
{
    public record CandidateDocument
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public CandidateVacancyDocumentProjection Vacancy { get; set; }
    }
}
