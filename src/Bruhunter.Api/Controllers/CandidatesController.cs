using Microsoft.AspNetCore.Mvc;
using Bruhunter.Shared.Documents;
using Bruhunter.Application;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace Bruhunter.Api.Controllers
{
    [ApiController]
    [Route("api/candidates")]
    public class CandidatesController : ControllerBase
    {
        private readonly CandidatesService candidatesService;
        private readonly VacanciesService vacanciesService;

        public CandidatesController(CandidatesService candidatesService, VacanciesService vacanciesService)
        {
            this.candidatesService = candidatesService;
            this.vacanciesService = vacanciesService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<CandidateDocument> GetCandidate(Guid id)
        {
            return await candidatesService.GetCandidate(id);
        }

        [HttpGet]
        [Route("query")]
        public async Task<IEnumerable<CandidateDocument>> GetAllCandidates()
        {
           var a = await candidatesService.GetAllCandidates();
            return a;
        }

        [HttpGet]
        [Route("vacancies")]
        public async Task<IEnumerable<CandidateVacancyDocumentProjection>> GetAllCandidateVacancies()
        {
            return await vacanciesService.GetAllCandidateVacancies();
        }


        [HttpPost]
        public async Task CreateCandidate(CandidateDocument candidateDocument)
        {
            await candidatesService.AddCandidate(candidateDocument);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task ChangeCandidate(CandidateDocument candidateDocument)
        {
            await candidatesService.ChangeCandidate(candidateDocument);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task DeleteCandidate(Guid id)
        {
            await candidatesService.DeleteCandidate(id);
        }
    }
}
