using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

//References to Geometry
using RappiChallenge.Geometry;
using RappiChallenge.Geometry.GCube;

namespace Website.Controllers
{
    public class CubeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetValues()
        {
            //Get Cube 
            IGCube cube = GeometryFactory.GetCube();

            return Json( cube.GetValues(), JsonRequestBehavior.AllowGet );
        }

        public ActionResult GetDimensions()
        {
            //Get Cube 
            IGCube cube = GeometryFactory.GetCube();

            return Json(cube.GetDimensions(), JsonRequestBehavior.AllowGet);
        }
    }
}
