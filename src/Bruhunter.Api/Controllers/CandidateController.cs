using Microsoft.AspNetCore.Mvc;
using Bruhunter.Shared;
using Bruhunter.Shared.Documents;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace Bruhunter.Api.Controllers
{
    [ApiController]
    [Route("api/candidate")]
    public class CandidateController : ControllerBase
    {

        [HttpPost]
        [Route("createCandidate")]
        public void CreateCandidate()
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{Guidid}")]
        public void DeleteCandidate(int GuidId)
        {
            throw new NotImplementedException();
        }


        [HttpGet("{Guidid}")]
        public IEnumerable<CandidateDocument> GetCandidate(int Guidid)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{Guidid}")]
        public void ChangeCandidate(int GuidId)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("all")]
        public IEnumerable<CandidateDocument> allCandidates()
        {
            throw new NotImplementedException();
        }
    }
}
