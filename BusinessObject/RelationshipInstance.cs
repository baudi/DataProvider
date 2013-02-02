using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject
{
    public class RelationshipInstance
    {
        public int RelationshipInstanceId { get; set; }

        public virtual ClassInstance SourceI { get; set; }
        public virtual ClassInstance TargetI { get; set; }

        public string Typer { get; set; }

    }
}
