using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumTheory.StandardModel.Boson.GuageBoson
{
    [IsHypothetical(true)]
    public class Graviton : GaugeBoson
    {
        /// <summary>
        /// Default a new graviton to its default properties
        /// </summary>
        public Graviton()
        {
            //Graviton is a massless particle
            Mass = 0;
            //Spin is set to 2 as default, LIGO experiment
            Spin = 2;
        }

        public override List<ElementaryParticle> Decay()
        {
            throw new NotImplementedException();
        }
    }
}
