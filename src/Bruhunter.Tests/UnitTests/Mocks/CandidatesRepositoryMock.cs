﻿using Bruhunter.DataAccessLayer;
using Bruhunter.Shared.Documents;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bruhunter.Tests.UnitTests.Mocks
{
    public class CandidatesRepositoryMock : ICandidatesRepository
    {
        private static List<CandidateDocument> candidates;

        public CandidatesRepositoryMock()
        {
            candidates = new List<CandidateDocument>();
        }

        public bool AddCandidateMethodCalled { get; private set; }

        public async Task AddCandidate(CandidateDocument candidateDocument)
        {
            candidates.Add(candidateDocument);
            AddCandidateMethodCalled = true;
        }

        public async Task<IEnumerable<CandidateDocument>> GetAllCandidates()
        {
            return candidates;
        }

        public async Task DeleteCandidate(Guid guid)
        {
            candidates.RemoveAll(x => x.Id == guid);
        }

        public Task<CandidateDocument> GetCandidate(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CandidateDocument>> GetAllCandidatesByVacancyId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task ChangeCandidate(CandidateDocument candidateDocument)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCandidates(IEnumerable<CandidateDocument> candidatesCollection)
        {
            throw new NotImplementedException();
        }
    }
}
