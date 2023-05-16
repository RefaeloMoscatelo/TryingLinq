using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryingLinq
{
   public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return string.Format("Age: {0}  Name:  {1} Email  {2}", Age,Name,Email);
        }
    }
    
}
