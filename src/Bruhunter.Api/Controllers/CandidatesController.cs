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

        public CandidatesController(CandidatesService candidatesService)
        {
            this.candidatesService = candidatesService;
        }

        [HttpGet]
        [Route("query")]
        public async Task<IEnumerable<CandidateDocument>> GetAllCandidates()
        {
            return await candidatesService.GetAllCandidates();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<CandidateDocument> GetCandidate(Guid id)
        {
            return await candidatesService.GetCandidate(id);
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
