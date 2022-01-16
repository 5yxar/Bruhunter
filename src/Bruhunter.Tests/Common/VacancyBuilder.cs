using Bruhunter.Shared.Documents;
using System;

namespace Bruhunter.Tests.Common
{
    public class VacancyBuilder
    {
        private Guid id = Guid.NewGuid();
        private string title = "Архитектор ОЗОН";
        private string address = "Москва, СССР";
        private string description = "Мемы нужно будет кидать в мемную, та и все";
        private DateTime jobClosingDate = DateTime.Parse("01.12.2022");

        public VacancyBuilder WithId(Guid id)
        {
            this.id = id;
            return this;
        }

        public VacancyBuilder WithTitle(string title)
        {
            this.title = title;
            return this;
        }

        public VacancyBuilder WithAddress(string address)
        {
            this.address = address;
            return this;
        }

        public VacancyBuilder WithDescription(string description)
        {
            this.description = description;
            return this;
        }

        public VacancyBuilder WithJobClosingDate(DateTime jobClosingDate)
        {
            this.jobClosingDate = jobClosingDate;
            return this;
        }

        public VacancyDocument Please()
        {
            return new VacancyDocument
            {
                Id = id,
                Title = title,
                Address = address,
                Description = description,
                JobClosingDate = jobClosingDate
            };
        }
    }
}
