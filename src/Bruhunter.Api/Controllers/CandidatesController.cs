using Microsoft.AspNetCore.Mvc;
using Bruhunter.Shared;
using Bruhunter.Shared.Documents;
using Bruhunter.Application;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

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
        public IEnumerable<CandidateDocument> GetAllCandidates()
        {
            return candidatesService.GetAllCandidates();
        }

        [HttpGet]
        [Route("{id}")]
        public CandidateDocument GetCandidate(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("{id}")]
        public void ChangeCandidate(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public void CreateCandidate(CandidateDocument candidateDocument)
        {
            candidatesService.AddCandidate(candidateDocument);
        }

        [HttpDelete]
        [Route("{id}")]
        public void DeleteCandidate(Guid id)
        {
            candidatesService.DeleteCandidate(id);
        }
    }
}
