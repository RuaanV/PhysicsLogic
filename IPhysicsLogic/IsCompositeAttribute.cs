using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumTheory
{
    [AttributeUsage(AttributeTargets.Class)]
    public class IsCompositeAttribute : Attribute
    {
        private bool _compositeParticle;

        public bool IsCompositeParticle
        {
            get
            { return _compositeParticle; }
        }

        public IsCompositeAttribute(bool compositeParticle)
        {
            _compositeParticle = compositeParticle;
        }

    }
}
