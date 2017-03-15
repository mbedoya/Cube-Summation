using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RappiChallenge.TO;
using RappiChallenge.Persistence;
using RappiChallenge.Persistence.CubePersistence;

namespace RappiChallenge.Geometry.GCube
{
    /// <summary>
    /// Class for Rappi Test Implementation of Cube
    /// </summary>
    public class RappiCube : IGCube
    {
        public List<PointTO> GetValues()
        {
            ICubePersistence persistence = PersistenceFactory.GetCubePersistence();
            return persistence.GetValues();
        }

        public int GetDimensions()
        {
            ICubePersistence persistence = PersistenceFactory.GetCubePersistence();

            //Check response en return data accordingly
            int dimensions = persistence.GetDimensions();
            if(dimensions == 0)
            {
                dimensions = -1;
            }
            return dimensions;
        }
    }
}
