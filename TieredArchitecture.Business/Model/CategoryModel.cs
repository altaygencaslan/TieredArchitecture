using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TieredArchitecture.Business.Model
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PopulationLimit { get; set; }
        public int LocationId { get; set; }
        public virtual LocationModel Location { get; set; }
    }
}
