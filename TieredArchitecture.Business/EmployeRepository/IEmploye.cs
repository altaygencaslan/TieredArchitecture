using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TieredArchitecture.Business.Model;
using TieredArchitecture.Database;

namespace TieredArchitecture.Business.LocationRepository
{
    internal interface IEmploye
    {
        void Create(EmployeModel employe);
        EmployeModel Read(int Id);
        void Update(EmployeModel employe);
        void Delete(int Id);
    }
}
