List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
string[] command = Console.ReadLine().Split().ToArray(); ;

while (command[0] != "End")
{
    if (command[0] == "Add")
    {
        numbers.Add(int.Parse(command[1]));
    }
    if (command[0] == "Insert")
    {
        if (int.Parse(command[2]) < 0 || int.Parse(command[2]) >= numbers.Count)
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
        }
    }
    if (command[0] == "Remove")
    {
        if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= numbers.Count)
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            numbers.RemoveAt(int.Parse(command[1]));
        }

    }
    if (command[1] == "left")
    {
        for (int i = 1; i <= int.Parse(command[2]); i++)
        { 
        int num = numbers[0];
            numbers.RemoveAt(0);
            numbers.Add(num);
        }
    }
    if (command[1] == "right")
    {
        for (int i = 1; i <= int.Parse(command[2]); i++)
        {
            int num = numbers[numbers.Count - 1];
            numbers.RemoveAt(numbers.Count - 1);
            numbers.Insert(0, num);
        }
    }

    command = Console.ReadLine().Split();
}
Console.WriteLine(string.Join(" ", numbers));