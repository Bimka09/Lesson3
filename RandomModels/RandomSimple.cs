﻿using GuessNumber.Abstracts;
using GuessNumber.Interfaces;
using System;

namespace GuessNumber.RandomModels
{
    class RandomSimple : RandomizerBase
    {
        public override int RandomNumber()
        {
            var rnd = new Random();
            return rnd.Next(100);
        }
    }
}
