using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sessionliang_M_EF
{
    public class Person:Entity<long>
    {
        public virtual string Name { get; set; }

        public virtual int Age { get; set; }
    }
}
