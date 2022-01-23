using Bruhunter.Application;
using Bruhunter.Tests.UnitTests.Mocks;
using Microsoft.Extensions.Logging.Abstractions;

namespace Bruhunter.Tests.UnitTests
{
    public class TestBase
    {
        public TestBase()
        {
            CandidatesRepositoryMock = new CandidatesRepositoryMock();
            CandidatesService = new CandidatesService(CandidatesRepositoryMock, NullLogger<CandidatesService>.Instance);
        }

        protected CandidatesService CandidatesService { get; private set; }
        protected CandidatesRepositoryMock CandidatesRepositoryMock { get; private set; }
    }
}
