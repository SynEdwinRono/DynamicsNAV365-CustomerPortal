﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicsNAV365_CustomerPortal.Controllers
{
	public class HomeController : Controller
	{
		#region Home Page
		public ActionResult Index()
		{
			return View();
		}
		#endregion
	}
}