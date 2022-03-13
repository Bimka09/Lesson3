using GuessNumber.Interfaces;
using System;

namespace GuessNumber
{
    class NumDeterminant:IDeterminant
    {

        public bool Determinant(int userInput, int number)
        {
            if(number == userInput)
            {
                Console.WriteLine("Число угадно верно");
                return false;
            }
            else if(number < userInput)
            {
                Console.WriteLine("Число меньше загаданного");
                return true;
            }
            else
            {
                Console.WriteLine("Число больше загаданного");
                return true;
            }
        }
    }
}
