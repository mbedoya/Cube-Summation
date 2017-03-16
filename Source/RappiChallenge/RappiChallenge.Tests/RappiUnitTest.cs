using Microsoft.VisualStudio.TestTools.UnitTesting;
using RappiChallenge.Geometry.GCube;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RappiChallenge.Tests
{
    [TestClass]
    public class RappiUnitTest
    {
        [TestMethod]
        public void Cube_CreateUpdateAndSumSuccessful()
        {
            IGCube cube = Geometry.GeometryFactory.GetCube();
            cube.Create(3);
            cube.Update(new RappiChallenge.TO.PointTO(){ X=1, Y=1, Z=1, Value=15});

            Assert.AreEqual(
                cube.SumRegion(
                    new RappiChallenge.TO.PointTO() { X = 1, Y = 1, Z = 1 }, 
                    new RappiChallenge.TO.PointTO() { X = 2, Y = 2, Z = 2 })
                , Convert.ToDouble(15));
        }

        [TestMethod]
        public void Cube_CreateUpdateAndSumError()
        {
            IGCube cube = Geometry.GeometryFactory.GetCube();
            cube.Create(2);
            cube.Update(new RappiChallenge.TO.PointTO() { X = 1, Y = 1, Z = 1, Value = 15 });

            Assert.AreEqual(
                cube.SumRegion(
                    new RappiChallenge.TO.PointTO() { X = 1, Y = 1, Z = 1 },
                    new RappiChallenge.TO.PointTO() { X = 2, Y = 2, Z = 2 })
                , Convert.ToDouble(10));
        }

        [TestMethod]
        public void Cube_CreateUpdateAndSumException()
        {
            IGCube cube = Geometry.GeometryFactory.GetCube();
            cube.Create(2);
            cube.Update(new RappiChallenge.TO.PointTO() { X = 1, Y = 5, Z = 1, Value = 15 });

            Assert.AreEqual(
                cube.SumRegion(
                    new RappiChallenge.TO.PointTO() { X = 1, Y = 1, Z = 1 },
                    new RappiChallenge.TO.PointTO() { X = 2, Y = 2, Z = 2 })
                , Convert.ToDouble(10));
        }
    }
}
