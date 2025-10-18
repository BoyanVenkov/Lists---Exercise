int input = int.Parse(Console.ReadLine());

List<string> party = new List<string>();


for (int i = 1; i <= input; i++)
{
    string[] guests = Console.ReadLine().Split().ToArray();
    string name = guests[0];


    if (guests[2] == "going!")
    {
        if (party.Contains(name))
        {
            Console.WriteLine($"{name} is already in the list!");
        }
        else
        {
            party.Add(name);
        }
    }
    else if (guests[2] == "not")
    {
        if (party.Contains(name))
        {
            party.Remove(name);
        }
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }
    }
}
for (int i = 0; i < party.Count; i++)
{
    Console.WriteLine(party[i]);
}