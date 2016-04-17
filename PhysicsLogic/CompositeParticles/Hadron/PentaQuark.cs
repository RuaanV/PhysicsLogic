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

        public PentaQuark(List<Quark> quarks)
        {
            Assemble(quarks);
              
        }

        public bool Assemble(List<Quark> quarks)
        {
            bool isValid = false;
            //Build validation logic for producing PentaQuark
            _composition = quarks;

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
