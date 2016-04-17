using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumTheory.StandardModel.HiggsBoson
{
    [IsHypothetical(false)]
    public class HiggsBoson : ElementaryParticle
    {
        public HiggsBoson()
        {
            //Spin identified for Higgs set to 0
            Spin = 0;
        }

        public override List<ElementaryParticle> Decay()
        {
            throw new NotImplementedException();
        }

        public double WeakIsospin
        { get; set; }
    }
}
