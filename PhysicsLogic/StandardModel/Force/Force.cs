using System;
using QuantumTheory;
using IPhysicsLogic;

namespace QuantumTheory.StandardModel.Force
{
    public class Force
    {
        internal double _force;

        public Force()
        {

        }
        public Force(Type type)
        {
            Particles particle = 0;
            //Derive type and get particle type
            //Set force based on type of particle - Only Bosons carry force between Fermions
            switch(particle)
            {
                default:
                    // set a default force value - shold be zero
                   case Particles.MUON: { _force = 0.5; }
                  
                    break;
            }
        }
    }
}
