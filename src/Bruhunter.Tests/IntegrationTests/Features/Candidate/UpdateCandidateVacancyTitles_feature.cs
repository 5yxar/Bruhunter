using LightBDD.Framework.Scenarios;
using LightBDD.XUnit2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruhunter.Tests.IntegrationTests.Features.Candidate
{
    public partial class UpdateCandidateVacancyTitles_feature : FeatureFixtureBase
    {
        [Scenario]
        public async Task Candidates_vacancy_title_should_be_updated_in_database()
        {
            var candidateId = Guid.NewGuid();
            var vacancyId = Guid.NewGuid();
            var expectedVacancyTitle = "New";

            await Runner.AddAsyncSteps(_ => Given_candidate_in_database(
                                                GiveMe.Candidate()
                                                .WithVacancyId(vacancyId)
                                                .Please()),
                                       _ => Given_candidate_in_database(
                                                GiveMe.Candidate()
                                                .WithVacancyId(vacancyId)
                                                .Please()),
                                       _ => When_changed_candidates_vacancy_titles(
                                                GiveMe.Vacancy()
                                                .WithId(vacancyId)
                                                .WithTitle(expectedVacancyTitle)
                                                .CandidateProjectionPlease()),
                                      _ => Then_candidates_vacancy_title_in_database_should_be(expectedVacancyTitle))

                        .RunAsync();
        }
    }
}
