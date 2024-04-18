using AirBnbApi.Model;
using AirBnbApi.Model.DTO;

namespace AirBnbApi.Services
{
    public interface ISearchService
    {
        public IEnumerable<Location> GetAllLocations();
        public Task<IEnumerable<Location>> GetAllLocationsAsync(CancellationToken cancellationToken);
        public IEnumerable<Location> GetLocations();
        public Task<IEnumerable<Location>> GetLocationsAsync(CancellationToken cancellationToken);
        public Location GetLocationById(int id);
        public Task<Location> GetLocationByIdAsync(int id, CancellationToken cancellationToken);
        public IEnumerable<Landlord> GetAllLandlords();
        public Task<IEnumerable<Landlord>> GetAllLandlordsAsync(CancellationToken cancellationToken);
        public Landlord GetLandlordById(int id);
        public Task<Landlord> GetLandlordByIdAsync(int id, CancellationToken cancellationToken);
        public IEnumerable<Location> GetAllLocations(int landlordId);
        public Task<IEnumerable<Location>> GetAllLocationsAsync(int landlordId, CancellationToken cancellationToken);
        public IEnumerable<Image> GetAllImages();
        public Task<IEnumerable<Image>> GetAllImagesAsync(CancellationToken cancellationToken);
        public IEnumerable<Customer> GetAllCustomers();
        public Task<IEnumerable<Customer>> GetAllCustomersAsync(CancellationToken cancellationToken);
        public Customer GetCustomerById(int id);
        public Task<Customer> GetCustomerByIdAsync(int id, CancellationToken cancellationToken);
        public IEnumerable<Reservation> GetAllReservations();
        public Task<IEnumerable<Reservation>> GetAllReservationsAsync(CancellationToken cancellationToken);
        public Task<IEnumerable<Location>> SearchLocationsAsync(SearchRequestDto searchRequestDto, CancellationToken cancellationToken);
        public Task<int> GetMaxPriceAsync(CancellationToken cancellationToken);
        public Task<Location> GetLocationDetailsAsync(int id, CancellationToken cancellationToken);
    }
}
