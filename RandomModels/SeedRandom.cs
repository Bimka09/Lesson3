using GuessNumber.Abstracts;
using GuessNumber.Interfaces;
using System;

namespace GuessNumber.RandomModels
{
    class SeedRandom : RandomizerBase, IRandomize
    {


        public override int RandomNumber()
        {
            var seed = Environment.TickCount;
            return seed;
        }
    }
}
