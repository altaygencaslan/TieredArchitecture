using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TieredArchitecture.Business.Model;
using TieredArchitecture.Database;

namespace TieredArchitecture.Business.LocationRepository
{
    internal interface ILocation
    {
        void Create(LocationModel location);
        LocationModel Read(int Id);
        void Update(LocationModel location);
        void Delete(int Id);
    }
}
