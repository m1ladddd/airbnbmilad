using AirBnbApi.Model;
using Microsoft.AspNetCore.Mvc;
using AirBnbApi.Services;

namespace AirBnbApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ISearchService _searchService;

        public CustomersController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        // GET: api/Customers
        /// <response code="200">Customers uit de database</response>
        /// <response code="404">Er zijn geen customers in de Database</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomersAsync(CancellationToken cancellationToken)
        {
            var customers = await _searchService.GetAllCustomersAsync(cancellationToken);
            if (customers == null)
            {
                return NotFound();
            }
            return Ok(customers);
        }

        // GET: api/Customers/5
        /// <param name="id">Dit is de database ID van de customer</param>
        /// <response code="200">Een customer uit de database</response>
        /// <response code="404">De customer is onbekend in de database</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomerAsync(int id, CancellationToken cancellationToken)
        {
            var customer = await _searchService.GetCustomerByIdAsync(id, cancellationToken);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

    }
}
