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
    }
}
