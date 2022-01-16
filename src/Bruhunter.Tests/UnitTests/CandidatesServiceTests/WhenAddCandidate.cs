using Bruhunter.Application;
using Bruhunter.Shared.Documents;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Bruhunter.Tests.UnitTests.CandidatesServiceTests
{
    public class WhenAddCandidate : TestBase
    {
        [Fact]
        public async Task CandidateDocumentIdShouldNotBeEmptyGuid()
        {
            var candidateBeforeAddition = new CandidateDocument
            {
                Id = Guid.Empty,
                FirstName = "Test candidate first name",
                SecondName = "Test candidate second name"
            };

            await CandidatesService.AddCandidate(candidateBeforeAddition);

            var candidates = await CandidatesRepositoryMock.GetAllCandidates();
            var candidate = candidates.Single();

            Assert.NotEqual(Guid.Empty, candidate.Id);
        }

        [Fact]
        public async Task CandidatesRepositoryAddCandidateMethodCalled()
        {
            var candidate = new CandidateDocument();

            await CandidatesService.AddCandidate(candidate);

            Assert.True(CandidatesRepositoryMock.AddCandidateMethodCalled);
        }
    }
}
