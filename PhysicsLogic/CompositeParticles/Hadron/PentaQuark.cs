using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IQuantumTheory;
using QuantumTheory.StandardModel.Fermion;

namespace QuuantumTheory.CompositeParticles.Hadron
{
    [QuantumTheory.IsComposite(true)]
    public class PentaQuark
    {
        private List<Quark> _composition;

        public PentaQuark()
        { }

        public bool Assemble(List<Quark> quarks)
        {
            bool isValid = false;

            return isValid;
        }

        public List<Quark> Composition
        {
            get
            {
                return _composition;
            }

        }
    }
}
