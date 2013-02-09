using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace BusinessObject
{
    [DataContract(IsReference = true)]
    public class AttributeDefinition
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public long ClassDefinitionId { get; set; }

        [DataMember]
        public virtual ClassDefinition ClassDefinition { get; set; }

        [DataMember]
        public virtual Collection<AttributeInstance> AttributeInstances { get; set; }
    }
}
