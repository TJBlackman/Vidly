using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
	public class CustomersController : Controller
	{
		[Route("customers/")]
		public ActionResult Index()
		{
			var customers = new List<Customer>()
			{
				new Customer() { Name = "Trevor", Id = 1 },
				new Customer() { Name = "Declan", Id = 2 },
				new Customer() { Name = "Elcie", Id = 3 }
			};

			return View(customers);
		}
		[Route("customers/details/{Id}")]
		public ActionResult Details(int Id)
		{
			var customers = new List<Customer>()
			{
				new Customer() { Name = "Trevor", Id = 1 },
				new Customer() { Name = "Declan", Id = 2 },
				new Customer() { Name = "Elcie", Id = 3 }
			};
			var customer = customers.Find(i => i.Id == Id); 

			return View(customer);
		}
	}
}