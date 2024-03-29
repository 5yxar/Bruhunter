﻿using LightBDD.Framework.Scenarios;
using LightBDD.XUnit2;
using System;
using System.Threading.Tasks;

namespace Bruhunter.Tests.IntegrationTests.Features.Candidate
{
    public partial class AddCandidate_feature : FeatureFixtureBase
    {
        [Scenario]
        public async Task Candidate_should_be_saved_in_database()
        {
            await Runner.AddAsyncSteps(
                    _ => Given_candidate(GiveMe.Candidate()
                                               .Please()),
                    _ => When_add_candidate(),
                    _ => Then_database_should_contain_candidate())
                .RunAsync();
        }
    }
}
