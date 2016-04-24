using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace uk.co.taxomania.orangeyblue
{
    enum Colour { RED, BLACK };
    sealed internal class GameEngine
    {
        private static Random rand = new Random();
        //public static double Probability(int guess)
        //{
        //    return Math.Pow(0.5, guess + 1);
        //}

        private static bool GetRandomBoolean()
        {
            return rand.Next(100) % 2 == 0;
        }

        //private static Colour Colour()
        //{
        //    return GetRandomBoolean() ? RedOrBlack.Colour.RED : RedOrBlack.Colour.BLACK;
        //}
        public static bool CheckColour(Colour colour) 
        {
            return GetRandomBoolean(); //Colour().Equals(colour);
        }
    }
}
