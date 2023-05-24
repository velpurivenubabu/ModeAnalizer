using MoodAnalyser;

namespace ModeAnalizer
{

    public class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.WriteLine("mood analyser");
                HappySad happySad = new HappySad();
                string Result = happySad.AnalysingMood();
                Console.WriteLine(Result);
            }
        }
    }
}