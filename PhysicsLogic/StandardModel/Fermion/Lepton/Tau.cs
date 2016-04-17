using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumTheory.StandardModel.Lepton
{
    public class Tau : Lepton
    {
        public  Tau()
        {
            //Mass denoted for Tau particle
           Mass = 1776.82;
            //Tau charge is negative and anti mati particle is positive          
            //Spin is set in base Lepton classs
            
        }

        public override List<ElementaryParticle> Decay()
        {
            throw new NotImplementedException();
        }
    }
}
