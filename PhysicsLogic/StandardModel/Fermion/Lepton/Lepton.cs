using QuantumTheory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuantumTheory.StandardModel.Fermion;

namespace QuantumTheory.StandardModel.Lepton
{
    public abstract class Lepton: QuantumTheory.StandardModel.Fermion.Fermion
    {
        public Lepton()
        {
            //set base spin for Fermion - consider base Fermion class?
            //Quark set classified as Fermion particle
            Spin = 0.5;
            IsMatterParticle = true;
        }

    }
}
