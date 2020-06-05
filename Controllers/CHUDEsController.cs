using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using shophoatuoi.Models;

namespace shophoatuoi.Controllers
{
    public class CHUDEsController : Controller
    {
        private acomptec_shophoaContext db = new acomptec_shophoaContext();

        // GET: CHUDEs
        public ActionResult Index()
        {
            return View(db.Chude.ToList());
        }
    }
}
