using RappiChallenge.Persistence.CubePersistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RappiChallenge.Persistence
{
    public class PersistenceFactory
    {
        public static ICubePersistence GetCubePersistence()
        {
            return new RappiCubePersistence();
        }
    }
}
