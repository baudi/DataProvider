using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace BusinessObject
{
    [DataContract(IsReference = true)]
    public class ClassDefinition
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public virtual Collection<AttributeDefinition> Attributes { get; set; }

        [DataMember]
        public virtual Collection<ClassInstance> ClassInstances { get; set; }

        [DataMember]
        public virtual Collection<Relationship> Relationships { get; set; }
    }
}
