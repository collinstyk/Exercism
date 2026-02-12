public class Robot
{
    static Random random = new Random();
    string name;
    static HashSet<string> usedNames = new HashSet<string>();

    public Robot()
    {
        name = GenerateUniqueName();
    }

    public string Name
    {
        get
        {
            return name;
        }
    }

    public void Reset()
    {
        usedNames.Remove(name);
        name = GenerateUniqueName();
    }

    public string GenerateUniqueName()
    {
        string newName;
        do
        {
            newName = $"{(char)random.Next('A', 'Z' + 1)}" + $"{(char)random.Next('A', 'Z' + 1)}" + $"{random.Next(0, 1000):D3}";
        } while (usedNames.Contains(newName));
        usedNames.Add(newName);
        return newName;
    }
}