using Bruhunter.Shared.Documents;
using Bruhunter.Shared.Projections;
using System;

namespace Bruhunter.Tests.Common
{
    public class CandidateBuilder
    {
        private Guid id = Guid.NewGuid();
        private string firstName = "Vanya";
        private string secondName = "Ivanov";
        private Guid vacancyId = Guid.NewGuid();
        private string vacancyTitle = "Vekselnaya";

        public CandidateBuilder WithId(Guid id)
        {
            this.id = id;
            return this;
        }

        public CandidateBuilder WithFirstName(string firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public CandidateBuilder WithSecondName(string secondName)
        {
            this.secondName = secondName;
            return this;
        }

        public CandidateBuilder WithVacancyId(Guid vacancyId)
        {
            this.vacancyId = vacancyId;
            return this;
        }

        public CandidateBuilder WithVacancyTitle(string vacancyTitle)
        {
            this.vacancyTitle = vacancyTitle;
            return this;
        }

        public CandidateDocument Please()
        {
            return new CandidateDocument
            {
                Id = id,
                FirstName = firstName,
                SecondName = secondName,
                Vacancy = new CandidateVacancyDocumentProjection { Id = vacancyId, Title = vacancyTitle }
            };
        }
    }
}
