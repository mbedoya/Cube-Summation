using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RappiChallenge.TO;

namespace RappiChallenge.Persistence.CubePersistence
{
    public interface ICubePersistence
    {
        List<PointTO> GetValues();

        int GetDimensions();

        bool Update(PointTO point);
    }
}
