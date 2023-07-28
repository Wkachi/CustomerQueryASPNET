using Microsoft.AspNetCore.Mvc;

namespace WebApplication1Customer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
         Customer customer = new Customer() ;
        [HttpGet(Name = "GetCustomer")]
            public IEnumerable<Customer> Get()
            {
            yield return customer;
        }

    };

      

    //    [HttpGet(Name = "GetCustomer")]
    //    public IEnumerable<Customer> Get()
    //    {
    //        return Enumerable.Range(1, 5).Select(index => new Customer
          
    //    }
    //}
}