using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RappiChallenge.TO;
using RappiChallenge.Persistence.CubePersistence.MySql;

namespace RappiChallenge.Persistence.CubePersistence
{
    public class MySqlCubePersistence : ICubePersistence
    {
        public List<PointTO> GetValues()
        {
            return MySqlDAL.GetAll();
        }

        public int GetDimensions()
        {
            return 3;
        }
    }
}
