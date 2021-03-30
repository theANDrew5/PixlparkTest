using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApiClient.Models;

namespace ApiClient.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientModel _clientModel;
        private readonly string _url = "http://api.pixlpark.com";

        public ClientController()
        {
            _clientModel = new ClientModel();
        }
        //GET: Client
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(string public_key, string private_key)
        {
            var tokens = _clientModel.LogIn(_url, public_key, private_key);
            return RedirectToAction("Orders",tokens);
        }

        public ActionResult Orders (Tokens tokens)
        {
            ViewBag.Orders = _clientModel.GetOrders(_url,tokens);
            return View();
        }


    }
}