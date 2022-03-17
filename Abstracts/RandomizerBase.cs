using GuessNumber.Interfaces;

namespace GuessNumber.Abstracts
{
    abstract class RandomizerBase: IRandomize
    {
        abstract public int RandomNumber();
    }
}
