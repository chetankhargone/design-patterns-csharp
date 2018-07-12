using customer.model;
using customer.service.contract;
using System.Web.Mvc;

namespace customer.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Post(Customer customer)
        {
            _customerService.Create(customer);
            return View();
        }
    }
}