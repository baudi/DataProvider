using System.Runtime.Serialization;

namespace BusinessObject
{
    [DataContract(IsReference = true)]
    public class AttributeInstance
    {
        [DataMember]
        public long Id { get; set; }
        
        [DataMember]
        public string Value { get; set; }

        [DataMember]
        public long ClassInstanceId { get; set; }
        
        [DataMember]
        public virtual ClassInstance ClassInstance { get; set; }
        
        [DataMember]
        public long AttributeDefinitionId { get; set; }

        [DataMember]
        public virtual AttributeDefinition AttributeDefinition { get; set; }
    }
}
