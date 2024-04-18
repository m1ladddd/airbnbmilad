using AirBnbApi.Model;
using Microsoft.AspNetCore.Mvc;
using AirBnbApi.Services;

namespace AirBnbApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandlordsController : ControllerBase
    {
        private readonly ISearchService _searchService;

        public LandlordsController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        // GET: api/Landlords
        /// <response code="200">Landlords uit de database</response>
        /// <response code="404">Er zijn geen landlords in de Database</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Landlord>>> GetLandlordsAsync(CancellationToken cancellationToken)
        {
            var landlords = await _searchService.GetAllLandlordsAsync(cancellationToken);
            if (landlords == null)
            {
                return NotFound();
            }
            return Ok(landlords);
        }

        // GET: api/Landlords/5
        /// <param name="id">Dit is de database ID van de landlord</param>
        /// <response code="200">Een landlord uit de database</response>
        /// <response code="404">De landlord is onbekend in de database</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Landlord>>> GetLandlordAsync(int id, CancellationToken cancellationToken)
        {
            var landlord = await _searchService.GetLandlordByIdAsync(id, cancellationToken);
            
            if (landlord == null)
            {
                return NotFound();
            }

            return Ok(landlord);
        }

        // GET: api/Landlords/5/Locations
        /// <param name="id">Dit is de database ID van de landlord</param>
        /// <response code="200">Alle locations van de landlord</response>
        /// <response code="404">De landlord heeft geen locations of de landlord bestaat niet</response>
        [HttpGet("{id}/Locations")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Location>>> GetAllLocationsAsync(int id, CancellationToken cancellationToken)
        {
            var location = await _searchService.GetAllLocationsAsync(id, cancellationToken);

            if (location == null)
            {
                return NotFound();
            }

            return Ok(location);
        }
        
    }
}
