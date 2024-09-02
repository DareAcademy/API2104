using Clinic2104API.Model;
using Clinic2104API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clinic2104API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Admin,Doctor")]
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
        [Route("CountryList")]
        public List<CountryDTO> CountryList()
        {
            List<CountryDTO> countries = countryService.LoadAll();
            return countries;
        }


        [HttpGet]
        [Route("LoadByName")]
        public CountryDTO LoadByName(string name)
        {
            CountryDTO countryDto = countryService.LoadByName(name);
            return countryDto;
        }

        [HttpDelete]
        public void DeleteCountry(int Id)
        {
            countryService.Delete(Id);
        }

    }
}
