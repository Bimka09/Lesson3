using GuessNumber.Abstracts;
using GuessNumber.Interfaces;
using System;
using System.Security.Cryptography;

namespace GuessNumber.RandomModels
{
    class CryptoRandom : RandomizerBase
    {
        public override int RandomNumber()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buffer = new byte[4];

            rng.GetBytes(buffer);
            int result = BitConverter.ToInt32(buffer, 0);

            return new Random(result).Next(0, 100);
        }
    }
}
