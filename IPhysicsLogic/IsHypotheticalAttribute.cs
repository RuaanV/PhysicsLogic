using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumTheory
{
    [AttributeUsage(AttributeTargets.Class)]
    public class IsHypotheticalAttribute: Attribute
    {
        private bool _confirmed;

        public bool Confirmed
        {
            get
            { return _confirmed; }
        }

        public IsHypotheticalAttribute(bool hypothetical)
        {
            _confirmed = !hypothetical;
        }
    }
}
