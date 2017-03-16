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
        private void ValidatePoint(PointTO point)
        {
            ICubePersistence persistence = PersistenceFactory.GetCubePersistence();
            int dimensions = persistence.GetDimensions();

            //Check Boundaries
            if (point.X <= 0 || point.Y <= 0 || point.Z <= 0)
            {
                throw new Exception("Cube is index 1, lower numbers are not allowed for x, y or z");
            }

            if (point.X > dimensions || point.Y > dimensions || point.Z > dimensions)
            {
                throw new Exception("Cube limits exceeded");
            }
        }

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

            //Point Validations
            ValidatePoint(point);

            //Check Value
            if (point.Value < Math.Pow(10, 9)*-1 || point.Value > Math.Pow(10, 9))
            {
                throw new Exception("Value is not allowed. -10^9 <= W <= 10^9");
            }

            return persistence.Update(point);
        }


        public bool Create(int dimensions)
        {
            ICubePersistence persistence = PersistenceFactory.GetCubePersistence();

            if (dimensions <= 0)
            {
                throw new Exception("Dimensions must be greater then Zero");
            }

            if (dimensions > 100)
            {
                throw new Exception("Maximum dimensions is 100");
            }

            return persistence.Create(dimensions);
        }


        public double SumRegion(PointTO point1, PointTO point2)
        {
            ICubePersistence persistence = PersistenceFactory.GetCubePersistence();

            //Point Validations
            ValidatePoint(point1);

            //Point Validations
            ValidatePoint(point2);

            return persistence.SumRegion(point1, point2);
        }
    }
}
