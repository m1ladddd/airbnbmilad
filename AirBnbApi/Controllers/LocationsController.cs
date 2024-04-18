using AirBnbApi.Model;
using Microsoft.AspNetCore.Mvc;
using AirBnbApi.Services;
using AutoMapper;
using AirBnbApi.Model.DTO;
using Asp.Versioning;

namespace AirBnbApi.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ISearchService _searchService;
        private readonly IReservationService _reservationService;
        private readonly IMapper _mapper;

        public LocationsController(ISearchService searchService, IReservationService reservationService, IMapper mapper)
        {
            _searchService = searchService;
            _reservationService = reservationService;
            _mapper = mapper;
        }

        // GET: api/Locations
        /// <response code="200">Locaties uit de database</response>
        /// <response code="404">Er zijn geen locaties in de Database</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<LocationDto>>> GetLocationsAsync(CancellationToken cancellationToken)
        {
            var locations = await _searchService.GetLocationsAsync(cancellationToken);
            if(locations == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<List<LocationDto>>(locations));
        }

        // GET: api/Locations/GetAll
        /// <response code="200">Locaties uit de database</response>
        /// <response code="404">Er zijn geen locaties in de Database</response>
        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Location>>> GetAllLocationsAsync(CancellationToken cancellationToken)
        {
            var locations = await _searchService.GetAllLocationsAsync(cancellationToken);
            if(locations == null)
            {
                return NotFound();
            }
            return Ok(locations);
        }

        // GET: api/Locations/5
        /// <param name="id">Dit is de database ID van de locatie</param>
        /// <response code="200">Een locatie uit de database</response>
        /// <response code="404">De locatie is onbekend in de database</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Location>> GetLocationAsync(int id, CancellationToken cancellationToken)
        {
            var location = await _searchService.GetLocationByIdAsync(id, cancellationToken);

            if (location == null)
            {
                return NotFound();
            }

            return Ok(location);
        }
        // POST: api/Locations/Search
        /// <response code="200">Locaties uit de database</response>
        /// <response code="404">Er zijn geen locaties in de Database met deze zoektermen</response>
        [HttpPost("Search")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<AirBnbApi.Model.DTO.v2.LocationDto>>> Search([FromBody] SearchRequestDto searchRequestDto, CancellationToken cancellationToken)
        {
            var locations = await _searchService.SearchLocationsAsync(searchRequestDto, cancellationToken);
            if (locations == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<List<AirBnbApi.Model.DTO.v2.LocationDto>>(locations));
        }

        // GET: api/Locations/GetMaxPrice
        /// <response code="200">De hoogste prijs</response>
        [HttpGet("GetMaxPrice")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<MaxPriceResponseDto>> GetMaxPrice(CancellationToken cancellationToken)
        {
            int maxPrice = await _searchService.GetMaxPriceAsync(cancellationToken);
            return Ok(new MaxPriceResponseDto { Price = maxPrice });
        }

        // GET: api/Locations/GetDetails/{id}
        /// <response code="200">Details van de locatie</response>
        /// <response code="404">Locatie bestaat niet</response>
        [HttpGet("GetDetails/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<LocationDetailsDto>> GetDetails(int id, CancellationToken cancellationToken)
        {
            var locationDetails = await _searchService.GetLocationDetailsAsync(id, cancellationToken);

            if (locationDetails == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<LocationDetailsDto>(locationDetails));
        }

        // GET: api/Locations/UnAvailableDates/{id}
        /// <response code="200">Datums waar de locatie niet beschikbaar is</response>
        /// <response code="404">Locatie bestaat niet</response>
        [HttpGet("UnAvailableDates/{locationId}")]
        public async Task<ActionResult<UnavailableDatesResponse>> GetUnavailableDates(int locationId, CancellationToken cancellationToken)
        {
            var unavailableDates = await _reservationService.GetUnavailableDatesAsync(locationId, cancellationToken);
            if (unavailableDates == null)
            {
                return NotFound();
            }

            return new UnavailableDatesResponse { UnavailableDates = unavailableDates.ToList() };
        }
    }
}
