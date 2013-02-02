using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject
{
    public class AttributeInstance
    {
        public int AttributeInstanceId { get; set; }
        public string Value { get; set; }

        //Fk
        public int ClassInstanceId { get; set; }

        //Navigator
        public virtual ClassInstance AsignedClassInstance { get; set; }
        public virtual AttributeDefinition AsignedMyAttribute { get; set; }
    }
}
