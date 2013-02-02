using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject
{
    public class Relationship
    {
        public int RelationshipId { get; set; }
        public virtual ClassDefinition Source { get; set; }
        public virtual ClassDefinition Target { get; set; }
        public string Type { get; set; }
    }
}
