using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject
{
    public class ClassInstance
    {
        public int ClassInstanceId { get; set; }
     

        public virtual ClassDefinition AsignedMyClass { get; set; }

        public virtual ICollection<AttributeInstance> AttributeInstances { get; set; }
    }
}
