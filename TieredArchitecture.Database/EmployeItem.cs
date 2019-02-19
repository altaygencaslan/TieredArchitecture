using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TieredArchitecture.Database
{
    public class EmployeItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int StartDate { get; set; }
        public int CategoryId { get; set; }
        public virtual CategoryItem Category { get; set; }
    }
}
