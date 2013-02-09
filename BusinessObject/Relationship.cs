using System.Runtime.Serialization;

namespace BusinessObject
{
    [DataContract(IsReference = true)]
    public class Relationship
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public virtual ClassDefinition Source { get; set; }

        [DataMember]
        public virtual ClassDefinition Target { get; set; }

        [DataMember]
        public string Type { get; set; }
    }
}
