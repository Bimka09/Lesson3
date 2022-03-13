using GuessNumber.Interfaces;
using System;

namespace GuessNumber
{
    class GuessNumber
    {
        private readonly int _number;
        private readonly IDeterminant _determinant;
        private readonly IRandomize _randomizer;

        public GuessNumber(IDeterminant determinant, IRandomize randomizer)
        {
            _randomizer = randomizer;
            _number = randomizer.RandomNumber();
            _determinant = determinant;
        }

        public void Run()
        {
            var gaming = true;

            Console.WriteLine("Число загадоно. Ваше предположение?");
            do
            {

                if (!int.TryParse(Console.ReadLine() ?? string.Empty, out var enteredN))
                {
                    Console.WriteLine("Полученное значение не является числом. Повторите ввод");
                    continue;
                }
                else
                {
                    gaming = _determinant.Determinant(enteredN, _number);
                }

            } while (gaming);
        }
    }
}
