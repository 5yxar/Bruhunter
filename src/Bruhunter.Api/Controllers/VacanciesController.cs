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
        private readonly CandidatesService candidatesService;

        public VacanciesController(VacanciesService vacanciesService, CandidatesService candidatesService)
        {
            this.vacanciesService = vacanciesService;
            this.candidatesService = candidatesService;
        }

        [HttpGet]
        [Route("query")]
        public async Task<IEnumerable<VacancyDocument>> QueryVacancies([FromQuery] DateTime? minCloseDateTime)
        {
            return await vacanciesService.QueryVacancies(minCloseDateTime) ;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<VacancyDocument> GetVacancy(Guid id)
        {
            return await vacanciesService.GetVacancy(id);
        }

        [HttpPost]
        public async Task CreateVacancy(VacancyDocument vacancyDocument)
        {
            await vacanciesService.AddVacancy(vacancyDocument);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task ChangeVacancy(VacancyDocument vacancyDocument)
        {
            await vacanciesService.ChangeVacancy(vacancyDocument);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task DeleteVacancy(Guid id)
        {
            await vacanciesService.DeleteVacancy(id);
        }
    }
}
