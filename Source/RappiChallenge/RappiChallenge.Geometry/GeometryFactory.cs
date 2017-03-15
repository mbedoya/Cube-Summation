using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RappiChallenge.Geometry.GCube;

namespace RappiChallenge.Geometry
{
    /// <summary>
    /// Factory class, it creates concrete geometry objects implementations
    /// </summary>
    public class GeometryFactory
    {
        public static IGCube GetCube()
        {
            return new RappiChallenge.Geometry.GCube.RappiCube();
        }
    }
}
