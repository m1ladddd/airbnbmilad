using AirBnbApi.Model;
using AirBnbApi.Model.DTO;
using Microsoft.EntityFrameworkCore;

namespace AirBnbApi.Repositories
{
    public class AirBnbRepositoryTests : IAirBnbRepository
    {
        // Customer
        public IEnumerable<Customer> GetAllCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Email = "alice.smith@gmail.com", FirstName = "Alice", LastName = "Smith" },
                new Customer { Id = 2, Email = "bob.jones@outlook.com", FirstName= "Bob", LastName = "Jones" }
            };
        }
        public Task<IEnumerable<Customer>> GetAllCustomersAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        public Customer GetCustomerById(int id)
        {
            if (id == 1)
            {
                return new Customer
                {
                    Id = 1,
                    Email = "alice.smith@gmail.com",
                    FirstName = "Alice",
                    LastName = "Smith"
                };
            }
            else return null;
        }
        public Task<Customer> GetCustomerByIdAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        // Image
        public IEnumerable<Image> GetAllImages()
        {
            return new List<Image>
            {
                new Image { Id = 1, Url = "https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png", IsCover = true },
                new Image { Id = 2, Url = "https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png", IsCover = false }
            };
        }
        public Task<IEnumerable<Image>> GetAllImagesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        // Landlord
        public IEnumerable<Landlord> GetAllLandlords()
        {
            return new List<Landlord>
            {
                new Landlord {Id = 1, Age = 29, FirstName = "Elena", LastName = "Walters" },
                new Landlord {Id = 2, Age = 35, FirstName = "Marco", LastName = "Fischer" }
            };
        }
        public Task<IEnumerable<Landlord>> GetAllLandlordsAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        public Landlord GetLandlordById(int id)
        {
            return new Landlord { Id = 1, Age = 42, FirstName = "Elena", LastName = "Walters" };
        }
        public Task<Landlord> GetLandlordByIdAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Location> GetAllLocations(int landlordId)
        {
            return new List<Location>
            {
                new Location {Id = 1, Title = "Test Location"},
                new Location {Id = 2, Title = "Second Test Location"}
            };
        }
        public Task<IEnumerable<Location>> GetAllLocationsAsync(int landlordId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        // Location
        public IEnumerable<Location> GetAllLocations()
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Location>> GetAllLocationsAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Location> GetLocations()
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Location>> GetLocationsAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        public Location GetLocationById(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Location> GetLocationByIdAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        // Reservation
        public IEnumerable<Reservation> GetAllReservations()
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Reservation>> GetAllReservationsAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Location>> SearchLocationsAsync(SearchRequestDto searchRequestDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetMaxPriceAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Location> GetLocationDetailsAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<Reservation>> GetReservationsByLocationIdAsync(int locationId)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetOrCreateCustomerAsync(string email, string firstName, string lastName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Reservation>> GetReservationsByLocationIdAsync(int locationId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Reservation> AddReservationAsync(Reservation reservation, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
