using System.Linq;
using System.Text.RegularExpressions;
namespace ConsoleApp3
{
    internal class Program
    {
        public class Calc()
        {
            public int CountFives(List<int> numbers)
            {
                int answer = 0;
                foreach (int i in numbers)
                {
                    answer += FoundFives(i);
                }
                return answer;
            }
            public int FoundFives (int number)
            {
                if (number % 10 == 5)
                {
                    while (number < 10)
                    {
                        number = number % 10;
                    }
                    if (number == 5)
                    {
                        return 1;
                    }
                }
                return 0;
            }
        }
        public class MenuObject(TimeOnly time, double price, string name)
        {
            public TimeOnly Time
            {
                get { return time; }
                set { time = value; }
            }
            public double Price
            {
                get { return price; }
                set { price = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public override string ToString()
            {
                return $"{Name} {Price} {Time}";
            }
        }
        static void Main(string[] args)
        {
            string Line = Console.ReadLine()?.Trim();
            string name = Convert.ToString(Regex.Match(Line, @"""([^""]*)"""));
            string price = Convert.ToString(Regex.Match(Line, @"\d+,\d+"));
            string time = Convert.ToString(Regex.Match(Line, @"\d+:\d+"));
            MenuObject newobject = new MenuObject(TimeOnly.Parse(time), Convert.ToDouble(price), name);
            Console.WriteLine(newobject.ToString());
        }
    }
}