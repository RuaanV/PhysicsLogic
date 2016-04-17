using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuantumTheory.StandardModel;
using QuantumTheory.StandardModel.Boson.GuageBoson;
using IPhysicsLogic;

namespace QuantumTheory.StandardModel.Fermion
{
    public class Quark : Fermion
    {
        private List<Gluon> _exchangeParticles;
        public List<Gluon> ExchangeParticles
        {
            get { return _exchangeParticles; }
            set { _exchangeParticles = value; }
        }

        private List<ColourCharge> _colour;
        public List<ColourCharge> Colour
        {
            get {
                //TODO: Implement logic to calculate colour to return as part of the SU3 (3X3 - 1) lattice
                return _colour; }
        }

        public Quark()
        {
            //Set base spin for Fermion - consider base Fermion class?
            //Quark set classified as Fermion particle
            Spin = 0.5;
            IsMatterParticle = true;
        }

        public override List<ElementaryParticle> Decay()
        {
            throw new NotImplementedException();
        }

    }
}

