using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TieredArchitecture.Business.Model
{
    public class EmployeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public int CategoryId { get; set; }
        public virtual CategoryModel Category { get; set; }
    }
}
