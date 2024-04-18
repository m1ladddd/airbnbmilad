using AirBnbApi.Model;
using Microsoft.AspNetCore.Mvc;
using AirBnbApi.Services;
using AutoMapper;
using Asp.Versioning;
using LocationDto = AirBnbApi.Model.DTO.v2.LocationDto;

namespace AirBnbApi.Controllers.v2
{
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ISearchService _searchService;
        private readonly IMapper _mapper;

        public LocationsController(ISearchService searchService, IMapper mapper)
        {
            _searchService = searchService;
            _mapper = mapper;
        }

        // GET: api/Locations
        /// <response code="200">Locaties uit de database</response>
        /// <response code="404">Er zijn geen locaties in de Database</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<LocationDto>> GetLocations()
        {
            var locations = _searchService.GetLocations();
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
        public ActionResult<IEnumerable<Location>> GetAllLocations()
        {
            var locations = _searchService.GetAllLocations();
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
        public ActionResult<Location> GetLocation(int id)
        {
            var location = _searchService.GetLocationById(id);

            if (location == null)
            {
                return NotFound();
            }

            return Ok(location);
        }

    }
}
