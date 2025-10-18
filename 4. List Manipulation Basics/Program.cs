List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
string[] command = Console.ReadLine().Split().ToArray();

while (command[0] != "end")
{
    if (command[0] == "Add")
    {
        numbers.Add(int.Parse(command[1]));
    }
    if (command[0] == "Remove")
    {
        numbers.Remove(int.Parse(command[1]));
    }
    if (command[0] == "RemoveAt")
    {
        numbers.RemoveAt(int.Parse(command[1]));
    }
    if (command[0] == "Insert")
    {
        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
    }

    command = Console.ReadLine().Split().ToArray();
}
Console.WriteLine(string.Join(" ", numbers));