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
            CandidatesRepository = new CandidatesRepositoryMock();
            CandidatesService = new CandidatesService(CandidatesRepository);
        }

        protected CandidatesService CandidatesService { get; private set; }
        protected ICandidatesRepository CandidatesRepository { get; private set; }
    }
}
