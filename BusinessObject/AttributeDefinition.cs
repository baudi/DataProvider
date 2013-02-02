using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject
{
    public class AttributeDefinition
    {
        public int AttributeDefinitionId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }

        //FK with Classes
        public int ClassId { get; set; }
        //Prop navigator
        public virtual ClassDefinition AsignedMyClass { get; set; }
        public virtual ICollection<AttributeInstance> AttributeInstances { get; set; }

    }
}
