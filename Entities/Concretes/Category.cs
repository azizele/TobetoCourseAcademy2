using Core.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Category : Entity<int> 
    { 
      
        public string Name { get; set; }
        public List<Course> Courses { get; set; }

    }
}
