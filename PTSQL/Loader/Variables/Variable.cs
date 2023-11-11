using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSQL.Loader.Variables
{
    public class Variable
    {
        public string Name { get; set; }
        public Type Type { get; set; }
        public bool IsNullable { get; set; }

        private Variable(string name, Type type, bool isNullable = false) =>
           (Name, Type, IsNullable) = (name, type, isNullable);

        public static Variable Create(string name, Type type, bool isNullable = false) =>
            new Variable(name, type, isNullable);
    }
}
