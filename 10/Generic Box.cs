using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class GenericBox<T1,T2>
    {
        private T1 Value1;
        private T2 Value2;
        public GenericBox(T1 value1,T2 value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine( Value1+" -> "+Value2 );
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
