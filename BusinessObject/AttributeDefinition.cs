using System.Collections.Generic;

namespace BusinessObject
{
    public class AttributeDefinition
    {
        public long AttributeDefinitionId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }

        public int ClassId { get; set; }
        
        public virtual ClassDefinition AsignedMyClass { get; set; }
        public virtual ICollection<AttributeInstance> AttributeInstances { get; set; }
    }
}
