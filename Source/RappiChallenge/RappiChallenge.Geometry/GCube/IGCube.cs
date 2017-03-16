using RappiChallenge.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RappiChallenge.Geometry.GCube
{
    public interface IGCube
    {
        /// <summary>
        /// This will only return point with values different from Zero (0)
        /// </summary>
        /// <returns>Cube Points</returns>
        List<PointTO> GetValues();

        /// <summary>
        /// Get the dimensions of the Cube (N)
        /// </summary>
        /// <returns>Return the N of the Cube or -1 if there is no Cube</returns>
        int GetDimensions();

        /// <summary>
        /// Update Cubes Point
        /// </summary>
        /// <param name="point">true if operation is successful</param>
        bool Update(PointTO point);

        /// <summary>
        /// Creates Cube
        /// </summary>
        /// <param name="dimensions">Dimensions (N) of the Cube</param>
        bool Create(int dimensions);

        /// <summary>
        /// Sum a Cubes Regions
        /// </summary>
        /// <param name="point1">Point 1</param>
        /// <param name="point2">Point 2</param>
        /// <returns>Sum of the Region</returns>
        double SumRegion(PointTO point1, PointTO point2);
    }
}
