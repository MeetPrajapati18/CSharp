using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam1
{
    internal interface IBillable
    {

        decimal Bill();

        bool Validate();
    }
}
