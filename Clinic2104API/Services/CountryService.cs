using AutoMapper;
using Clinic2104API.data;
using Clinic2104API.Model;

namespace Clinic2104API.Services
{
    public class CountryService:ICountryService
    {
        ClinicContext context;
        IMapper mapper;
        public CountryService(ClinicContext _Context,
                               IMapper _mapper)
        {
            context = _Context;
            mapper = _mapper;
        }

        public void Insert(CountryDTO countryDTO)
        {
            Country newCountry = mapper.Map<Country>(countryDTO);
            context.countries.Add(newCountry);
            context.SaveChanges();
        }

        public List<CountryDTO> LoadAll()
        {
            List<Country> AllCountries = context.countries.ToList();
            List<CountryDTO> countries = new List<CountryDTO>();
           
            countries = mapper.Map<List<CountryDTO>>(AllCountries);
            return countries;
        }

        public void Delete(int Id)
        {
            Country country = context.countries.Find(Id);

            context.countries.Remove(country);
            context.SaveChanges();
        }

        public CountryDTO LoadByName(string name)
        {
            Country country = context.countries.Where(c => c.Name == name).FirstOrDefault();
            CountryDTO countryDTO = mapper.Map<CountryDTO>(country);
            return countryDTO;

        }

    }
}
