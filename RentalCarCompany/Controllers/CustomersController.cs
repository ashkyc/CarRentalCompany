using RentalCarCompany.Models;
using RentalCarCompany.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalCarCompany.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

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
            var membershipTiers = _context.MembershipTiers.ToList();
            var viewModel = new CustomerFormViewModel
            {
                Customer = new Customer(),
                MembershipTiers = membershipTiers
            };
            return View("CustomerForm", viewModel);
        }

        //POST: Customers
        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTiers = _context.MembershipTiers.ToList()
                };
                return View("CustomerForm", viewModel);
            }

            if (customer.Id == 0)
            {
                customer.Age = DateTime.Today.Year - customer.Birthdate.Year;
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.FirstName = customer.FirstName;
                customerInDb.LastName = customer.LastName;
                customerInDb.Birthdate = customer.Birthdate;
                customerInDb.Age = DateTime.Today.Year - customer.Birthdate.Year;
                customerInDb.DriverLicense = customer.DriverLicense;
                customerInDb.MembershipTierId = customer.MembershipTierId;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }


        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }
    }
}