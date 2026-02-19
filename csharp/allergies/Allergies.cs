using System.Collections;

public enum Allergen
{
    Eggs = 1, //00000001
    Peanuts = 2, //00000010
    Shellfish = 4,//00000100
    Strawberries = 8,//00001000
    Tomatoes = 16,//00010000
    Chocolate = 32,//00100000
    Pollen = 64,//01000000
    Cats = 128,//10000000
}

public class Allergies
{
    readonly int score = 0;
    public Allergies(int mask)
    {
        score = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return (score & (int)allergen) != 0;
    }

    public IEnumerable<Allergen> List()
    {
        foreach (Allergen allergen in Enum.GetValues(typeof(Allergen)))
        {
            if (IsAllergicTo(allergen))
            {
                yield return allergen;
            }
        }
    }
}