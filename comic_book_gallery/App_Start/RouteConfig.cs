﻿using System.Web.Mvc;
using System.Web.Routing;

namespace comic_book_gallery
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "ComicBook", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}

