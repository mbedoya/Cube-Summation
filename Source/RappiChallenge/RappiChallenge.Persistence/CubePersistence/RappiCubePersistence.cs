using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RappiChallenge.TO;
using RappiChallenge.Persistence.CubePersistence.MySql;
using RappiChallenge.Persistence.CubePersistence.IO;

namespace RappiChallenge.Persistence.CubePersistence
{
    public class RappiCubePersistence : ICubePersistence
    {
        public List<PointTO> GetValues()
        {
            return MySqlDAL.GetAll();
        }

        public int GetDimensions()
        {
            return IODAL.GetDimensions();
        }

        public bool Update(PointTO point)
        {
            try
            {
                MySqlDAL.Update(point);
                return true;
            }
            catch (Exception)
            {
                return false;
            }    
        }

        public bool Create(int dimensions)
        {
            try
            {
                MySqlDAL.Delete();
                IODAL.SaveDimensions(dimensions);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public double SumRegion(PointTO point1, PointTO point2)
        {
            return MySqlDAL.SumRegion(point1, point2);
        }
    }
}
