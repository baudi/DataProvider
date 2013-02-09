using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace BusinessObject
{
    [DataContract(IsReference = true)]
    public class ClassInstance
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public long ClassDefinitionId;

        [DataMember]
        public virtual ClassDefinition ClassDefinition { get; set; }

        [DataMember]
        public virtual Collection<AttributeInstance> AttributeInstances { get; set; }

        [DataMember]
        public virtual Collection<ClassInstance> ClassRealations { get; set; }
    }
}
