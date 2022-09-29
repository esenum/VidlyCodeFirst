using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Caching;
using System.Web.Mvc;
using VidlyCF.Models;
using VidlyCF.ViewModels;

namespace VidlyCF.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
           _context.Dispose();
        }
        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                Customer = new Customer(),
                MembershipTypes = membershipTypes,
            };
            return View("CustomerForm",viewModel);
        }

        [HttpPost] //This attr. allows us to control this action with "post" instead of "get".
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer) 
        {
            if(!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes=_context.MembershipTypes.ToList(),
                };


                return View("CustomerForm",viewModel);

            }

            if(customer.Id==0)
               _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id); //to update an entity need to get it from DB first. Used single instead of SingleOrDefault.So if the given customer is not found(get throw an exception)
                customerInDb.Name = customer.Name;
                customerInDb.Birthdate = customer.Birthdate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;

            }

            _context.SaveChanges();

            return RedirectToAction("Index","Customers");
        }
        public ViewResult Index()
        {
            if(MemoryCache.Default["Genres"]==null)
            {
                MemoryCache.Default["Genres"] = _context.Genres.ToList();
            }

            var genres = MemoryCache.Default["Genres"] as IEnumerable<Genre>;
            return View();
        }

        public ActionResult Details(int id)
        {
            //var customer = _context.Customers.SingleOrDefault(c => c.Id == id);//for adding birthDate,commented out here and declare udnerline code.
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if(customer == null)            
               return HttpNotFound();  //gives standart 404 error.

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm",viewModel); //pass viewModel to new View.
        }

    }
}