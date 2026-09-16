using System.Linq;
using System.Text.RegularExpressions;
namespace ConsoleApp3
{
    internal class Program
    {
        public class MenuObject(TimeOnly time, double price, string name)
        {
            public TimeOnly Time {
                get { return time; }
                set { time = value; }
            }
            public double Price {
                get { return price; }
                set { price = value; }
            }
            public string Name {
                get { return name;  }
                set { name = value; }
            }
        }
        static void Main(string[] args)
        {
            string Line = Console.ReadLine()?.Trim();
            string name = Convert.ToString(Regex.Match(Line, @"""([^""]*)"""));
            string price = Convert.ToString(Regex.Match(Line, @"\d+,\d+"));
            string time = Convert.ToString(Regex.Match(Line, @"\d+:\d+"));
            MenuObject newobject = new MenuObject(TimeOnly.Parse(time), Convert.ToDouble(price), name);
            Console.WriteLine(newobject.Name);
            Console.WriteLine(newobject.Price);
            Console.WriteLine(newobject.Time);
        }
    }
}
