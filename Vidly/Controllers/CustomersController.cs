using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            var customers = new List<Customer>{
               new Customer{ Id= 1, Name = "Z�" },
               new Customer{ Id= 2,  Name = "Arnaldo" },
            };

            var viewModel = new CustomersViewModel{ Customers = customers };

            return View(viewModel);
        }
    }
}