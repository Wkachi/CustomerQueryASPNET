using Microsoft.AspNetCore.Mvc;
using WebApplication1Customer.Controllers;

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

    

}

namespace WebApplication1Customer.Controllers
{
    //public IEnumerable<Customer> GetCustomer()
    //{
    //    return Enumerable.Range(1, 5).Select(index => new CustomerController
    //    {

    //        Date = DateTime.Now.AddDays(index),
    //        FirstName = Random.Shared.Next(-20, 55),
    //        Summary = Summaries[Random.Shared.Next(Summaries.Length)];
    //    })
    //    .ToArray();
    //}
 

        [HttpGet(Name = "GetCustomer")]
        public IEnumerable<Customer> GetCustomer()
        {

            IEnumerable<Customer> customer = null;

            Customer customers = new Customer();
            {
                return Enumerable.Range(1, 5).Select(index => new CustomerController
                {
                    FirstName = "Kachi",
                    Surname = "Wachikwu",


                }).ToArray();



            }

        }
    
}

namespace WebApplication1Customer.Controllers
{
    [HttpGet(Name = "PostCustomer")]
    public IEnumerable<Customer> PostCustomer()
    {

        IEnumerable<Customer> customer = null;

        Customer customers = new Customer();
        {
            return Enumerable.Range(1, 5).Select(index => new CustomerController
            {
                FirstName = "Kachi",
                Surname = "Wachikwu",


            }).ToArray();



        }

    }
}

namespace WebApplication1Customer.Controllers
{
    [HttpGet(Name = "PutCustomer")]
    public IEnumerable<Customer> PutCustomer()
    {

        IEnumerable<Customer> customer = null;

        Customer customers = new Customer();
        {
            return Enumerable.Range(1, 5).Select(index => new CustomerController
            {
                FirstName = "James",
                Surname = "Obinna",


            }).ToArray();



        }

    }
}

namespace WebApplication1Customer.Controllers
{
  
    [HttpGet(Name = "DeleteCustomer")]
    public IEnumerable<Customer> DeleteCustomer(string firstname,string surname, Customer customer)
    {

        IEnumerable<Customer> customer = null;

        Customer customers = new Customer();
        {
            return Enumerable.Range(1, 5).Select(index => new CustomerController
            {
                FirstName = firstname,
                Surname = surname,
                
              


        }).ToArray();


       
    }

    }
}