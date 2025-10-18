List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
int capacity = int.Parse(Console.ReadLine());

string[] input = Console.ReadLine().Split();

while (input[0] != "end")
{
    if (input[0] == "Add")
    {
        train.Add(int.Parse(input[1]));
    }
    else
    {
        for (int i = 0; i < train.Count; i++)
        {
            if (int.Parse(input[0]) + train[i] <= capacity)
            {
                int passengers = int.Parse(input[0]);
                train[i] += passengers;
                break;
            }
        }
    }

        input = Console.ReadLine().Split();
}
    Console.Write(string.Join(" ", train));