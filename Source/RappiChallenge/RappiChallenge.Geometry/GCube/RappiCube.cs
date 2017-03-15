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


        public bool Update(PointTO point)
        {
            ICubePersistence persistence = PersistenceFactory.GetCubePersistence();

            //Check Boundaries
            int dimensions = persistence.GetDimensions();

            if (point.X == 0 || point.Y == 0 || point.Z == 0)
            {
                throw new Exception("Cube is index 1, 0 was sent for x, y or z");
            }
            
            if (point.X > dimensions || point.Y > dimensions || point.Z > dimensions)
            {
                throw new Exception("Cube limits exceeded");
            }

            return persistence.Update(point);
        }
    }
}
