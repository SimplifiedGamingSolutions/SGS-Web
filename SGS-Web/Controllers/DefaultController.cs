using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using System.Web.Mvc;
using SSQLib;

namespace SGS_Web.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ark()
        {
            return View();
        }

        public ActionResult Minecraft()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Simplified Gaming Solutions started in Utah by a few gamers who wanted to share their love for gaming with the world.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Here at Simplifed gaming solutions we want to make gamming easy to enjoy. If you have experienced any problems or have any concerns please feel free to call or Email us.";

            return View();
        }

        public ActionResult Buy()
        {
            ViewBag.Message = "Start having fun with the click of a button!";

            return View();
        }

        public ActionResult News()
        {
            ViewBag.Message = "Whats new:";

            return View();
        }


        public ActionResult Downloads()
        {
            ViewBag.Message = "Downloads";

            return View();
        }

        public ActionResult MinecraftProductInfo()
        {
            return View();
        }

        public string ServerStatus(string address, int port)
        {
            /*TcpClient tcpClient = new TcpClient();

            try
            {
                tcpClient.Connect(address, port);
                return true;
            }
            catch (Exception)
            {
                return false;
            }*/
            SSQL query = new SSQL();
            ServerInfo serverInformation = query.Server(address, port);
            string count = serverInformation.PlayerCount;
            return count;
        }
    }
}