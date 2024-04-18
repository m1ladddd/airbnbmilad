using AirBnbApi.Model;
using AirBnbApi.Model.DTO;

namespace AirBnbApi.Services
{
    public interface IReservationService
    {
        public Task<List<DateTime>> GetUnavailableDatesAsync(int locationId, CancellationToken cancellationToken);
        public Task<ReservationResponseDto> CreateReservationAsync(ReservationRequestDto reservationRequest, CancellationToken cancellationToken);
    }
}
