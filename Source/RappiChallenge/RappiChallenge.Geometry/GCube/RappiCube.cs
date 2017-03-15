using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RappiChallenge.TO;

namespace RappiChallenge.Geometry.GCube
{
    /// <summary>
    /// Class for Rappi Test Implementation of Cube
    /// </summary>
    public class RappiCube : IGCube
    {
        public List<PointTO> GetValues()
        {
            List<PointTO> points = new List<PointTO>();
            points.Add(new PointTO() { X = 1, Y = 1, Z = 1, Value = 3 });
            points.Add(new PointTO() { X = 1, Y = 2, Z = 1, Value = 5 });

            return points;
        }

        public int GetDimensions()
        {
            return 3;
        }
    }
}
