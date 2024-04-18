using AirBnbApi.Model;
using AirBnbApi.Model.DTO;
using AirBnbApi.Repositories;

namespace AirBnbApi.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IAirBnbRepository _airbnbRepository;
        public ReservationService(IAirBnbRepository airbnbRepository)
        {
            _airbnbRepository = airbnbRepository;
        }

        public async Task<ReservationResponseDto> CreateReservationAsync(ReservationRequestDto reservationRequest, CancellationToken cancellationToken)
        {
            var location = await _airbnbRepository.GetLocationByIdAsync(reservationRequest.LocationId, cancellationToken);
            var customer = await _airbnbRepository.GetOrCreateCustomerAsync(reservationRequest.Email, reservationRequest.FirstName, reservationRequest.LastName, cancellationToken);

            var reservation = new Reservation
            {
                StartTime = reservationRequest.StartDate,
                EndTime = reservationRequest.EndDate,
                LocationId = reservationRequest.LocationId,
                CustomerId = customer.Id,
                Discount = reservationRequest.Discount ?? 0
            };

            await _airbnbRepository.AddReservationAsync(reservation, cancellationToken);

            return new ReservationResponseDto
            {
                LocationName = location.Title,
                CustomerName = $"{customer.FirstName} {customer.LastName}",
                Price = (float)(location.PricePerDay * (reservation.EndTime - reservation.StartTime).TotalDays),
                Discount = reservation.Discount
            };
        }
        public async Task<List<DateTime>> GetUnavailableDatesAsync(int locationId, CancellationToken cancellationToken)
        {
            var reservations = await _airbnbRepository.GetReservationsByLocationIdAsync(locationId, cancellationToken);

            var unavailableDates = new List<DateTime>();
            foreach (var r in reservations)
            {
                for (var date = r.StartTime; date < r.EndTime; date = date.AddDays(1))
                {
                    unavailableDates.Add(date);
                }
            }
            return unavailableDates;
        }
    }
}
