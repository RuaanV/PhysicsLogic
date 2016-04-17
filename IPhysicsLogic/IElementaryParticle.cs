using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQuantumTheory
{
    /// <summary>
    /// Interface to pass a mutable particle 
    /// </summary>
    public class IElementaryParticle
    {
        double Charge { get; set; }
        double Mass { get; set; }
        double Spin { get; set; }
        double LifeTime { get; set; }

    }
}
