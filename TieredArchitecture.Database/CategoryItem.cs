using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TieredArchitecture.Database
{
    public class CategoryItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PopulationLimit { get; set; }
        public int LocationId { get; set; }
        public virtual LocationItem Location { get; set; }
    }
}
