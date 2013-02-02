namespace BusinessObject
{
    public class AttributeInstance
    {
        public long AttributeInstanceId { get; set; }
        public string Value { get; set; }

        public long ClassInstanceId { get; set; }
        
        public virtual ClassInstance AsignedClassInstance { get; set; }
        public virtual AttributeDefinition AsignedMyAttribute { get; set; }
    }
}
