using Microsoft.AspNetCore.SignalR;
using WebAPI.DAL.Entities;

namespace WebAPI.Domain.Interfaces
{
    public interface ICountryService
    {
        Task<IEnumerable<Country>> GetCountriesAsync(); //Una de las tantas firmas de un método!

        Task<Country> CreateCountryAsync(Country country);


        Task<Country> GetCountryByIdAsync(Guid id);

        Task<Country> EditCountryAsync(Country country);

        Task<Country> DeleteCountryAsync(Guid id);
    }
}
