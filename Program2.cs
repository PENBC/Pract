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
    public int FoundFives(int number)
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