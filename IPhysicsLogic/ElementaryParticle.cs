using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IQuantumTheory;
using IPhysicsLogic;

namespace QuantumTheory.StandardModel
{
    public abstract class ElementaryParticle : IElementaryParticle
    {
        /// <summary>
        /// Base Elementary Particle in the Standard Model
        /// </summary>
        public ElementaryParticle()
        {

            ///Constructor setting for base 
        }

        private double _spin;
        public double Spin
        {
            get { return _spin; }
            set { _spin = value; }
        }

        private SpinDirection _spinDirection;

        public SpinDirection Direction
        {
            get { return _spinDirection; }
            set { _spinDirection = value; }
        }

        private double _hyperCharge;
        public double HyperCharge
        {
            get { return _hyperCharge; }
            set { _hyperCharge = value; }

        }

        private double _mass;

        public double Mass
        {
            get { return _mass; }
            set { _mass = value; }
        }

        private double _lifetime;
        public double LifeTime
        {
            get { return _lifetime; }
            set { _lifetime = value; }

        }

        abstract public List<ElementaryParticle> Decay();

        private bool _isMatterParticle;
        public bool IsMatterParticle
        {
            get { return _isMatterParticle; }
            set { _isMatterParticle = value; }
        }

    }
}
