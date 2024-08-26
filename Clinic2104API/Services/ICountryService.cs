using Clinic2104API.Model;

namespace Clinic2104API.Services
{
    public interface ICountryService
    {
        void Insert(CountryDTO countryDTO);

        List<CountryDTO> LoadAll();

        void Delete(int Id);
    }
}
