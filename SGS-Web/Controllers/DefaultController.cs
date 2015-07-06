using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using System.Web.Mvc;
using SSQLib;
using System.Net;
using SGS_Web.Minecraft;

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

        public ActionResult Products()
        {
            ViewBag.Message = "Start having fun with the click of a button!";

            return View();
        }

        public ActionResult Error()
        {
            ViewBag.Message = "Error";

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

        public ServerInfo getSteamServerInfo(string address, int port)
        {
            SSQL query = new SSQL();
            try
            {

                ServerInfo serverInformation = query.Server(address, port);
                return serverInformation;
            }
            catch
            {
                //server not found
                return null;
            }
        }

        public Minecraft.MinecraftServerInfo getMinecraftServerInfo(string address, int port)
        {
            try
            {
                return MinecraftServerInfo.GetServerInformation(new IPEndPoint(Dns.GetHostAddresses(address)[0], port));
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}