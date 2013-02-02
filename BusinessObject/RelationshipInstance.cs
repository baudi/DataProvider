namespace BusinessObject
{
    public class RelationshipInstance
    {
        public long RelationshipInstanceId { get; set; }
        public string Typer { get; set; }

        public virtual ClassInstance SourceI { get; set; }
        public virtual ClassInstance TargetI { get; set; }
    }
}
