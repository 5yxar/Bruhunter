using System;

namespace Bruhunter.Shared.Documents
{
    public class VacancyDocument
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string JobClosingDate { get; set; }
    }
}
