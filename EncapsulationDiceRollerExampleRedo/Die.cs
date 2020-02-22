using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDiceRollerExampleRedo
{
    /// <summary>
    /// A traditional die is a cube with each of its six faces marked with a different number of dots (pips) from one to six.
    /// </summary>
    public class Die
    {
        // static members get shared across all instances of this class
        private static Random rand;
        private byte faceValue;

        /// <summary>
        /// Static No-Arg Constructor. 
        /// Runs only once before any die objects are created, initializes rand object only once.
        /// </summary>
        static Die()
        {
            rand = new Random();
        }

        /// <summary>
        /// No-Arg Constructor, to roll die initially.
        /// </summary>
        public Die()
        {
            Roll();
        }

        /// <summary>
        /// Returns the current value of the die, 1-6
        /// </summary>
        public byte FaceValue
        {
            // converted to full property
            // get => faceValue; 
            get { return faceValue; }

            // private set => faceValue = value; 
            private set
            {
                if (value<1 || value>6)
                {
                    throw new ArgumentOutOfRangeException("Invalid face value");
                }
                faceValue = value;
            }
        }

        /// <summary>
        /// Returns boolean, if die is held they are not re-rolled.
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Returns the randomly generated value and sets FaceValue.
        /// When rolled, the die comes to rest showing on its upper surface a random integer from one to six, each value being equally likely.
        /// </summary>
        /// <returns></returns>
        public byte Roll()
        {
            // if current die is held, return current value (do not re-roll)
            if (IsHeld)
            {
                return FaceValue;
            }

            const byte minRoll = 1;     // random min value is inclusive
            const byte maxRoll = 6;     // random max value is exclusive, requires offSetValue
            const byte offSetValue = 1; // offset for Random.Next(lower, upper) lower bound is inclusive, upper bound is exclusive.

            byte rollResult = (byte)rand.Next(minRoll, maxRoll + offSetValue);

            FaceValue = rollResult;
            return rollResult;
        }
    }
}
