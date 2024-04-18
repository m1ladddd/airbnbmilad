using AirBnbApi.Model;
using AirBnbApi.Model.DTO;

namespace AirBnbApi.Repositories
{
    public interface IAirBnbRepository
    {
        // Customers
        IEnumerable<Customer> GetAllCustomers();
        Task<IEnumerable<Customer>> GetAllCustomersAsync(CancellationToken cancellationToken);
        Customer GetCustomerById(int id);
        Task<Customer> GetCustomerByIdAsync(int id, CancellationToken cancellationToken);
        Task<Customer> GetOrCreateCustomerAsync(string email, string firstName, string lastName, CancellationToken cancellationToken);

        // Images
        IEnumerable<Image> GetAllImages();
        Task<IEnumerable<Image>> GetAllImagesAsync(CancellationToken cancellationToken);

        // Landlords
        IEnumerable<Landlord> GetAllLandlords();
        Task<IEnumerable<Landlord>> GetAllLandlordsAsync(CancellationToken cancellationToken);
        Landlord GetLandlordById(int id);
        Task<Landlord> GetLandlordByIdAsync(int id, CancellationToken cancellationToken);

        // Locations
        IEnumerable<Location> GetAllLocations(int landlordId);
        Task<IEnumerable<Location>> GetAllLocationsAsync(int landlordId, CancellationToken cancellationToken);
        IEnumerable<Location> GetAllLocations();
        Task<IEnumerable<Location>> GetAllLocationsAsync(CancellationToken cancellationToken);
        IEnumerable<Location> GetLocations();
        Task<IEnumerable<Location>> GetLocationsAsync(CancellationToken cancellationToken);
        Location GetLocationById(int id);
        Task<Location> GetLocationByIdAsync(int id, CancellationToken cancellationToken);

        // Reservations
        IEnumerable<Reservation> GetAllReservations();
        Task<IEnumerable<Reservation>> GetAllReservationsAsync(CancellationToken cancellationToken);
        Task<IEnumerable<Reservation>> GetReservationsByLocationIdAsync(int locationId, CancellationToken cancellationToken);
        Task<Reservation> AddReservationAsync(Reservation reservation, CancellationToken cancellationToken);

        // Search Locations
        Task<IEnumerable<Location>> SearchLocationsAsync(SearchRequestDto searchRequestDto, CancellationToken cancellationToken);
        Task<int> GetMaxPriceAsync(CancellationToken cancellationToken);
        Task<Location> GetLocationDetailsAsync(int id, CancellationToken cancellationToken);
    }
}
