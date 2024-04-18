using AirBnbApi.Data;
using AirBnbApi.Model;
using AirBnbApi.Model.DTO;
using Microsoft.EntityFrameworkCore;

namespace AirBnbApi.Repositories
{
    public class AirBnbRepository : IAirBnbRepository
    {
        private readonly AirBnbDbContext _context;
        public AirBnbRepository(AirBnbDbContext context)
        {
            _context = context;
        }

        // Customer
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _context.Customer.ToList();
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync(CancellationToken cancellationToken)
        {
            return await _context.Customer.ToListAsync(cancellationToken);
        }

        public Customer GetCustomerById(int id)
        {
            return _context.Customer.Find(id);
        }

        public async Task<Customer> GetCustomerByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Customer.FindAsync(new object[] { id }, cancellationToken);
        }

        public async Task<Customer> GetOrCreateCustomerAsync(string email, string firstName, string lastName, CancellationToken cancellationToken)
        {
            var customer = await _context.Customer.FirstOrDefaultAsync(c => c.Email == email, cancellationToken);

            if (customer == null)
            {
                customer = new Customer
                {
                    Email = email,
                    FirstName = firstName,
                    LastName = lastName
                };

                _context.Customer.Add(customer);
                await _context.SaveChangesAsync(cancellationToken);
            }

            return customer;
        }

        // Image
        public IEnumerable<Image> GetAllImages()
        {
            return _context.Image.ToList();
        }

        public async Task<IEnumerable<Image>> GetAllImagesAsync(CancellationToken cancellationToken)
        {
            return await _context.Image.ToListAsync(cancellationToken);
        }

        // Landlord
        public IEnumerable<Landlord> GetAllLandlords()
        {
            return _context.Landlord.ToList();
        }

        public async Task<IEnumerable<Landlord>> GetAllLandlordsAsync(CancellationToken cancellationToken)
        {
            return await _context.Landlord.ToListAsync(cancellationToken);
        }

        public Landlord GetLandlordById(int id)
        {
            return _context.Landlord.Find(id);
        }

        public async Task<Landlord> GetLandlordByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Landlord.FindAsync(new object[] { id }, cancellationToken);
        }

        public IEnumerable<Location> GetAllLocations(int landlordId)
        {
            return _context.Location.Where(l => l.LandlordId == landlordId).ToList();
        }

        public async Task<IEnumerable<Location>> GetAllLocationsAsync(int landlordId, CancellationToken cancellationToken)
        {
            return await _context.Location.Where(l => l.LandlordId == landlordId).ToListAsync(cancellationToken);
        }

        // Location
        public IEnumerable<Location> GetAllLocations()
        {
            return _context.Location.ToList();
        }

        public async Task<IEnumerable<Location>> GetAllLocationsAsync(CancellationToken cancellationToken)
        {
            return await _context.Location.ToListAsync(cancellationToken);
        }

        public IEnumerable<Location> GetLocations()
        {
            return _context.Location.Include(l => l.Images).Include(l => l.Landlord).ThenInclude(l => l.Avatar).ToList();
        }

        public async Task<IEnumerable<Location>> GetLocationsAsync(CancellationToken cancellationToken)
        {
            return await _context.Location.Include(l => l.Images).Include(l => l.Landlord).ThenInclude(l => l.Avatar).ToListAsync(cancellationToken);
        }

        public Location GetLocationById(int id)
        {
            return _context.Location.Find(id);
        }

        public async Task<Location> GetLocationByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Location.FindAsync(new object[] { id }, cancellationToken);
        }

        // Reservation
        public IEnumerable<Reservation> GetAllReservations()
        {
            return _context.Reservation.ToList();
        }

        public async Task<IEnumerable<Reservation>> GetAllReservationsAsync(CancellationToken cancellationToken)
        {
            return await _context.Reservation.ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<Reservation>> GetReservationsByLocationIdAsync(int locationId, CancellationToken cancellationToken)
        {
            return await _context.Reservation
                .Where(r => r.LocationId == locationId)
                .ToListAsync(cancellationToken);
        }
        
        public async Task<Reservation> AddReservationAsync(Reservation reservation, CancellationToken cancellationToken)
        {
            _context.Reservation.Add(reservation);
            await _context.SaveChangesAsync(cancellationToken);
            return reservation;
        }

        // Search Locations
        public async Task<IEnumerable<Location>> SearchLocationsAsync(SearchRequestDto searchRequestDto, CancellationToken cancellationToken)
        {
            var query = _context.Location.AsQueryable();

            if (searchRequestDto.Features.HasValue)
            {
                _context.Location.Include(l => l.Features);
                query = query.Where(l => l.Features == searchRequestDto.Features.Value);
            }

            if (searchRequestDto.Type.HasValue)
            {
                query = query.Where(l => l.Type == searchRequestDto.Type.Value);
            }

            if (searchRequestDto.Rooms.HasValue)
            {
                query = query.Where(l => l.Rooms >= searchRequestDto.Rooms.Value);
            }

            if (searchRequestDto.MinPrice.HasValue)
            {
                query = query.Where(l => l.PricePerDay >= searchRequestDto.MinPrice.Value);
            }

            if (searchRequestDto.MaxPrice.HasValue)
            {
                query = query.Where(l => l.PricePerDay <= searchRequestDto.MaxPrice.Value);
            }

            return await query.Include(l => l.Images).Include(l => l.Landlord).ThenInclude(l => l.Avatar).ToListAsync(cancellationToken);
        }
        public async Task<int> GetMaxPriceAsync(CancellationToken cancellationToken)
        {
            return (int)await _context.Location.MaxAsync(location => location.PricePerDay, cancellationToken);
        }
        public async Task<Location> GetLocationDetailsAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Location.Include(l => l.Images).Include(l => l.Landlord).ThenInclude(l => l.Avatar).FirstOrDefaultAsync(l => l.Id == id, cancellationToken);
        }
    }
}
