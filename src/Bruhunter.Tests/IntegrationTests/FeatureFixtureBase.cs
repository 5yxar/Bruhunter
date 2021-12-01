using Bruhunter.Application;
using Bruhunter.DataAccessLayer;
using Bruhunter.Tests.Common;
using LightBDD.XUnit2;
using LiteDB;
using System.IO;

namespace Bruhunter.Tests.IntegrationTests
{
    public class FeatureFixtureBase : FeatureFixture
    {
        public DomainEntitiesBuilder GiveMe { get; }

        public FeatureFixtureBase()
        {
            GiveMe = new DomainEntitiesBuilder();
            CandidatesRepository = new CandidatesRepository(new LiteDatabase(new MemoryStream()));
            CandidatesService = new CandidatesService(CandidatesRepository);
        }

        protected ICandidatesRepository CandidatesRepository { get; private set; }
        protected CandidatesService CandidatesService { get; private set; }
    }
}
