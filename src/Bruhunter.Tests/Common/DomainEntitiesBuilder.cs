namespace Bruhunter.Tests.Common
{
    public class DomainEntitiesBuilder
    {
        public CandidateBuilder Candidate()
        {
            return new CandidateBuilder();
        }

        public VacancyBuilder Vacancy()
        {
            return new VacancyBuilder();
        }
    }
}
