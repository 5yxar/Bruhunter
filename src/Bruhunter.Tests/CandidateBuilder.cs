using Bruhunter.Shared.Documents;
using System;

namespace Bruhunter.Tests
{
    public  class CandidateBuilder
    {
        private Guid id;
        private string firstName = "Vanya";
        private string secondName = "Ivanov";

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

        public CandidateDocument Please()
        {
            return new CandidateDocument
            {
                Id = id,
                FirstName = firstName,
                SecondName = secondName
            };
        }
    }
}
