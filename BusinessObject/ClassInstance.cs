using System.Collections.Generic;

namespace BusinessObject
{
    public class ClassInstance
    {
        public long ClassInstanceId { get; set; }    

        public virtual ClassDefinition AsignedMyClass { get; set; }
        public virtual ICollection<AttributeInstance> AttributeInstances { get; set; }
    }
}
