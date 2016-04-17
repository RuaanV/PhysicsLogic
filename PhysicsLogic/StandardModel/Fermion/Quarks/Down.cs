using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumTheory.StandardModel.Fermion
{
    public class Down: Quark
    {
        public Down()
        {
            HyperCharge = (1 / 6);
            Direction = IPhysicsLogic.SpinDirection.LEFT;
            WeakIsospin = -0.5;
        }

        public override List<ElementaryParticle> Decay()
        {
            throw new NotImplementedException();
        }
    }
}
