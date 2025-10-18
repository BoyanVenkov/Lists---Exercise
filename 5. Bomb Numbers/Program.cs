List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();

int sum = 0;

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] == bomb[0])
    {
        int count = 0;
        for (int j = i -1; j >= 0; j--)
        {
            if (count == bomb[1])
            {
                break;
            }
            numbers[j] = 0;
            count++;
        }
        count = 0;
        for (int j = i + 1; j <= numbers.Count - 1; j++)
        {
            if (count == bomb[1])
            {
                break;
            }
            numbers[j] = 0;
            count++;
        }

        count = 0;
        numbers[i] = 0;
    }
}
foreach (int num in numbers)
{
    sum += num;
}
Console.WriteLine(sum);