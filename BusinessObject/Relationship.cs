namespace BusinessObject
{
    public class Relationship
    {
        public long RelationshipId { get; set; }
        public string Type { get; set; }

        public virtual ClassDefinition Source { get; set; }
        public virtual ClassDefinition Target { get; set; }
    }
}
