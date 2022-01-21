using Microsoft.AspNetCore.Mvc;
using Bruhunter.Shared.Documents;
using Bruhunter.Application;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace Bruhunter.Api.Controllers
{
    [ApiController]
    [Route("api/vacancies")]
    public class VacanciesController : ControllerBase
    {
        private readonly VacanciesService vacanciesService;

        public VacanciesController(VacanciesService vacanciesService)
        {
            this.vacanciesService = vacanciesService;
        }

        [HttpGet]
        [Route("query")]
        public async Task<IEnumerable<VacancyDocument>> GetAllVacancies()
        {
            return await vacanciesService.GetAllVacancies();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<VacancyDocument> GetVacancy(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task CreateVacancy(VacancyDocument candidateDocument)
        {
            await vacanciesService.AddVacancy(candidateDocument);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task ChangeVacancy(VacancyDocument candidateDocument)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task DeleteVacancy(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
