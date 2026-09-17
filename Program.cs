internal class Programm
{
    public class ConsoleReport<T>(List<T> args)
    {
        public void Describe()
        {
        }
    }
    public static void Main (string[] args)
    {
        List<string> words = new List<string> { "booba", "dooba", "gooba" };
        ConsoleReport<string> test = new ConsoleReport<string>(words);
    }
}
