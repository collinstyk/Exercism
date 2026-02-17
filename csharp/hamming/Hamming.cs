public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int distance = 0;
        if (firstStrand.Length != secondStrand.Length)
        {
            throw new ArgumentException("Both strands length are unequal!");
        }
        for (int i = 0; i < firstStrand.Length; i++)
        {
            if (firstStrand[i] != secondStrand[i]) distance++;
        }
        return distance;
    }
}