using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
        }

        public void IQuit(Employee employee)
        {
            throw new InvalidProgramException();
        }

    }
}
