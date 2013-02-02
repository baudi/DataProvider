using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject
{
    public class ClassDefinition
    {
        public int ClassDefinitionId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AttributeDefinition> Attributes { get; set; }
        public virtual ICollection<ClassInstance> ClassInstances { get; set; }

        
    }
}
