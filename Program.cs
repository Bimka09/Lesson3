using GuessNumber.RandomModels;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new GuessNumber(new NumDeterminant(), new CryptoRandom());
            app.Run();
        }
    }
}
