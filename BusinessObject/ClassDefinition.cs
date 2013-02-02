using System.Collections.Generic;

namespace BusinessObject
{
    public class ClassDefinition
    {
        public long ClassDefinitionId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AttributeDefinition> Attributes { get; set; }
        public virtual ICollection<ClassInstance> ClassInstances { get; set; }
    }
}
