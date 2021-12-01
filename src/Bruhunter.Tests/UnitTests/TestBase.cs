using Bruhunter.Application;
using Bruhunter.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruhunter.Tests.UnitTests.Mocks
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
