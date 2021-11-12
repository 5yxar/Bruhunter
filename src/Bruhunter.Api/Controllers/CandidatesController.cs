using Microsoft.AspNetCore.Mvc;
using Bruhunter.Shared;
using Bruhunter.Shared.Documents;
using Bruhunter.Application;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Net.Http;

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
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task ChangeCandidate(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task CreateCandidate(CandidateDocument candidateDocument)
        {
           await candidatesService.AddCandidate(candidateDocument);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task DeleteCandidate(Guid id)
        {
            await candidatesService.DeleteCandidate(id);
        }
    }
}
