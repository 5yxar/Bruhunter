using Bruhunter.Application;
using Bruhunter.Tests.UnitTests.Mocks;

namespace Bruhunter.Tests.UnitTests
{
    public class TestBase
    {
        public TestBase()
        {
            CandidatesRepositoryMock = new CandidatesRepositoryMock();
            CandidatesService = new CandidatesService(CandidatesRepositoryMock);
        }

        protected CandidatesService CandidatesService { get; private set; }
        protected CandidatesRepositoryMock CandidatesRepositoryMock { get; private set; }
    }
}
