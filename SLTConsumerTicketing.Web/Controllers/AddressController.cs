using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Threading.Tasks;

using SLTConsumerTicketing.Web.Services;


namespace SLTConsumerTicketing.Web.Controllers
{
    public class AddressController : Controller
    {
        AddressService addressService = new AddressService();

        public AddressController()
        {
            addressService.ApiUrl = ConfigurationManager.AppSettings["APIUrl"].ToString();
        }

        // GET: Address
        public async Task<ActionResult> Index()
        {
            var addressList = await addressService.GetAllAddresses();
            return View(addressList);
        }

        public async Task<ActionResult> Details(int id)
        {
            var address = await addressService.GetAddress(id);
            return View(address);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Models.AddressViewMapper form)
        {
            var id = await addressService.PostAddress(form);
            if (id > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}