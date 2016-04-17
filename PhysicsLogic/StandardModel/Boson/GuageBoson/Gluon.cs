using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IQuantumTheory;
using QuantumTheory.StandardModel.Boson;

namespace QuantumTheory.StandardModel.Boson.GuageBoson
{
    public class Gluon : GaugeBoson
    {
        internal Gluon()
        { }

        public override List<ElementaryParticle> Decay()
        {
            throw new NotImplementedException();
        }
    }
}
