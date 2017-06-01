
using QuantumTheory.StandardModel.Boson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumTheory.StandardModel.Fermion
{
    public abstract class Fermion: ElementaryParticle
    {
        private List<GaugeBoson> _gaugeBson;

        public List<GaugeBoson> Coupling
        {
            get
            { return _gaugeBson; }
            set
            { _gaugeBson = value; }
        }
/// <summary>
/// Testing Github Desktop
/// </summary>
/// <returns></returns>
        public double WeakIsospin
        { get; set; }

        public Double ElectricalCharge
        {
            get { return HyperCharge + WeakIsospin; }
        } 
    }
}
