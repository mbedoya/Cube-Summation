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
using RappiChallenge.TO;

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

        public ActionResult UpdatePoint(PointTO point)
        {
            //Get Cube
            IGCube cube = GeometryFactory.GetCube();

            return Json(new { success = cube.Update(point) }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create(int dimensions)
        {
            //Get Cube
            IGCube cube = GeometryFactory.GetCube();

            return Json(new { success = cube.Create(dimensions) }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SumRegion(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            //Get Cube
            IGCube cube = GeometryFactory.GetCube();

            PointTO point1 = new PointTO() { X = x1, Y = y1, Z = z1 };
            PointTO point2 = new PointTO() { X = x2, Y = y2, Z = z2 };

            return Json(new { sum = cube.SumRegion(point1, point2) }, JsonRequestBehavior.AllowGet);
        }
    }
}
