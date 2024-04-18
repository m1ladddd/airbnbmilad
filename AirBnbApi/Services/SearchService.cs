using AirBnbApi.Model;
using AirBnbApi.Model.DTO;
using AirBnbApi.Repositories;

namespace AirBnbApi.Services
{
    public class SearchService : ISearchService
    {
        private readonly IAirBnbRepository _airbnbRepository;
        public SearchService(IAirBnbRepository airbnbRepository)
        {
            _airbnbRepository = airbnbRepository;
        }

        // Customer
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _airbnbRepository.GetAllCustomers();
        }
        public async Task<IEnumerable<Customer>> GetAllCustomersAsync(CancellationToken cancellationToken)
        {
            return await _airbnbRepository.GetAllCustomersAsync(cancellationToken);
        }
        public Customer GetCustomerById(int id)
        {
            return _airbnbRepository.GetCustomerById(id);
        }
        public async Task<Customer> GetCustomerByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _airbnbRepository.GetCustomerByIdAsync(id, cancellationToken);
        }
        // Image
        public IEnumerable<Image> GetAllImages()
        {
            return _airbnbRepository.GetAllImages();
        }
        public async Task<IEnumerable<Image>> GetAllImagesAsync(CancellationToken cancellationToken)
        {
            return await _airbnbRepository.GetAllImagesAsync(cancellationToken);
        }

        // Landlord
        public IEnumerable<Landlord> GetAllLandlords()
        {
            return _airbnbRepository.GetAllLandlords();
        }
        public async Task<IEnumerable<Landlord>> GetAllLandlordsAsync(CancellationToken cancellationToken)
        {
            return await _airbnbRepository.GetAllLandlordsAsync(cancellationToken);
        }
        public Landlord GetLandlordById(int id)
        {
            return _airbnbRepository.GetLandlordById(id);
        }
        public async Task<Landlord> GetLandlordByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _airbnbRepository.GetLandlordByIdAsync(id, cancellationToken);
        }
        public IEnumerable<Location> GetAllLocations(int landlordId)
        {
            return _airbnbRepository.GetAllLocations(landlordId);
        }
        public async Task<IEnumerable<Location>> GetAllLocationsAsync(int landlordId, CancellationToken cancellationToken)
        {
            return await _airbnbRepository.GetAllLocationsAsync(landlordId, cancellationToken);
        }

        // Location
        public IEnumerable<Location> GetAllLocations()
        {
            return _airbnbRepository.GetAllLocations();
        }
        public async Task<IEnumerable<Location>> GetAllLocationsAsync(CancellationToken cancellationToken)
        {
            return await _airbnbRepository.GetAllLocationsAsync(cancellationToken);
        }
        public IEnumerable<Location> GetLocations()
        {
            return _airbnbRepository.GetLocations();
        }
        public async Task<IEnumerable<Location>> GetLocationsAsync(CancellationToken cancellationToken)
        {
            return await _airbnbRepository.GetLocationsAsync(cancellationToken);
        }
        public Location GetLocationById(int id)
        {
            return _airbnbRepository.GetLocationById(id);
        }
        public async Task<Location> GetLocationByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _airbnbRepository.GetLocationByIdAsync(id, cancellationToken);
        }

        // Reservation
        public IEnumerable<Reservation> GetAllReservations()
        {
            return _airbnbRepository.GetAllReservations();
        }
        public async Task<IEnumerable<Reservation>> GetAllReservationsAsync(CancellationToken cancellationToken)
        {
            return await _airbnbRepository.GetAllReservationsAsync(cancellationToken);
        }

        // Search Locations
        public async Task<IEnumerable<Location>> SearchLocationsAsync(SearchRequestDto searchRequestDto, CancellationToken cancellationToken)
        {
            return await _airbnbRepository.SearchLocationsAsync(searchRequestDto, cancellationToken);
        }
        public async Task<int> GetMaxPriceAsync(CancellationToken cancellationToken)
        {
            return await _airbnbRepository.GetMaxPriceAsync(cancellationToken);
        }
        public async Task<Location> GetLocationDetailsAsync(int id, CancellationToken cancellationToken)
        {
            return await _airbnbRepository.GetLocationDetailsAsync(id, cancellationToken);
        }
    }
}
