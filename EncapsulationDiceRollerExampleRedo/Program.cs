using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDiceRollerExampleRedo
{
    class Program
    {
        static void Main(string[] args)
        {
            ////myDice.FaceValue = 6; // FaceValue is private, this is not allowed.

            Die[] dice = new Die[5];

            InitDice(dice);

            DisplayDieFaceValues(dice);

            HoldDice(dice);

            RollAllDIce(dice);

            DisplayDieFaceValues(dice);

            Console.ReadKey();
        }

        /// <summary>
        /// Initializes all dice in a give array,
        /// assumes an array has been given a length.
        /// </summary>
        /// <param name="dice"></param>
        private static void InitDice(Die[] dice)
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }
        }

        /// <summary>
        /// Displays dice face values on the console.
        /// </summary>
        /// <param name="dice"></param>
        private static void DisplayDieFaceValues(Die[] dice)
        {
            // print values
            for (int i = 0; i < dice.Length; i++)
            {
                Console.WriteLine(dice[i].FaceValue);
            }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// hold selected dies, first 3 dice
        /// </summary>
        /// <param name="dice"></param>
        private static void HoldDice(Die[] dice)
        {
            dice[0].IsHeld = true;
            dice[1].IsHeld = true;
            dice[2].IsHeld = true;
        }

        /// <summary>
        /// Roll All Dice in array
        /// </summary>
        /// <param name="dice"></param>
        private static void RollAllDIce(Die[] dice)
        {
            // Re-roll
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i].Roll();
            }
        }
    }
}
