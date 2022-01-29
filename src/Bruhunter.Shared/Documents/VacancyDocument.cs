using System;

namespace Bruhunter.Shared.Documents
{
    public class VacancyDocument
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public DateTime JobClosingDate { get; set; }

        public CandidateVacancyDocumentProjection ToCandidateVacancyDocumentProjection()
        {
            return new CandidateVacancyDocumentProjection() { Id = Id, Title = Title };
        }
    }
}
