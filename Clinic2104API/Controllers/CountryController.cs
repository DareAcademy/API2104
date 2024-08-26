using Clinic2104API.Model;
using Clinic2104API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clinic2104API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        ICountryService countryService;
        public CountryController(ICountryService _countryService)
        {
            countryService = _countryService;
        }

        [HttpPost]
        public void SaveCountry(CountryDTO countryDTO)
        {
            countryService.Insert(countryDTO);

        }

        [HttpGet]
        public List<CountryDTO> CountryList()
        {
            List<CountryDTO> countries = countryService.LoadAll();

            return countries;
        }

        [HttpDelete]
        public void DeleteCountry(int Id)
        {
            countryService.Delete(Id);
        }

    }
}
