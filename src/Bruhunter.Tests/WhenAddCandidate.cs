﻿using Bruhunter.Application;
using Bruhunter.Shared.Documents;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Bruhunter.Tests
{
    public class WhenAddCandidate
    {
        [Fact]
        public async Task CandidateDocumentIdShouldBeNewGuid()
        {
            var candidateBeforeInsert = new CandidateDocument
            {
                Id = Guid.Empty,
                FirstName = "Test candidate first name",
                SecondName = "Test candidate second name"
            };
            var candidatesRepository = new CandidatesRepositoryMock();
            var service = new CandidatesService(candidatesRepository);

            await service.AddCandidate(candidateBeforeInsert);

            var candidates = await candidatesRepository.GetAllCandidates();
            var candidate = candidates.Single();
            Assert.NotEqual(Guid.Empty,candidate.Id);
        }

        [Fact]
        public async Task CandidatesRepositoryAddCandidateMethodCalled()
        {
            var candidate = new CandidateDocument();
            var candidatesRepository = new CandidatesRepositoryMock();
            var service = new CandidatesService(candidatesRepository);

            await service.AddCandidate(candidate);

            Assert.True(candidatesRepository.AddCandidateMethodCalled);
        }
    }
}