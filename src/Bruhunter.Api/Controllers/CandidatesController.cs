using Microsoft.AspNetCore.Mvc;
using Bruhunter.Shared;
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
        public IEnumerable<CandidateDocument> GetAllCandidates()
        {
            throw new NotImplementedException();
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
        public void CreateCandidate()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("{id}")]
        public void DeleteCandidate(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
